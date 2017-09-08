﻿#pragma checksum "..\..\..\ItemOptionSetEditorControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9093EDFE09D249E2870E7EC9CA2509BC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PosControls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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
using TemPOS;
using TemPOS.Types;


namespace TemPOS {
    
    
    /// <summary>
    /// ItemOptionSetEditorControl
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class ItemOptionSetEditorControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\ItemOptionSetEditorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel mainPane;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\ItemOptionSetEditorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.ConfigurationManager Configuration;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\ItemOptionSetEditorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.CustomTextBox textBoxName;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\ItemOptionSetEditorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.CustomTextBox textBoxMin;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\ItemOptionSetEditorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.CustomTextBox textBoxFree;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\ItemOptionSetEditorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.CustomTextBox textBoxMax;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\ItemOptionSetEditorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.CustomTextBox textBoxExtraCost;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\ItemOptionSetEditorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushRadioButton radioButtonIsPizzaStyle;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\ItemOptionSetEditorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushRadioButton radioButtonIsNotPizzaStyle;
        
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
            System.Uri resourceLocater = new System.Uri("/TemPOS;component/itemoptionseteditorcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ItemOptionSetEditorControl.xaml"
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
            this.textBoxName = ((PosControls.CustomTextBox)(target));
            
            #line 42 "..\..\..\ItemOptionSetEditorControl.xaml"
            this.textBoxName.TextChanged += new System.Windows.RoutedEventHandler(this.textBoxName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.textBoxMin = ((PosControls.CustomTextBox)(target));
            
            #line 43 "..\..\..\ItemOptionSetEditorControl.xaml"
            this.textBoxMin.TextChanged += new System.Windows.RoutedEventHandler(this.textBoxMin_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.textBoxFree = ((PosControls.CustomTextBox)(target));
            
            #line 44 "..\..\..\ItemOptionSetEditorControl.xaml"
            this.textBoxFree.TextChanged += new System.Windows.RoutedEventHandler(this.textBoxFree_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.textBoxMax = ((PosControls.CustomTextBox)(target));
            
            #line 45 "..\..\..\ItemOptionSetEditorControl.xaml"
            this.textBoxMax.TextChanged += new System.Windows.RoutedEventHandler(this.textBoxMax_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.textBoxExtraCost = ((PosControls.CustomTextBox)(target));
            
            #line 46 "..\..\..\ItemOptionSetEditorControl.xaml"
            this.textBoxExtraCost.TextChanged += new System.Windows.RoutedEventHandler(this.textBoxExtraCost_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.radioButtonIsPizzaStyle = ((PosControls.PushRadioButton)(target));
            
            #line 49 "..\..\..\ItemOptionSetEditorControl.xaml"
            this.radioButtonIsPizzaStyle.SelectionGained += new System.EventHandler(this.radioButtonPizzaStyle_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.radioButtonIsNotPizzaStyle = ((PosControls.PushRadioButton)(target));
            
            #line 50 "..\..\..\ItemOptionSetEditorControl.xaml"
            this.radioButtonIsNotPizzaStyle.SelectionGained += new System.EventHandler(this.radioButtonPizzaStyle_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

