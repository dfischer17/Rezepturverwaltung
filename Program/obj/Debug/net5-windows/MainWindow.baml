   M S B A M L   `   `   `  ����B  >Program, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ProgramProgram  5   	   C ?Viemodel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5(clr-namespace:Viemodel;assembly=ViemodelViemodel 5   	       Program.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Program     5   	   >	viewmodel(clr-namespace:Viemodel;assembly=Viemodel     5   	   -   5          � Title$  
MainWindow��5	   	   $	��700��6   $	��800��6)    � DataContext 5         Viemodel.ResourceViewModel  5   
   6(   .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   6,   �� 5      $��1* �6   6,    � RowDefinitions 5   
   �� 5      $��2* �6   6*   �� 5      $��* �6   6)   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��resourceGrid��5         AutoGenerateColumns$ False��6'   $��0��6C   $��0��6S   $��2��6`   ��6t   �� *	Resources+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6<   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6%   �� *Id+6<     5      $ Bezeichnung��6>   	 6%   �� *Name+6>     5      $ Menge��6@   	 6%   �� *Amount+6@     5      $ Einheit��6>   	 6%   �� *Unit+6>     5      $ 
Nettopreis��6B   	 6%   �� *
Netprice+6B     5      $ 
Steuersatz��6A   	 6%   �� *	Taxrate+6A   5!      �� 5#   
   $��0��6   $��1��6%   .+�5$      �� 
 �� Orientation$
 
Horizontal=�6   $��0 0 0 10q�62   .+�5%      �� $��Bezeichnung:��6   61   �� 5&      $��200px��6   ��6(   �� *DescriptionTxtBox+$ TwoWay=�$ PropertyChanged=�6   5'      �� 5(      $
 
Horizontal=�6   $��0 0 0 10q�62   .+�5)      �� $��Menge:��6   6+   �� 5*      $��200px��6   ��6(   �� *AmountTxtBox+$ TwoWay=�$ PropertyChanged=�5+      �� 5,      $
 
Horizontal=�6   $��0 0 0 10q�62   .+�5-      �� $��Einheit:��6   6-   �� 5.      $��200px��6   ��6(   �� *Unit+$ TwoWay=�$ PropertyChanged=�6r   5/      �� 50      $
 
Horizontal=�6   $��0 0 0 10q�62   .+�51      �� $��Nettopreis:��6   60   �� 52      $��200px��6   ��6(   �� *NetpriceTxtBox+$ TwoWay=�$ PropertyChanged=�6|   53      �� 54      $
 
Horizontal=�6   $��0 0 0 10q�62   .+�55      �� $��Steuerprozentsatz:��6   67   �� 56      $��200px��6   ��6(   �� *TaxrateTxtBox+$ TwoWay=�$ PropertyChanged=�6{   57      �� 58      $��Rezept hinzufügen��6   ��61   �� *AddResourceCommand+$ OneWay=�6g   59      5:      5;      