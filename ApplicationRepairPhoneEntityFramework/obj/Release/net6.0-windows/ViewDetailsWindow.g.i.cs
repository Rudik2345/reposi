﻿#pragma checksum "..\..\..\ViewDetailsWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43DA4075F64D471BC556067BCE97E2F9BC337535"
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
    /// ViewDetailsWindow
    /// </summary>
    public partial class ViewDetailsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 81 "..\..\..\ViewDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbx_search_detail;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\ViewDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridDetails;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\ViewDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbx_Id_Detail;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\ViewDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbx_Name;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\ViewDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbx_UnitPrice;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\ViewDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbx_quantity;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\ViewDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbx_FullPrice;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\..\ViewDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Add_Detail;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\ViewDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Update_Detail;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\..\ViewDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Delete_Detail;
        
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
            System.Uri resourceLocater = new System.Uri("/ApplicationRepairPhoneEntityFramework;component/viewdetailswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ViewDetailsWindow.xaml"
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
            this.txbx_search_detail = ((System.Windows.Controls.TextBox)(target));
            
            #line 81 "..\..\..\ViewDetailsWindow.xaml"
            this.txbx_search_detail.SelectionChanged += new System.Windows.RoutedEventHandler(this.txbx_search_detail_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dataGridDetails = ((System.Windows.Controls.DataGrid)(target));
            
            #line 85 "..\..\..\ViewDetailsWindow.xaml"
            this.dataGridDetails.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dataGridDetails_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txbx_Id_Detail = ((System.Windows.Controls.TextBox)(target));
            
            #line 101 "..\..\..\ViewDetailsWindow.xaml"
            this.txbx_Id_Detail.SelectionChanged += new System.Windows.RoutedEventHandler(this.txbx_Id_Detail_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txbx_Name = ((System.Windows.Controls.TextBox)(target));
            
            #line 106 "..\..\..\ViewDetailsWindow.xaml"
            this.txbx_Name.SelectionChanged += new System.Windows.RoutedEventHandler(this.txbx_Name_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txbx_UnitPrice = ((System.Windows.Controls.TextBox)(target));
            
            #line 110 "..\..\..\ViewDetailsWindow.xaml"
            this.txbx_UnitPrice.SelectionChanged += new System.Windows.RoutedEventHandler(this.txbx_UnitPrice_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txbx_quantity = ((System.Windows.Controls.TextBox)(target));
            
            #line 114 "..\..\..\ViewDetailsWindow.xaml"
            this.txbx_quantity.SelectionChanged += new System.Windows.RoutedEventHandler(this.txbx_quantity_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txbx_FullPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.btn_Add_Detail = ((System.Windows.Controls.Button)(target));
            
            #line 122 "..\..\..\ViewDetailsWindow.xaml"
            this.btn_Add_Detail.Click += new System.Windows.RoutedEventHandler(this.btn_Add_Detail_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btn_Update_Detail = ((System.Windows.Controls.Button)(target));
            
            #line 125 "..\..\..\ViewDetailsWindow.xaml"
            this.btn_Update_Detail.Click += new System.Windows.RoutedEventHandler(this.btn_Update_Detail_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btn_Delete_Detail = ((System.Windows.Controls.Button)(target));
            
            #line 128 "..\..\..\ViewDetailsWindow.xaml"
            this.btn_Delete_Detail.Click += new System.Windows.RoutedEventHandler(this.btn_Delete_Detail_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
