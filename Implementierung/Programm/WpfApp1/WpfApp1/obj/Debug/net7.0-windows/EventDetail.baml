   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.EventDetail   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  EventDetail��5   	   $	��300��6   $	��500��6*   ���#f0f0f0 � SizeToContent$ Height=�6K   .��5	      � $��20q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6    �� CornerRadius$ 10��6   
������� �� Padding$ 10q�6C   ���#007ACC$��1q�6f   ._�5      �� .+�5      �� -   5         ��Name$ 	LabelName��5      $
��Bold"�6/   $��18(�6A   $��5q�6O   �� 5      -   5        $ 	LabelDate��5      $
��Bold"�6/   $��5q�6A   �� 5      -   5        $ LabelDescription��5      $
��Wrap=�66   $��5q�6J   �� 5      $��Zugewiesene Teilnehmer:��6   $
��Bold"�6;   $��5q�6M   5      5      �� 5   
   $��1��6   $ 10��6   ���#007ACC$��2q�6F   
�������._�5      �� -   5         ��Name$ ParticipantList��5      $��5q�5        �� DisplayMemberPath$
 Name��5!      $	��100��5"       �� SelectionMode$ Single=�5#      5$      �� 5'   
   $��2��6   	 �� Orientation$	 
Horizontal=�6"   $��Right=�6;   $��5q�6W   .+�5(      �� -   5        $��Teilnehmer entfernen��5(      
���  ��
�������$��0, 0, 10, 0q�5,      $
��Bold"�5-      $��10q�5.      �� 5/      -   5        $��Event löschen��5/      $��10q�6-   
���  ��
�������$
��Bold"�50   9   51      �� 52      -   5        $��
Schließen��52      $��10q�6)   $��10,0,0,0q�66   ���#007ACC
�������$
��Bold"�53   =   54      55      56      57      