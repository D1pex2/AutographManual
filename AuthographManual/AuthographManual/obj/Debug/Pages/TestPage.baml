   M S B A M L   `   `   `  ����K  GAuthographManual, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:AuthographManual.PagesAuthographManual.Pages  5      E'clr-namespace:AuthographManual.ControlsAuthographManual.Controls  6:   %    AuthographManual.Pages.TestPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:AuthographManual.Pages     5      <controls'clr-namespace:AuthographManual.Controls     6:     N� Title$  TestPage��5	       � 	Resources 5
       �� 
TargetType �� Property �� Value��%�   '��       �� 5   
   " ��6   .�5      ��  � ��$ Center=�62   �� 5       � ��$ Center=�64   �� 5       � �� �#E0FFFF6+   �� 5       � ��$ 90��6*   �� 5       � ��$	 300��6)   5      5      .��5      � .+�5   
   �� -   5         ��Name$ StartStackPanel��5      .+�5      �� -   5         ��Name$ TestTitleTextBlock��5      $d��^Для начала тестирования нажмите на кнопку «Начать»��64      PrimaryTextBlock#��[  6o   $
��Wrap=�6�   �� 5      -   5         ��Name$ StartButton��5      $��Начать��6*     PrimaryButton#��[ 6;   6b   � 5       � ColumnDefinitions 5      �� 5      $��1* �6'   �� 5      .+�5      �� $����Cистема оценивания:
85% правильных ответов - оценка 5                        
75% правильных ответов - оценка 4                        
60% правильных ответов - оценка 3
��6   $
��Wrap=�5   E   �� 5      $��1��6   $����Время на ответ:
Вопрос с одним ответом - 30 сек.                            
Вопрос с несколькими ответами - 60 сек.                            
Вопрос с открытым ответом - 90 сек.��6,   $
��Wrap=�5!   F   5"      5#      �� 5$   
   -   5        $ TestStackPanel��5$      $y�	Collapsed=�6-   .+�5%      %   AuthographManual.Controls.Quest  -   5        	  Name$	 Quest��5%      5&      �� 5'   
   -   5        $ ResultStackPanel��5'      $y�	Collapsed=�6/   .+�5(      �� -   5        $ GradeTextBlock��5(        TextBlockBased#��[ 60   �� 5)      -   5        $ RestartButton��5)      $(��"Пройти тест заново��6,   #��[ 6I   6p   5*      5+      5,      