   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��500��6   $	��700��6)   ���#f0f0f0.��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6    �� CornerRadius$ 10��6   
������� �� Padding$ 10q�6C   $��20q�6P   ���#007ACC$��1q�6r   ._�5      �� .+�5      �� $.��(Willkommen im Schwimmbad Eventmanagement��6   $
��Bold"�5      $��18(�5      $��5q�5      $��Center=�5      �� 5      $K��EHier können Sie Events verwalten, einsehen oder neue Events anlegen.��6   $��5q�5      $
��Wrap=�5      $��Center=�5      �� 5      -   5        $��Events anzeigen��5      $��5q�63   $��10q�6>   ���#007ACC
�������$
��Bold"�5   A   5      �� 5!      -   5        $��Neues Event anlegen��5!      $��5q�67   $��10q�6B   ���#007ACC
�������$
��Bold"�5"   A   5#      �� 5$      -   5        $��Teilnehmer verwalten��5$      $��5q�68   $��10q�6C   ���#007ACC
�������$
��Bold"�5%   A   5&      �� 5'      -   5        $"��Teilnehmer zu Event zuweisen��5'      $��5q�6@   $��10q�6K   ���#007ACC
�������$
��Bold"�6�   5(      5*      5+      �� 5,   
   $��1��6   $ 10��6   
�������$ 10q�6C   $��20q�6P   ���#007ACC$��1q�6r   ._�5-      �� -   5         ��Name$ 
StatsPanel��5-      .+�5.      �� $��Teilnehmer-Statistik��6   $
��Bold"�5/      $��16(�50      $��5q�51      $��Center=�52      54      55      57      58      