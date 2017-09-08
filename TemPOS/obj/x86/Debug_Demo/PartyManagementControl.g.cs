﻿#pragma checksum "..\..\..\PartyManagementControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DD6E20D016CAEA50F276D88FFAF1B29C"
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
    /// PartyManagementControl
    /// </summary>
    public partial class PartyManagementControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 2 "..\..\..\PartyManagementControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel mainPane;
        
        #line default
        #line hidden
        
        
        #line 3 "..\..\..\PartyManagementControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.ConfigurationManager Configuration;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\PartyManagementControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.DragScrollListBox listboxSourceTicket;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\PartyManagementControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.DragScrollListBox receiptTape;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\PartyManagementControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.DragScrollListBox listBoxDestinationTicket;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\PartyManagementControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.TextBlockButton buttonAddTicket;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\PartyManagementControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.TextBlockButton buttonRemoveTicket;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\PartyManagementControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.TextBlockButton buttonChangeSeating;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\PartyManagementControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.TextBlockButton buttonEditParty;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\PartyManagementControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.TextBlockButton buttonSelectAll;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\PartyManagementControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.TextBlockButton buttonUnselect;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\PartyManagementControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.TextBlockButton buttonSingleTicket;
        
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
            System.Uri resourceLocater = new System.Uri("/TemPOS;component/partymanagementcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PartyManagementControl.xaml"
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
            this.listboxSourceTicket = ((PosControls.DragScrollListBox)(target));
            
            #line 24 "..\..\..\PartyManagementControl.xaml"
            this.listboxSourceTicket.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listboxSourceTicket_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.receiptTape = ((PosControls.DragScrollListBox)(target));
            
            #line 25 "..\..\..\PartyManagementControl.xaml"
            this.receiptTape.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.receiptTape_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.listBoxDestinationTicket = ((PosControls.DragScrollListBox)(target));
            
            #line 26 "..\..\..\PartyManagementControl.xaml"
            this.listBoxDestinationTicket.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listBoxDestinationTicket_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.buttonAddTicket = ((PosControls.TextBlockButton)(target));
            
            #line 28 "..\..\..\PartyManagementControl.xaml"
            this.buttonAddTicket.Click += new System.Windows.RoutedEventHandler(this.buttonAddTicket_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.buttonRemoveTicket = ((PosControls.TextBlockButton)(target));
            
            #line 29 "..\..\..\PartyManagementControl.xaml"
            this.buttonRemoveTicket.Click += new System.Windows.RoutedEventHandler(this.buttonRemoveTicket_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.buttonChangeSeating = ((PosControls.TextBlockButton)(target));
            
            #line 30 "..\..\..\PartyManagementControl.xaml"
            this.buttonChangeSeating.Click += new System.Windows.RoutedEventHandler(this.buttonChangeSeating_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.buttonEditParty = ((PosControls.TextBlockButton)(target));
            
            #line 33 "..\..\..\PartyManagementControl.xaml"
            this.buttonEditParty.Click += new System.Windows.RoutedEventHandler(this.buttonEditParty_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.buttonSelectAll = ((PosControls.TextBlockButton)(target));
            
            #line 35 "..\..\..\PartyManagementControl.xaml"
            this.buttonSelectAll.Click += new System.Windows.RoutedEventHandler(this.buttonSelectAll_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.buttonUnselect = ((PosControls.TextBlockButton)(target));
            
            #line 36 "..\..\..\PartyManagementControl.xaml"
            this.buttonUnselect.Click += new System.Windows.RoutedEventHandler(this.buttonUnselect_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.buttonSingleTicket = ((PosControls.TextBlockButton)(target));
            
            #line 40 "..\..\..\PartyManagementControl.xaml"
            this.buttonSingleTicket.Click += new System.Windows.RoutedEventHandler(this.buttonSingleTicket_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

