   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   -   5          � Title$  
MainWindow��5   	    � WindowStyle$
 None=�6M    � AllowsTransparency . 
������ $	��799��5	   #   $
��1100��60   .��5
      �� $	��411��6   $	��852��6   $��124,194q�6&   .+�5   
   F� -   5        $��UIPath��5   1   
�������$��2��6    J� RenderTransformOrigin$ 0.5,0.5&�6?    �� Stretch$
 Fill=�6_   
 �� Top$	 -79��6n   $	��561��6   $
��1010��6�    �� Left$	 -91��6�   z�5      V� 5      .~�5      �� �� 5       �� AngleY$ 0.311Q�6$   �� 5      T� 5       T� Y$ 1.495Q�6)   5      ��5      �� 5      	 �� 
StartPoint$	 0.2,0&�6&   
 �� EndPoint$
 0.8,1&�69   .��5      �  � Color$ Green��6#    � Offset$ 0Q�61   � 5      $ Yellow��6#   $
 0.35Q�63   � 5      $ Orange��6#   $
 0.65Q�62   � 5      $	 Red��6#   $
 0.85Q�6/   5      ��5      B� 5      .��5      E�  E� 
StartPoint$ 50,100&�6!   .��5       ��  �� Size$ 150,150��6%    �� RotationAngle$ 45Q�64    �� 
IsLargeArc .  �� SweepDirection$ CounterClockwise=�5"   %    �� Point$ 100,50&�6G   �� 5#       �� Point$ 20,20&�6&   5$      5%      5'      ]� 5)   
   $ 10��6   $ 47��6%   $	��324��65   $	��832��6B   .+�5*      c� $	��Top=�6   $��0,0,51,0q�6+   $��Right=�6=   $	��730��6Y   ���	#FFEEF5FD
�������.@�5+      �� -   5        $	��new��5+       � ToolTip$	 New��6$   .��5,      �� $B��<https://cdn0.iconfinder.com/data/icons/iconico-3/1024/55.png��6   $��61��6b   $��16��6m   5-      �� 5.      -   5        $
��open��5.      $
 open��6%   .��5/      �� $%��https://i.imgur.com/FgL1IRM.jpg��6   $��61��6E   $��16��6P   50      �� 52      �� 53      -   5        $
��save��53      $
 Save��6%   .��54      �� $S��Mhttps://cdn1.iconfinder.com/data/icons/ui-colored-2-of-3/100/UI_2__33-512.png��6   $��16��6s   $��16��6~   55      �� 57      �� 58      -   5        $��saveas��58      $ save as��6'   .��59      �� $]��Whttp://icons.iconarchive.com/icons/custom-icon-design/pretty-office-7/256/Save-icon.png��6   $��61��6}   $��16��6�   5:      d� 5>      -   5        $��	btnItalic��5>   F   $"��EditingCommands.ToggleItalic��6   $��I��6W   �� 5@      d� 5A      -   5        $��btnBold��5A   D   $ ��EditingCommands.ToggleBold��6   $��B��5B      
���   �6+   �� 5D      d� 5E      -	   5        $��btnUnderline��5E   I   $%��EditingCommands.ToggleUnderline��6   $��U��6]   
���   �6i   �� 5H      �� 5I      -
   5        $��cmbFontFamily��5I      $	��150��60   6<   �� 5J      �� 5K      -   5        $��cmbFontSize��5K      $��70��6.    �� 
IsEditable . 
���   �6}   �� 5L      �� 5M      -   5         ��Name$ cmbFontColor��5M      $	��100��61   
���   ���5N      �� 5O      .R�5P      ��  �� Orientation$ 
Horizontal=�6)   .+�5Q   "   �� $��16��6B   $��16��6M   $��0,2,5,2q�6Y   ��6,   �� *Name+6Y   �� 5R   "   ��6,   �� *Name+5S      5T      5V      �� 5W      �� 5X      -   5         ��Name$ buttonDT��5X      $��Center=�6,   $��20��6_   $��70��6k   $��10,0,0,0q�6v   .��5Y      �� $��14��6   $%��https://i.imgur.com/aS2pAiv.jpg��6(   $��14��6Q   5Z      5[      5\      �� 5]      -   5        $��	rtbEditor��5]      $	��730��6Y   
�������
�������6x   5^      �� 5_   
   $��25��6   $	 123��6    $	 376��62   $	��540��6C   .@�5`      �� 
�������$	��196��6/   .��5a      �� -   5         ��Name$ textBox��5a       �� 
IsReadOnly .  �� TextWrapping$
 Wrap=�6=   $�� ��6Q   $��90��6Y   
������ 
������ 6~   5b      �� 5c      �� 5d      $	��413��6   
�������.��5e      �� -   5        $��lblCursorPosition��5e      $	��150��66   5f      5g      �� 5h   
   -   5        $��btnClose��5h      $��Close��69   $	 274��6I   $	 406��6[   $ 0.394,0.125&�6l   $��38��6�   $	��110��6�   
�������6�   �� 5i   
   -   5        $��ButtonFindAndReplace��5i      $��Find and Replace��6-   $	��110��6H   $	 438��6w   $	 406��6�   $��38��6�   
�������6�   �� 5j   
   $��WordPad��6   $	 300��6"   $	 -29��64   $	��210��6E   $
��Bold"�6Q   $��46(�6c   5k      5m      