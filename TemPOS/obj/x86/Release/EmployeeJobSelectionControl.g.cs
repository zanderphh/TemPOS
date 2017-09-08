﻿#pragma checksum "..\..\..\EmployeeJobSelectionControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D3A2FB2E11DEC78E489E4958313D2521"
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
    /// EmployeeJobSelectionControl
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class EmployeeJobSelectionControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\EmployeeJobSelectionControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel mainPane;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\EmployeeJobSelectionControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.ConfigurationManager Configuration;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\EmployeeJobSelectionControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.DragScrollListBox listBoxAllJobs;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\EmployeeJobSelectionControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.DragScrollListBox listBoxSelectedJobs;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\EmployeeJobSelectionControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.TextBlockButton buttonAdd;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\EmployeeJobSelectionControl.xaml"
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
            System.Uri resourceLocater = new System.Uri("/PointOfSale;component/employeejobselectioncontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\EmployeeJobSelectionControl.xaml"
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
            this.listBoxAllJobs = ((PosControls.DragScrollListBox)(target));
            
            #line 29 "..\..\..\EmployeeJobSelectionControl.xaml"
            this.listBoxAllJobs.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listBoxAllJobs_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.listBoxSelectedJobs = ((PosControls.DragScrollListBox)(target));
            
            #line 30 "..\..\..\EmployeeJobSelectionControl.xaml"
            this.listBoxSelectedJobs.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listBoxSelectedJobs_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.buttonAdd = ((PosControls.TextBlockButton)(target));
            
            #line 31 "..\..\..\EmployeeJobSelectionControl.xaml"
            this.buttonAdd.Click += new System.Windows.RoutedEventHandler(this.buttonAdd_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.buttonRemove = ((PosControls.TextBlockButton)(target));
            
            #line 32 "..\..\..\EmployeeJobSelectionControl.xaml"
            this.buttonRemove.Click += new System.Windows.RoutedEventHandler(this.buttonRemove_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

