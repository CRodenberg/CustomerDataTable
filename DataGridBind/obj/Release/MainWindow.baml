   M S B A M L   `   `   `  ����   DataGridBind    DataGridBind.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  
MainWindow��$	��350��$	��620��.��� $	��350��$	��625�����	#FFD1F9EE.+��� -   $��textBlockHeading��$��32��$
��Left=�$��	16,15,0,0q�$��	Customers��$	��Top=�$	��310��$��20(�$��Normal&��� -   $��textBoxQuery��$��32��$��Right=�$��	0,15,40,0q�$	��Top=�$	��400��$��20(�$��Normal&�� $
��Left=�$	��310��$	��Top=�$	��625��.+�&   System.Windows.Controls.DataGrid  -   $��dataGridCustomers��   AutoGenerateColumns .  $
��Left=�$��
14,55,0,46q�$	��575��   CanUserResizeRows .  ����  �� Path$ LoadDataBinding�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ 
CustomerID��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 100    
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� $ 
CustomerID�  $
 Name��$	 100  .  �� $ ContactName�  $ Address��$	 150  .  �� $ Address�  $
 City��$	 100  .  �� $
 City�  $ Phone��$	 120  .  �� $ Phone��� -   $��btnloaddata��$��	Load Data��$��25��$
��Left=�$��487,275,0,0q�$	��Top=�$	��100��