   M S B A M L   `   `   `  ����C  ?ICommand, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ICommandICommand  5   	   9!clr-namespace:ICommand.ViewModelsICommand.ViewModels  5   	   1clr-namespace:ICommand.ModelsICommand.Models  5	   	       ICommand.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:ICommand     5   	   "vmICommand.ViewModels     5   	   1vm1!clr-namespace:ICommand.ViewModels     5   	   +mclr-namespace:ICommand.Models     5	   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5      '   !ICommand.ViewModels.ViewModelBase   	viewModel   ICommand.Models.Person 
 person��%:   &	        &	        5   
   6     5   
   6   5      .��5      �  � DataContext 6   ��  �� Source# [ .+�5   
   �� $��Button��6   $
��Left=�5      $��350,166,0,0q�6,   $	��Top=�6A   $	��106��6Y   $��46��6e   ��5      �� # [   �� Path$ simpleCommand���5      �� *
FullName+5   e   �� 5   
   $
��Left=�5   
   $��23��6%   $��350,117,0,0q�61    �� TextWrapping$
 Wrap=�6F   $	��Top=�6Z   $	��120��6r   ��5      �� *
FullName+5   r   5      5      