﻿#pragma checksum "..\..\..\Admin.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2EAEFAAD9998EFC834F91BB5CFC253B0AA06A045"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NguyenNgocNghiaWPF;
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


namespace NguyenNgocNghiaWPF {
    
    
    /// <summary>
    /// Admin
    /// </summary>
    public partial class Admin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CustomerSearchBox;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid customerDataGrid;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RoomSearchBox;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid roomDataGrid;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BookingSearchBox;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid bookingDataGrid;
        
        #line default
        #line hidden
        
        
        #line 167 "..\..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker StartDatePicker;
        
        #line default
        #line hidden
        
        
        #line 171 "..\..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker EndDatePicker;
        
        #line default
        #line hidden
        
        
        #line 174 "..\..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid reportDataGrid;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/NguyenNgocNghiaWPF;component/admin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Admin.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.CustomerSearchBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 40 "..\..\..\Admin.xaml"
            this.CustomerSearchBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.CustomerSearchBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.customerDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 48 "..\..\..\Admin.xaml"
            this.customerDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CustomerDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 60 "..\..\..\Admin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddCustomer_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 61 "..\..\..\Admin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditCustomer_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 62 "..\..\..\Admin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteCustomer_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.RoomSearchBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 87 "..\..\..\Admin.xaml"
            this.RoomSearchBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.RoomSearchBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.roomDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 95 "..\..\..\Admin.xaml"
            this.roomDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.RoomDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 107 "..\..\..\Admin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddRoom_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 108 "..\..\..\Admin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditRoom_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 109 "..\..\..\Admin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteRoom_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.BookingSearchBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 135 "..\..\..\Admin.xaml"
            this.BookingSearchBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.BookingSearchBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.bookingDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 143 "..\..\..\Admin.xaml"
            this.bookingDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.BookingDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 154 "..\..\..\Admin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddBooking_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 155 "..\..\..\Admin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditBooking_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 156 "..\..\..\Admin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteBooking_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.StartDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 17:
            this.EndDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 18:
            
            #line 173 "..\..\..\Admin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GenerateReport_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            this.reportDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

