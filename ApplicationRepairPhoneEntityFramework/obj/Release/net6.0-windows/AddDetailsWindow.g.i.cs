﻿#pragma checksum "..\..\..\AddDetailsWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8697E89A549BE2B453B2657B64A12FB92E73330B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ApplicationRepairPhoneEntityFramework;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace ApplicationRepairPhoneEntityFramework {
    
    
    /// <summary>
    /// AddDetailsWindow
    /// </summary>
    public partial class AddDetailsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\..\AddDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbx_ID_Detail;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\AddDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbx_Name_Detail;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\AddDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lb_Name;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\AddDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbx_Unit_Price;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\AddDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lb_UnitPrice;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\AddDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbx_Quantity;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\AddDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lb_Quantity;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\AddDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbx_FullPrice;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\AddDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lb_FullPrice;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\AddDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Add_Details;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ApplicationRepairPhoneEntityFramework;component/adddetailswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddDetailsWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txbx_ID_Detail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txbx_Name_Detail = ((System.Windows.Controls.TextBox)(target));
            
            #line 44 "..\..\..\AddDetailsWindow.xaml"
            this.txbx_Name_Detail.SelectionChanged += new System.Windows.RoutedEventHandler(this.txbx_Name_Detail_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lb_Name = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.txbx_Unit_Price = ((System.Windows.Controls.TextBox)(target));
            
            #line 49 "..\..\..\AddDetailsWindow.xaml"
            this.txbx_Unit_Price.SelectionChanged += new System.Windows.RoutedEventHandler(this.txbx_Unit_Price_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lb_UnitPrice = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.txbx_Quantity = ((System.Windows.Controls.TextBox)(target));
            
            #line 54 "..\..\..\AddDetailsWindow.xaml"
            this.txbx_Quantity.SelectionChanged += new System.Windows.RoutedEventHandler(this.txbx_Quantity_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lb_Quantity = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.txbx_FullPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.lb_FullPrice = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.btn_Add_Details = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\AddDetailsWindow.xaml"
            this.btn_Add_Details.Click += new System.Windows.RoutedEventHandler(this.btn_Add_Details_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

