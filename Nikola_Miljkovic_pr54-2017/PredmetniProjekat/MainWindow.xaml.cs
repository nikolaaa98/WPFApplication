using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;
using System.ComponentModel;
using System.IO;
using System.Linq;


namespace PredmetniProjekat
{

    public partial class MainWindow : Window
    {
        public static BindingList<Audi> automobili;

        public static BindingList<Audi> Automobili
        {
            get { return automobili; }
            set { automobili = value; }
        }

        public MainWindow()
        {
          
            if (automobili == null)
            {
                automobili = new BindingList<Audi>();
            }        
            InitializeComponent();
            DataContext = this;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DodajNovi newWindow = new DodajNovi(-1);
            newWindow.ShowDialog();
            gridName.ItemsSource = automobili;
        }   

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void read_click(object sender, RoutedEventArgs e)
        {
            int i = gridName.SelectedIndex;
            Prikaz prz = new Prikaz(i);
            prz.ShowDialog();
        }

        private void obrisi_click(object sender, RoutedEventArgs e)
        {
            Audi audi = (Audi)gridName.CurrentItem;
            automobili.Remove(audi);
        }

        private void izmeni_click(object sender, RoutedEventArgs e)
        {
            int i = gridName.SelectedIndex;           
            DodajNovi novi = new DodajNovi(i);  
            novi.ShowDialog();
        }
    }
}
