﻿#pragma checksum "..\..\..\DirectorMenuWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9DF0FE5BEC8DD8B778026A36389100D24A52CFE4"
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
    /// DirectorMenuWindow
    /// </summary>
    public partial class DirectorMenuWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 62 "..\..\..\DirectorMenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lb_fio;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\DirectorMenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lb_position;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\DirectorMenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_clients;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\DirectorMenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_devices;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\DirectorMenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_employees;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\DirectorMenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_details;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\DirectorMenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_orders;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\DirectorMenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_AddOrders;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\DirectorMenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_AddPerforms;
        
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
            System.Uri resourceLocater = new System.Uri("/ApplicationRepairPhoneEntityFramework;component/directormenuwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\DirectorMenuWindow.xaml"
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
            
            #line 8 "..\..\..\DirectorMenuWindow.xaml"
            ((ApplicationRepairPhoneEntityFramework.DirectorMenuWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lb_fio = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lb_position = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.btn_clients = ((System.Windows.Controls.Button)(target));
            
            #line 71 "..\..\..\DirectorMenuWindow.xaml"
            this.btn_clients.Click += new System.Windows.RoutedEventHandler(this.btn_clients_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_devices = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\DirectorMenuWindow.xaml"
            this.btn_devices.Click += new System.Windows.RoutedEventHandler(this.btn_devices_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_employees = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\..\DirectorMenuWindow.xaml"
            this.btn_employees.Click += new System.Windows.RoutedEventHandler(this.btn_employees_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_details = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\..\DirectorMenuWindow.xaml"
            this.btn_details.Click += new System.Windows.RoutedEventHandler(this.btn_details_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btn_orders = ((System.Windows.Controls.Button)(target));
            
            #line 91 "..\..\..\DirectorMenuWindow.xaml"
            this.btn_orders.Click += new System.Windows.RoutedEventHandler(this.btn_orders_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btn_AddOrders = ((System.Windows.Controls.Button)(target));
            
            #line 96 "..\..\..\DirectorMenuWindow.xaml"
            this.btn_AddOrders.Click += new System.Windows.RoutedEventHandler(this.btn_AddOrders_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btn_AddPerforms = ((System.Windows.Controls.Button)(target));
            
            #line 101 "..\..\..\DirectorMenuWindow.xaml"
            this.btn_AddPerforms.Click += new System.Windows.RoutedEventHandler(this.btn_AddPerforms_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

