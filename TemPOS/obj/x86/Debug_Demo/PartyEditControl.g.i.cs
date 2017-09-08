﻿#pragma checksum "..\..\..\PartyEditControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "92973A6D09C0105A7A8A991F2CDA8742"
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
    /// PartyEditControl
    /// </summary>
    public partial class PartyEditControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 2 "..\..\..\PartyEditControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel mainPane;
        
        #line default
        #line hidden
        
        
        #line 3 "..\..\..\PartyEditControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.ConfigurationManager Configuration;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\PartyEditControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.CustomTextBox textBoxGuestName;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\PartyEditControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.DragScrollListBox listBoxGuests;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\PartyEditControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.CustomTextBox textBoxHostName;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\PartyEditControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.CustomTextBox textBoxPartySize;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\PartyEditControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.CustomTextBox textBoxNotes;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\PartyEditControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.TextBlockButton buttonAdd;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\PartyEditControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.TextBlockButton buttonDelete;
        
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
            System.Uri resourceLocater = new System.Uri("/TemPOS;component/partyeditcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PartyEditControl.xaml"
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
            this.textBoxGuestName = ((PosControls.CustomTextBox)(target));
            
            #line 29 "..\..\..\PartyEditControl.xaml"
            this.textBoxGuestName.TextChanged += new System.Windows.RoutedEventHandler(this.textBoxGuestName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.listBoxGuests = ((PosControls.DragScrollListBox)(target));
            
            #line 30 "..\..\..\PartyEditControl.xaml"
            this.listBoxGuests.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listBoxGuests_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.textBoxHostName = ((PosControls.CustomTextBox)(target));
            
            #line 37 "..\..\..\PartyEditControl.xaml"
            this.textBoxHostName.TextChanged += new System.Windows.RoutedEventHandler(this.textBoxHostName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.textBoxPartySize = ((PosControls.CustomTextBox)(target));
            
            #line 38 "..\..\..\PartyEditControl.xaml"
            this.textBoxPartySize.TextChanged += new System.Windows.RoutedEventHandler(this.textBoxPartySize_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.textBoxNotes = ((PosControls.CustomTextBox)(target));
            
            #line 39 "..\..\..\PartyEditControl.xaml"
            this.textBoxNotes.TextChanged += new System.Windows.RoutedEventHandler(this.textBoxNotes_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.buttonAdd = ((PosControls.TextBlockButton)(target));
            
            #line 41 "..\..\..\PartyEditControl.xaml"
            this.buttonAdd.Click += new System.Windows.RoutedEventHandler(this.buttonAdd_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.buttonDelete = ((PosControls.TextBlockButton)(target));
            
            #line 42 "..\..\..\PartyEditControl.xaml"
            this.buttonDelete.Click += new System.Windows.RoutedEventHandler(this.buttonDelete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

