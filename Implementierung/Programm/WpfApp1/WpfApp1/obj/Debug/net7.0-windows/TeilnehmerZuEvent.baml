   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.TeilnehmerZuEvent   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  TeilnehmerZuEvent��5   	   $	��300��6#   $	��450��60    � 
ResizeMode$ NoResize=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	   ���#F5F5F5.��5      � $��20q�6   .+�5   
   �� 
������� �� CornerRadius$ 10��6$    �� Padding$ 15q�66   ���#007ACC$��2q�6Y   ._�5      �� .+�5      �� $��Teilnehmer auswählen:��6   $��14(�69   $
��Bold"�6G   $��0,0,0,5q�6Y   �� 5      -   5         ��Name$ ComboBoxParticipant��5      $��30��68   $��0,0,0,15q�6D    �� DisplayMemberPath$
 Name��6V    �� SelectedValuePath$ TeilnehmerId��5      �� 5      $��Event auswählen:��6   $��14(�64   $
��Bold"�6B   $��0,0,0,5q�6T   �� 5      -   5        $ ComboBoxEvent��5      $��30��62   $��0,0,0,15q�6>   �� 5       �� Orientation$ 
Horizontal=�6   $��Right=�66   $��0,10,0,0q�6R   .+�5      �� -   5        $��Zuweisen��5      $	��120��60   $��35��6<   ���#007ACC
�������$
��Bold"�5      6/   �� 5      -   5        $��	Abbrechen��5      $	��120��61   $��35��6=   
�������
�������$
��Bold"�5      $��10,0,0,0q�6/   6A   5      5!      5"      5#      5$      