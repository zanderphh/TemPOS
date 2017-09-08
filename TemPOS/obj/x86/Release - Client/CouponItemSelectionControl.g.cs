﻿#pragma checksum "..\..\..\CouponItemSelectionControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A2CF6543CA59C6BF5F5FD2B8E411B4C1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
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
    /// CouponItemSelectionControl
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class CouponItemSelectionControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\CouponItemSelectionControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel mainPane;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\CouponItemSelectionControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PointOfSale.ConfigurationManager Configuration;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\CouponItemSelectionControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.DragScrollListBox listBoxAllItems;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\CouponItemSelectionControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.DragScrollListBox listBoxSelectedItems;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\CouponItemSelectionControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushButton buttonAdd;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\CouponItemSelectionControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushButton buttonRemove;
        
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
            System.Uri resourceLocater = new System.Uri("/PointOfSale;component/couponitemselectioncontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CouponItemSelectionControl.xaml"
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
            this.Configuration = ((PointOfSale.ConfigurationManager)(target));
            return;
            case 3:
            this.listBoxAllItems = ((PosControls.DragScrollListBox)(target));
            
            #line 44 "..\..\..\CouponItemSelectionControl.xaml"
            this.listBoxAllItems.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listBoxAllItems_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.listBoxSelectedItems = ((PosControls.DragScrollListBox)(target));
            
            #line 45 "..\..\..\CouponItemSelectionControl.xaml"
            this.listBoxSelectedItems.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listBoxSelectedItems_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.buttonAdd = ((PosControls.PushButton)(target));
            
            #line 47 "..\..\..\CouponItemSelectionControl.xaml"
            this.buttonAdd.Selected += new System.EventHandler(this.button_Selected);
            
            #line default
            #line hidden
            return;
            case 6:
            this.buttonRemove = ((PosControls.PushButton)(target));
            
            #line 48 "..\..\..\CouponItemSelectionControl.xaml"
            this.buttonRemove.Selected += new System.EventHandler(this.button_Selected);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

