   M S B A M L   `   `   `  ????K  GAuthographManual, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:AuthographManualAuthographManual  5   	   !    AuthographManual.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:AuthographManual     5   	     ? Title$3  -Основы работы в Автограф??5   	    ? Icon$ /Resources/icon.ico??6*   $	??900??5	   	   $	??600??6    ? WindowState$ 	Maximized=?6(    ? 	Resources 5
       ?? 
TargetType   
MenuButton  PrimaryButton ?? BasedOn ?? Property ?? Value??%[   &	        7  ?? 5   
   " ??6   8   .?5      ??  ? ??$ 10q?6(   5      5      .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $
??Auto ?6   ?? 5      .+?5   
   ?? .+?5      ?? $"??/Resources/autographLogo.png??6   $	??200??6:   ?? 5      -   5        	 ??Name$	 ManualButton??5      #??[  6+   $1??+Теоретический материал??6O   6p   ?? 5      -   5        $	 
HelpButton??5      #??[  6)   $??О программе??6M   6c   ?? 5      $??Тестирование??6   $??Center=?6+     PrimaryLabel#??[ 6H   $??
5, 0, 5, 0q?6n   ?? 5      -   5        $	 TestInterfaceButton??5      #??[  62   $??Интерфейс??6V   6j   ?? 5      -   5        $	 TestWork1Button??5      #??[  6.   $.??(Работа в программе ч. 1??6R   6t   ?? 5      -   5        $	 TestWork2Button??5      #??[  6.   $.??(Работа в программе ч. 2??6R   6t   5       ? 5   
   -   5        
  ?Name$
 	MainFrame??5      $??1??6#     ? NavigationUIVisibility$ Hidden=?63   ???#E0FFFF6S   5      5      