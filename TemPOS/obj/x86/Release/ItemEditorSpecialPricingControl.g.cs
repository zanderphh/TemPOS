﻿#pragma checksum "..\..\..\ItemEditorSpecialPricingControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2F04C7806C0A1C186A87DBE487F8FA32"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PointOfSale;
using PosControls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace PointOfSale {
    
    
    /// <summary>
    /// ItemEditorSpecialPricingControl
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class ItemEditorSpecialPricingControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\ItemEditorSpecialPricingControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel mainPane;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\ItemEditorSpecialPricingControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.ConfigurationManager Configuration;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\ItemEditorSpecialPricingControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.DragScrollListBox listBox1;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\ItemEditorSpecialPricingControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushComboBox comboBoxDay;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\ItemEditorSpecialPricingControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.TimeEditControl timePickerStart;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\ItemEditorSpecialPricingControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.TimeEditControl timePickerEnd;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\ItemEditorSpecialPricingControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.CustomTextBox textBoxPrice;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\ItemEditorSpecialPricingControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.CustomTextBox textBoxDiscountMin;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\ItemEditorSpecialPricingControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.CustomTextBox textBoxDiscountMax;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\ItemEditorSpecialPricingControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.CustomTextBox textBoxDiscountPrice;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\ItemEditorSpecialPricingControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.TextBlockButton buttonAdd;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\ItemEditorSpecialPricingControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.TextBlockButton buttonRemove;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PointOfSale;component/itemeditorspecialpricingcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ItemEditorSpecialPricingControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.mainPane = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 2:
            this.Configuration = ((PosControls.ConfigurationManager)(target));
            return;
            case 3:
            this.listBox1 = ((PosControls.DragScrollListBox)(target));
            
            #line 39 "..\..\..\ItemEditorSpecialPricingControl.xaml"
            this.listBox1.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listBox1_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.comboBoxDay = ((PosControls.PushComboBox)(target));
            
            #line 40 "..\..\..\ItemEditorSpecialPricingControl.xaml"
            this.comboBoxDay.SelectedIndexChanged += new System.EventHandler(this.PushComboBox_SelectedIndexChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.timePickerStart = ((PosControls.TimeEditControl)(target));
            
            #line 41 "..\..\..\ItemEditorSpecialPricingControl.xaml"
            this.timePickerStart.TimeChanged += new System.EventHandler(this.timePickerStart_TimeChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.timePickerEnd = ((PosControls.TimeEditControl)(target));
            
            #line 42 "..\..\..\ItemEditorSpecialPricingControl.xaml"
            this.timePickerEnd.TimeChanged += new System.EventHandler(this.timePickerEnd_TimeChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.textBoxPrice = ((PosControls.CustomTextBox)(target));
            
            #line 43 "..\..\..\ItemEditorSpecialPricingControl.xaml"
            this.textBoxPrice.TextChanged += new System.Windows.RoutedEventHandler(this.textBoxPrice_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.textBoxDiscountMin = ((PosControls.CustomTextBox)(target));
            
            #line 44 "..\..\..\ItemEditorSpecialPricingControl.xaml"
            this.textBoxDiscountMin.TextChanged += new System.Windows.RoutedEventHandler(this.textBoxDiscountMin_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.textBoxDiscountMax = ((PosControls.CustomTextBox)(target));
            
            #line 45 "..\..\..\ItemEditorSpecialPricingControl.xaml"
            this.textBoxDiscountMax.TextChanged += new System.Windows.RoutedEventHandler(this.textBoxDiscountMax_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.textBoxDiscountPrice = ((PosControls.CustomTextBox)(target));
            
            #line 46 "..\..\..\ItemEditorSpecialPricingControl.xaml"
            this.textBoxDiscountPrice.TextChanged += new System.Windows.RoutedEventHandler(this.textBoxDiscountPrice_TextChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.buttonAdd = ((PosControls.TextBlockButton)(target));
            
            #line 49 "..\..\..\ItemEditorSpecialPricingControl.xaml"
            this.buttonAdd.Click += new System.Windows.RoutedEventHandler(this.buttonAdd_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.buttonRemove = ((PosControls.TextBlockButton)(target));
            
            #line 50 "..\..\..\ItemEditorSpecialPricingControl.xaml"
            this.buttonRemove.Click += new System.Windows.RoutedEventHandler(this.buttonRemove_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

