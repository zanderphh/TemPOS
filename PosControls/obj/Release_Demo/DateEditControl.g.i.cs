﻿#pragma checksum "..\..\DateEditControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "20075F1525C578CBF0AE5BAB5D9E113F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
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


namespace PosControls {
    
    
    /// <summary>
    /// DateEditControl
    /// </summary>
    public partial class DateEditControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\DateEditControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel mainPane;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\DateEditControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.ConfigurationManager Configuration;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\DateEditControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridPanel;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\DateEditControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxMonth;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\DateEditControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxDay;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\DateEditControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushComboBox comboBoxYear;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\DateEditControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel dockPanel;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\DateEditControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelDate;
        
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
            System.Uri resourceLocater = new System.Uri("/PosControls;component/dateeditcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DateEditControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.gridPanel = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.textBoxMonth = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\DateEditControl.xaml"
            this.textBoxMonth.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textBoxMonth_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.textBoxDay = ((System.Windows.Controls.TextBox)(target));
            
            #line 28 "..\..\DateEditControl.xaml"
            this.textBoxDay.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textBoxDay_TextChanged);
            
            #line default
            #line hidden
            
            #line 28 "..\..\DateEditControl.xaml"
            this.textBoxDay.KeyDown += new System.Windows.Input.KeyEventHandler(this.textBoxDay_KeyDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.comboBoxYear = ((PosControls.PushComboBox)(target));
            return;
            case 7:
            this.dockPanel = ((System.Windows.Controls.DockPanel)(target));
            
            #line 32 "..\..\DateEditControl.xaml"
            this.dockPanel.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.stackPanel_MouseDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.labelDate = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

