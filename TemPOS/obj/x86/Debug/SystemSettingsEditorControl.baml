   M S B A M L   `   `   `  ����T  PTemPOS, Version=1.0.4709.35932, Culture=neutral, PublicKeyToken=b60a724858027fa2)clr-namespace:PointOfSalePointOfSale  5   =  R NPosControls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=b60a724858027fa2>.clr-namespace:PosControls;assembly=PosControlsPosControls 6b  5clr-namespace:PointOfSale.TypesPointOfSale.Types  6�  -    'PointOfSale.SystemSettingsEditorControl   6   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     6@   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     6�   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6�   @d2http://schemas.microsoft.com/expression/blend/2008     6   (myclr-namespace:PointOfSale     6=  ?ctrl.clr-namespace:PosControls;assembly=PosControls     6b  -tclr-namespace:PointOfSale.Types     6�  .��5      ]� -   5        $��mainPane��5   #   ��. .+�5      &   PosControls.ConfigurationManager  -   5           Name$  Configuration��5       � 5       � ColumnDefinitions 5      �� 5   
   $
��124* �6   �� 5   
   $
��296* �6    � RowDefinitions 5	      �� 5
   
   -   5         �Name$
 row1��5
      $	��40* �6$   �� 5   
   -   5        $
 row2��5      $	��40* �6$   �� 5   
   $	��40* �6   �� 5   
   $	��40* �6   �� 5   
   $	��40* �6   �� 5   
   $	��40* �6   �� 5   
   $��45 �6   ��5      �� 5   
    �� ElementName$ Configuration��6    �� Path$$ BindableControlBackgroundBrush�6.   .+�5      ��    PointOfSale.Types.Strings   CompanyName#��Z 6   $��Center=�69   �� 5         SerialNumber#��Z 6   $��Center=�6:   $��1��6U   �� 5         DatabaseServer#��Z 6   $��Center=�6<   $��2��6W   �� 5      	   DatabaseLogin#��Z	 6   $��Center=�6;   $��3��6V   �� 5      
   DatabasePassword#��Z
 6   $��Center=�6>   $��4��6Y   �� 5         DatabaseName#��Z 6   $��Center=�6:   $��5��6U     PosControls.CustomTextBox  5      -   5          Name$ textBoxCompanyName��5   +   $��1��6      UseContextMenuEditing .    
PromptType$ Keyboard=�6d   $��5q�6z      KeyboardTitleText$ Company Name��6�     5      -   5        $ textBoxSerialNumber��5   8   $��1��6   $��1��6(   $��5q�6U   $ TemPOS Serial Number��6`     5      -   5        $ textBoxDBServer��5   8   $��2��6   $��1��6(    . $ Keyboard=�6n   $��5q�6�   $ Database Server Name��6�     5      -   5        $ textBoxDBLogin��5   8   $��3��6   $��1��6(    . $ Keyboard=�6m   $��5q�6�   $ Database Login��6�      TextMaskCharacter$ *X�6�     5      -	   5        $ textBoxDBPassword��5   8   $��4��6   $��1��6(    . $ Keyboard=�6p   $��5q�6�   $ Database Password��6�   $ *X�6�     5       -
   5        $ textBoxDBInitialCatalog��5    8   $��5��6   $��1��6(    . $ Keyboard=�6v   $��5q�6�   $ Database Name��6�   �� 5!       �� Orientation$ 
Horizontal=�6   $��6��6,   $��Center=�69   $��2��6V   .+�5"   
   !  PosControls.TextBlockButton  -   5          Name$ buttonUpdate��5"         Update   Text# Z 65   $��60��6X   $��5q�6c   6n     5#   
   -   5        $ 
buttonExit��5#         Exit# Z 63   $��60��6T   $��5q�6_   6j   5$   	   5%      5&      5'      