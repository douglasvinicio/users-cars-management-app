﻿#pragma checksum "..\..\CarsDialog.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BA99C5D337667BB61E05F5DB428A8AC350B02C023B9B1F1717D57770C3BEAC3F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using Users_Cars_Management_System;


namespace Users_Cars_Management_System {
    
    
    /// <summary>
    /// CarsDialog
    /// </summary>
    public partial class CarsDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\CarsDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvCars;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\CarsDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDone;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\CarsDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMakeModel;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\CarsDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddCar;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\CarsDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdateCar;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\CarsDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeleteCar;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\CarsDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblOwnerId;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\CarsDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblOwnerName;
        
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
            System.Uri resourceLocater = new System.Uri("/Users_Cars_Management_System;component/carsdialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CarsDialog.xaml"
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
            this.lvCars = ((System.Windows.Controls.ListView)(target));
            
            #line 10 "..\..\CarsDialog.xaml"
            this.lvCars.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lvCars_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnDone = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\CarsDialog.xaml"
            this.btnDone.Click += new System.Windows.RoutedEventHandler(this.btnDone_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtMakeModel = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btnAddCar = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\CarsDialog.xaml"
            this.btnAddCar.Click += new System.Windows.RoutedEventHandler(this.btnAddCar_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnUpdateCar = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\CarsDialog.xaml"
            this.btnUpdateCar.Click += new System.Windows.RoutedEventHandler(this.btnUpdateCar_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnDeleteCar = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\CarsDialog.xaml"
            this.btnDeleteCar.Click += new System.Windows.RoutedEventHandler(this.btnDeleteCar_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lblOwnerId = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.lblOwnerName = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

