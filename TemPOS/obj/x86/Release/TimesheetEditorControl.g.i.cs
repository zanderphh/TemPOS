﻿#pragma checksum "..\..\..\TimesheetEditorControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E74A2875113674DF544A997120A86714"
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
    /// TimesheetEditorControl
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class TimesheetEditorControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\TimesheetEditorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel mainPane;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\TimesheetEditorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.ConfigurationManager Configuration;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\TimesheetEditorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.DragScrollListBox listBoxJobs;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\TimesheetEditorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.DateTimeEditControl dateTimeEditStartTime;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\TimesheetEditorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.DateTimeEditControl dateTimeEditEndTime;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\TimesheetEditorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.TextBlockButton buttonTips;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\TimesheetEditorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.TextBlockButton buttonDriverComp;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\TimesheetEditorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.TextBlockButton buttonDelete;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\TimesheetEditorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.TextBlockButton buttonSave;
        
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
            System.Uri resourceLocater = new System.Uri("/PointOfSale;component/timesheeteditorcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\TimesheetEditorControl.xaml"
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
            
            #line 12 "..\..\..\TimesheetEditorControl.xaml"
            ((System.Windows.Controls.Grid)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Grid_Loaded);
            
            #line default
            #line hidden
            return;
            case 4:
            this.listBoxJobs = ((PosControls.DragScrollListBox)(target));
            
            #line 37 "..\..\..\TimesheetEditorControl.xaml"
            this.listBoxJobs.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listBoxJobs_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dateTimeEditStartTime = ((PosControls.DateTimeEditControl)(target));
            
            #line 38 "..\..\..\TimesheetEditorControl.xaml"
            this.dateTimeEditStartTime.SelectedDateTimeChanged += new System.EventHandler(this.dateTimeEditStartTime_SelectedDateTimeChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.dateTimeEditEndTime = ((PosControls.DateTimeEditControl)(target));
            
            #line 39 "..\..\..\TimesheetEditorControl.xaml"
            this.dateTimeEditEndTime.SelectedDateTimeChanged += new System.EventHandler(this.dateTimeEditEndTime_SelectedDateTimeChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.buttonTips = ((PosControls.TextBlockButton)(target));
            
            #line 40 "..\..\..\TimesheetEditorControl.xaml"
            this.buttonTips.Click += new System.Windows.RoutedEventHandler(this.buttonTips_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.buttonDriverComp = ((PosControls.TextBlockButton)(target));
            
            #line 41 "..\..\..\TimesheetEditorControl.xaml"
            this.buttonDriverComp.Click += new System.Windows.RoutedEventHandler(this.buttonDriverComp_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.buttonDelete = ((PosControls.TextBlockButton)(target));
            
            #line 42 "..\..\..\TimesheetEditorControl.xaml"
            this.buttonDelete.Click += new System.Windows.RoutedEventHandler(this.buttonDelete_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.buttonSave = ((PosControls.TextBlockButton)(target));
            
            #line 43 "..\..\..\TimesheetEditorControl.xaml"
            this.buttonSave.Click += new System.Windows.RoutedEventHandler(this.buttonSave_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

