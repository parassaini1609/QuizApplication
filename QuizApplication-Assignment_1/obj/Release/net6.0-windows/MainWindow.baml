   M S B A M L   `   `   `  ���� W  SQuizApplication-Assignment_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:QuizApplication_Assignment_1QuizApplication_Assignment_1  -    'QuizApplication_Assignment_1.MainWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     <local*clr-namespace:QuizApplication_Assignment_1       � Title$  
MainWindow��$	��600��$
��1000��.���� ����  �� ImageSource$ /welcomeScreen.jpg��.+��� -   $��Push to Start�� �� Left$	 426��
 �� Top$	 363��$��47��$	��148��$��Center=�$	��Top=�$��20(�$��Yu Gothic UI)�$
��Bold"����	#FF595959
��������� -    ��Name$ quizImg��$	��600��$
��1000��$��/quizBg.jpg��$��Center=�$��Center=�$
��Fill=�$y�Hidden=��� -    ��Name$ questionBox��$	 116��$ 84��$	��154��$	��748��$��Center=�$��Center=�
�������$��Gill Sans MT)�$��18(� �� Padding$ 20,10,20,10q� � UseLayoutRounding$ False��$��Disabled=�$	��154��$	��748��$	��748��$	��154��$y�Hidden=�$
��Wrap=�����  �� Color$ 	#FF615F5F��	 �� Opacity$		 0.7Q��� -   
 ��Name$
 nextBnt��$	 860��$	 461��$��80��$��80��$
��Left=�$��Center=�
���   �$y�Hidden=���Z� .���� $��80��$��80��$��/navigation.jpg��$
��Left=�$��Center=��� -   $
 prevBtn��$ 45��$	 461��$��80��$��80��$	��Top=�$��Disabled=�$
��Left=�$	��Top=�$y�Hidden=����� $ 	#FF707070��$	 0Q����� $ 	#FFDDDDDD��$	 0Q�.���� $��80��$��80��$��	/next.jpg�� J� RenderTransformOrigin$ 0.5,0.5&�$
��Left=�$	��Top=�z�V� .~��� �� ��  �� Angle$
 -180Q�T� � $	��181��$	 148��$	 320��$	��707��.+��� -   $
 optA��$
��Left=�$��37��$��	30,30,0,0q�$	��Top=�$	��195�����	#FF907C43
�������$��14(�$
��Wrap=�$ 5,2,5,2q�$
��True�� �� TextAlignment$ Center=�$y�Hidden=��� -   $
 optB��$��37��$	��195�����	#FF907C43
�������$��14(�$
��Wrap=�$ 5,2,5,2q�$
��True��$
��Left=�$��Bottom=�$��	30,0,0,30q�$ Center=�$y�Hidden=��� -   $
 optC��$��37�����	#FF907C43
�������$��14(�$
��Wrap=�$ 5,2,5,2q�$
��True��$	��Top=�$��	0,30,30,0q�$��Right=�$	��195��$ Center=�$y�Hidden=��� -	   $
 optD�����	#FF907C43
�������$��14(�$
��Wrap=�$ 5,2,5,2q�$
��True��$��	0,0,30,30q�$��Right=�$	��195��$��37��$��Bottom=�$ Center=�$y�Hidden=�	� -
    	�Name$
 btnA��$�� ��$
��Left=�$��	30,30,0,0q�$	��Top=�$��37��$	��195��$y�Hidden=�	� -   $
 btnC��$�� ��$
��Left=�$��
482,30,0,0q�$	��Top=�$��37��$	��195��$y�Hidden=�	� -   $
 btnB��$�� ��$
��Left=�$��
30,114,0,0q�$	��Top=�$��37��$	��195��$y�Hidden=�	� -   $
 btnD��$�� ��$
��Left=�$��482,114,0,0q�$	��Top=�$��37��$	��195��$y�Hidden=��� -    ��Name$ 	optionBox��$��Center=�$	��161��$�� ��$��Center=�$	��687��$��Disabled=�$y�Hidden=��� -   $ scoreCounter��$
��Wrap=�$��47��$	 886��$ 40��$	��104��$��20(�$
��Bold"�$ Center=�$��Gill Sans MT)�$y�Hidden=����� $ 	#FF726F6F��$		 0.7Q���  � Language$ en-in��� -    ��Name$ scoreTxt��$��Score��$	 909��$ 10��$��44��$��81��$��Gill Sans MT)�$��20(�$y�Hidden=��� -   $
 finishButton��$��Submit Quiz��$	 426��$	 477��$��47��$	��148��$��20(�$��Yu Gothic UI)�$
��Bold"����	#FF595959
�������$��Center=�$	��Top=�$y�Hidden=�