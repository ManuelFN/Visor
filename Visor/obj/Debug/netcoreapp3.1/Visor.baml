   M S B A M L   `   `   `  ����@  <Visor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VisorVisor  5   	       Visor.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Visor     5   	     � Title$#  Aplicación Cuentas Bancarias��5   	   $	��450��6.   $	��550��6;   .��5	      � .+�5
   
   �� -   5         ��Name$ label_etiExist��5
      $%��VISOR DE LAS CUENTAS EXISTENTES��6(   $��Center=�6R   $��0,22,0,0q�6o   $	��Top=�6�   $
��Bold"�6�   $��14(�6�   �� 5   
   $��Número:��6   $
��Left=�6"   $��	73,81,0,0q�6=   $	��Top=�6P   $��14(�6h   $��Roboto)�6v   ���	#FF5757576�   �� 5   
   $��Saldo:��6   $
��Left=�6!   $��
73,228,0,0q�6<   $	��Top=�6P   $��14(�6h   $��Roboto)�6v   ���	#FF5757576�   �� 5   
   $��Nacionalidad:��6   $
��Left=�6(   $��
73,277,0,0q�6C   $	��Top=�6W   $��14(�6o   $��Roboto)�6}   ���	#FF5757576�   �� 5   
   $��Fecha Apertura:��6   $
��Left=�6*   $��
73,177,0,0q�6E   $	��Top=�6Y   $��14(�6q   $��Roboto)�6   ���	#FF5757576�   �� 5   
   $��Titular:��6   $
��Left=�6#   $��
73,132,0,0q�6>   $	��Top=�6R   $��14(�6j   $��Roboto)�6x   ���	#FF5757576�   �� 5   
   -   5         ��Name$ 
txt_Numero��5      $
��Left=�6&   $��
217,81,0,0q�6A    �� TextWrapping$
 Wrap=�6U   $	��Top=�6i   $	��209��6�   $��27��6�    �� 
IsReadOnly$
 True��6�   �� 5   
   -   5        $ 
txt_Titulo��5      $
��Left=�6&   $��217,132,0,0q�6A   $
 Wrap=�6V   $	��Top=�6j   $	��209��6�   $��27��6�   $
 True��6�   �� 5   
   -   5        $ 	txt_Fecha��5      $
��Left=�6%   $��217,177,0,0q�6@   $
 Wrap=�6U   $	��Top=�6i   $	��209��6�   $��27��6�   $
 True��6�   �� 5   
   -   5        $ 	txt_Saldo��5      $
��Left=�6%   $��217,228,0,0q�6@   $
 Wrap=�6U   $	��Top=�6i   $	��209��6�   $��27��6�   $
 True��6�   �� 5   
   -   5        $ txt_Nacionalidad��5      $
��Left=�6,   $��217,278,0,0q�6G   $
 Wrap=�6\   $	��Top=�6p   $	��209��6�   $��27��6�   $
 True��6�   �� 5   
   -   5         ��Name$ btn_Siguiente��5      $��	Siguiente��6(   $
��Left=�6<   $��341,348,0,0q�6W   $	��Top=�6l   $��36��6�   $��85��6�   ���	#FF0099A2
�������6�   �� 5   
   -   5        $ 	btn_Atras��5      $��Atrás��6$   $
��Left=�64   $��132,348,0,0q�6O   $	��Top=�6d   $��36��6|   $��85��6�   ���	#FF0099A2
�������$y�Hidden=�6�   6�   �� 5   
   -	   5        $ 	btn_Nueva��5      $��Nueva��6$   $
��Left=�64   $��341,348,0,0q�6O   $	��Top=�6d   $��36��6|   $��85��6�   ���	#FF0099A2
�������$y�Hidden=�6�   6�   �� 5   
   -
   5        $ btn_Aceptar��5      $��Aceptar��6&   $
��Left=�68   $��341,348,0,0q�6S   $	��Top=�6h   $��36��6�   $��85��6�   ���	#FF0099A2
�������$y�Hidden=�6�   �� 5   
   -   5        $ btn_Cancelar��5      $��Cancelar��6'   $
��Left=�6:   $��132,348,0,0q�6U   $	��Top=�6j   $��36��6�   $��85��6�   ���	#FF0099A2
�������$y�Hidden=�6�   �� 5   
   -   5        $ label_etiNueva��5      $!��VISOR DE LAS CUENTAS NUEVAS��6(   $��Center=�6N   $��0,22,0,0q�6k   $	��Top=�6}   $
��Bold"�6�   $��14(�6�   $y�Hidden=�6�   ��5   
   �� 5       �� ImageSource$ imagenes/fondo.jpg��6    j� Stretch$ UniformToFill=�6:   5      5      