﻿#pragma checksum "..\..\..\CouponCategorySelectionControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BA921A3171431D62AF2128A6FA1691F7"
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
    /// CouponCategorySelectionControl
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class CouponCategorySelectionControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\CouponCategorySelectionControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel mainPane;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\CouponCategorySelectionControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.ConfigurationManager Configuration;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\CouponCategorySelectionControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.DragScrollListBox listBoxAllCategories;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\CouponCategorySelectionControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.DragScrollListBox listBoxSelectedCategories;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\CouponCategorySelectionControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.TextBlockButton buttonAdd;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\CouponCategorySelectionControl.xaml"
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
            System.Uri resourceLocater = new System.Uri("/PointOfSale;component/couponcategoryselectioncontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CouponCategorySelectionControl.xaml"
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
            this.listBoxAllCategories = ((PosControls.DragScrollListBox)(target));
            
            #line 29 "..\..\..\CouponCategorySelectionControl.xaml"
            this.listBoxAllCategories.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listBoxAllCategories_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.listBoxSelectedCategories = ((PosControls.DragScrollListBox)(target));
            
            #line 30 "..\..\..\CouponCategorySelectionControl.xaml"
            this.listBoxSelectedCategories.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listBoxSelectedCategories_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.buttonAdd = ((PosControls.TextBlockButton)(target));
            
            #line 32 "..\..\..\CouponCategorySelectionControl.xaml"
            this.buttonAdd.Click += new System.Windows.RoutedEventHandler(this.buttonAdd_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.buttonRemove = ((PosControls.TextBlockButton)(target));
            
            #line 33 "..\..\..\CouponCategorySelectionControl.xaml"
            this.buttonRemove.Click += new System.Windows.RoutedEventHandler(this.buttonRemove_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

