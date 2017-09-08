﻿#pragma checksum "..\..\..\OrderEntrySetupControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "54C1B8072A83BDD0A3B99CF9AF3EC7A9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
    /// OrderEntrySetupControl
    /// </summary>
    public partial class OrderEntrySetupControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\OrderEntrySetupControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel mainPane;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\OrderEntrySetupControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.ConfigurationManager Configuration;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\OrderEntrySetupControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonGeneralSettings;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\OrderEntrySetupControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonItems;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\OrderEntrySetupControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonCoupons;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\OrderEntrySetupControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.TextBlockButton buttonSeating;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\OrderEntrySetupControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonEmployees;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\OrderEntrySetupControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonTaxes;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\OrderEntrySetupControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonHardware;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TemPOS;component/orderentrysetupcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\OrderEntrySetupControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
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
            this.buttonGeneralSettings = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\OrderEntrySetupControl.xaml"
            this.buttonGeneralSettings.Click += new System.Windows.RoutedEventHandler(this.buttonGeneralSettings_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.buttonItems = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\OrderEntrySetupControl.xaml"
            this.buttonItems.Click += new System.Windows.RoutedEventHandler(this.buttonItems_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.buttonCoupons = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\OrderEntrySetupControl.xaml"
            this.buttonCoupons.Click += new System.Windows.RoutedEventHandler(this.buttonCoupons_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.buttonSeating = ((PosControls.TextBlockButton)(target));
            
            #line 22 "..\..\..\OrderEntrySetupControl.xaml"
            this.buttonSeating.Click += new System.Windows.RoutedEventHandler(this.buttonSeating_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.buttonEmployees = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\OrderEntrySetupControl.xaml"
            this.buttonEmployees.Click += new System.Windows.RoutedEventHandler(this.buttonEmployees_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.buttonTaxes = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\OrderEntrySetupControl.xaml"
            this.buttonTaxes.Click += new System.Windows.RoutedEventHandler(this.buttonTaxes_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.buttonHardware = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\OrderEntrySetupControl.xaml"
            this.buttonHardware.Click += new System.Windows.RoutedEventHandler(this.buttonHardware_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

