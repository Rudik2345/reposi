﻿#pragma checksum "..\..\..\ViewAllOrdersWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27B906AC4C33A82B51EDBE79A08E193F30F7D620"
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
    /// ViewAllOrdersWindow
    /// </summary>
    public partial class ViewAllOrdersWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\..\ViewAllOrdersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbx_search_orders;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\ViewAllOrdersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbx_status;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\ViewAllOrdersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_change_status;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\ViewAllOrdersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridOrders;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\ViewAllOrdersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbx_search_performance;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\ViewAllOrdersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datepicker1;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\ViewAllOrdersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datepicker2;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\ViewAllOrdersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridPerformance;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\..\ViewAllOrdersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Excel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ApplicationRepairPhoneEntityFramework;component/viewallorderswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ViewAllOrdersWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txbx_search_orders = ((System.Windows.Controls.TextBox)(target));
            
            #line 39 "..\..\..\ViewAllOrdersWindow.xaml"
            this.txbx_search_orders.SelectionChanged += new System.Windows.RoutedEventHandler(this.txbx_search_orders_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cmbx_status = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.btn_change_status = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\ViewAllOrdersWindow.xaml"
            this.btn_change_status.Click += new System.Windows.RoutedEventHandler(this.btn_change_status_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DataGridOrders = ((System.Windows.Controls.DataGrid)(target));
            
            #line 47 "..\..\..\ViewAllOrdersWindow.xaml"
            this.DataGridOrders.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGridOrders_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txbx_search_performance = ((System.Windows.Controls.TextBox)(target));
            
            #line 104 "..\..\..\ViewAllOrdersWindow.xaml"
            this.txbx_search_performance.SelectionChanged += new System.Windows.RoutedEventHandler(this.txbx_search_performance_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.datepicker1 = ((System.Windows.Controls.DatePicker)(target));
            
            #line 106 "..\..\..\ViewAllOrdersWindow.xaml"
            this.datepicker1.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.datepicker1_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.datepicker2 = ((System.Windows.Controls.DatePicker)(target));
            
            #line 108 "..\..\..\ViewAllOrdersWindow.xaml"
            this.datepicker2.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.datepicker2_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 109 "..\..\..\ViewAllOrdersWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 9:
            this.DataGridPerformance = ((System.Windows.Controls.DataGrid)(target));
            
            #line 116 "..\..\..\ViewAllOrdersWindow.xaml"
            this.DataGridPerformance.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGridPerformance_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btn_Excel = ((System.Windows.Controls.Button)(target));
            
            #line 142 "..\..\..\ViewAllOrdersWindow.xaml"
            this.btn_Excel.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

