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
using System.Windows.Shapes;
using System.Timers;
using Microsoft.Win32;

namespace PredmetniProjekat
{

    public partial class DodajNovi : Window
    {
        static OpenFileDialog dialog = new OpenFileDialog();

        static BitmapImage bmp1 = new BitmapImage();
        string[] karoserija = { "Limuzina", "Karavan", "Sum/Dzip", "Kupe", "Hecbek", "Kabriolet", "Pick up" };
        int s;

        public DodajNovi(int par)
        {
            InitializeComponent();
            comboBox.ItemsSource = karoserija;
        //    kalendar.SelectedDate.Value.ToShortDateString();
            dialog.FileName = "X";
            if (par == -1)
            {
                s = -1;
            }
            else
            {
                s = par;
                tb1.Text = MainWindow.automobili[s].Model;
                tb2.Text = MainWindow.automobili[s].Oznaka;
                tb3.Text = MainWindow.automobili[s].Opis;

                kalendar.SelectedDate = MainWindow.automobili[s].Vreme;
              //  MainWindow.automobili[s].Vreme.ToShortDateString();


                
                if (comboBox.SelectedItem == "0")
                    MainWindow.automobili[s].Karoserija = "Limuzina";
                else if (comboBox.SelectedItem == "1")
                    MainWindow.automobili[s].Karoserija = "Karavan";
                else if (comboBox.SelectedItem == "2")
                    MainWindow.automobili[s].Karoserija = "Sum/Dzip";
                else if (comboBox.SelectedItem == "3")
                    MainWindow.automobili[s].Karoserija = "Kupe";
                else if (comboBox.SelectedItem == "4")
                    MainWindow.automobili[s].Karoserija = "Hecbek";
                else if (comboBox.SelectedItem == "5")
                    MainWindow.automobili[s].Karoserija = "Kabriolet";
                else
                    MainWindow.automobili[s].Karoserija = "Pick up";
                    




                comboBox.SelectedItem = MainWindow.automobili[s].Karoserija.ToString();
                Cena.Text = MainWindow.automobili[s].Cena.ToString();
                Image.Source = new BitmapImage(new Uri(MainWindow.automobili[s].Image));

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool res = validation();

            if (res == true)
            {
                if (s == -1)
                {
                    Audi a = new Audi();
                    a.Model = tb1.Text;
                    a.Oznaka = tb2.Text;
                    a.Opis = tb3.Text;
                    a.Cena = Int32.Parse(Cena.Text);
                    a.Karoserija = comboBox.SelectedIndex.ToString();


                    a.Vreme = kalendar.SelectedDate.Value.Date;
                    

                    
                    if(a.Karoserija == "0")
                    {
                        a.Karoserija = "Limuzina";
                    }
                    else if(a.Karoserija == "1")
                    {
                        a.Karoserija = "Karavan";
                    }
                    else if(a.Karoserija == "2")
                    {
                        a.Karoserija = "SUV/Dzip";
                    }
                    else if(a.Karoserija == "3")
                    {
                        a.Karoserija = "Kupe";
                    }
                    else if(a.Karoserija == "4")
                    {
                        a.Karoserija = "Hecbek";
                    }
                    else if(a.Karoserija == "5")
                    {
                        a.Karoserija = "Kabriolet";
                    }
                    else if(a.Karoserija == "6")
                    {
                        a.Karoserija = "Pick up";
                    }
           
                    a.Image = Image.Source.ToString();
                    MainWindow.automobili.Add(a);
                   
             
                    this.Close();
                }
                else
                {
                    Audi a = new Audi();
                    a.Model = tb1.Text;
                    a.Oznaka = tb2.Text;
                    a.Opis = tb3.Text;
                    a.Cena = Int32.Parse(Cena.Text);
                    a.Karoserija = comboBox.SelectedIndex.ToString();

                    if (a.Karoserija == "0")
                    {
                        a.Karoserija = "Limuzina";
                    }
                    else if (a.Karoserija == "1")
                    {
                        a.Karoserija = "Karavan";
                    }
                    else if (a.Karoserija == "2")
                    {
                        a.Karoserija = "SUV/Dzip";
                    }
                    else if (a.Karoserija == "3")
                    {
                        a.Karoserija = "Kupe";
                    }
                    else if (a.Karoserija == "4")
                    {
                        a.Karoserija = "Hecbek";
                    }
                    else if (a.Karoserija == "5")
                    {
                        a.Karoserija = "Kabriolet";
                    }
                    else if (a.Karoserija == "6")
                    {
                        a.Karoserija = "Pick up";
                    }

                    a.Image = Image.Source.ToString();
                    a.Vreme = kalendar.SelectedDate.Value.Date;
                    MainWindow.automobili[s] = a;
                    this.Close();
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            dialog.FileName = "X";
            dialog.InitialDirectory = @"Projekat\Nikola_Miljkovic_pr54-2017\PredmetniProjekat";
            dialog.Title = "Odaberite sliku";
            dialog.Filter = "Podrzane ekstenzije|*.jpg;*.jpeg;*.png|" + "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" + "Portable Network Graphic (*.png)|*.png";
            if (dialog.ShowDialog() == true)
            {
                Image.Source = new BitmapImage(new Uri(dialog.FileName)); 
                bmp1 = new BitmapImage(new Uri(dialog.FileName));
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void tb1_TextInput(object sender, TextCompositionEventArgs e)
        {
            if (tb1.Text == "ovde upisiti koji audi model zelite dodati ...")
            {
                tb1.Text = "";
            }
        }



        private void tb1_MouseEnter(object sender, MouseEventArgs e)
        {
            if (tb1.Text == "ovde upisiti koji audi model zelite dodati ...")
            {
                tb1.Text = "";
            }
        }

        private void tb2_MouseEnter(object sender, MouseEventArgs e)
        {
            if (tb2.Text == "ovde upisiti oznaku modela zelite dodati ...")
            {
                tb2.Text = "";
            }
        }

        private void tb3_MouseEnter(object sender, MouseEventArgs e)
        {
            if (tb3.Text == "ovde opisite vas model automobila...")
            {
                tb3.Text = "";
            }
        }

        private void tb7_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Cena.Text == "Unesite cenu vozila u evrima")
            {
                Cena.Text = "";
            }
        }

        private bool validation()
        {
            bool result = true;

            if (tb1.Text.Trim().Equals(""))
            {
                labelGreska1.Content = "Niste uneli model!";
                tb1.BorderBrush = Brushes.Red;
                result = false;
            }

            else
            {
                labelGreska1.Content = "";
                tb1.BorderBrush = Brushes.Black;
            }

            if (tb2.Text.Trim().Equals(""))
            {
                labelGreska2.Content = "Niste uneli oznaku modela";
                tb2.BorderBrush = Brushes.Red;
                result = false;
            }
            else
            {
                labelGreska2.Content = "";
                tb2.BorderBrush = Brushes.Black;

            }

            if (tb3.Text.Trim().Equals(""))
            {
                labelGreska3.Content = "Molimo popunite sva polja";
                tb3.BorderBrush = Brushes.Red;
                result = false;
            }
            else
            {
                labelGreska3.Content = "";
                tb3.BorderBrush = Brushes.Black;
            }


            if (comboBox.SelectedItem == null)
            {
                labelGreska5.Content = "Morate odabrati opciju";
                result = false;
                comboBox.Foreground = Brushes.Red;               
            }
            else
            {
                labelGreska5.Content = "";
                comboBox.Foreground = Brushes.Black;
            }


            if(kalendar.SelectedDate == null || kalendar.DisplayDate > DateTime.Now)
            {
                labelKalendar.Content = "Morate odabrati vreme unosa koje je manje od danasnjeg datuma !";
                result = false;
                kalendar.Foreground = Brushes.Red;
            }
            else
            {
                labelKalendar.Content = "";
                kalendar.Foreground = Brushes.Black;
            }
            
            if(Image.Source == null)
            {
                labelGreska4.Content = "Niste ucitali sliku !";
                result = false;
                Odaberi.Foreground = Brushes.Red;
            }
            else
            {
                labelGreska4.Content = "";
                Odaberi.Foreground = Brushes.Black;
            }

           
            if (Cena.Text.Trim().Equals(""))
            {
                labelCena.Content = "Upisite cenu vozila...";
                Cena.BorderBrush = Brushes.Red;
                result = false;
            }
            else
            {
                labelCena.Content = "";
                Cena.BorderBrush = Brushes.Black;

                try
                {
                    int pom = int.Parse(Cena.Text.Trim());

                    if (pom > 0 && pom < 100000)
                    {
                        
                    }
                    else
                    {
                        labelCena.Content = "Morate uneti cenu [0 - 100.000e]";
                        Cena.BorderBrush = Brushes.Red;

                        result = false;
                    }

                }
                catch (Exception e)
                {
                    labelCena.Content = "Mora biti broj!";
                    Cena.BorderBrush = Brushes.Red;

                    result = false;
                }


            }

            return result;
        }
    }
    
    
}

