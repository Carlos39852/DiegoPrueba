﻿#pragma checksum "..\..\..\..\Views\AggProducto.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BB6DC169A611C88FD167602CDD06A65420DE5475"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Login.Views;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace Login.Views {
    
    
    /// <summary>
    /// AggProducto
    /// </summary>
    public partial class AggProducto : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\..\Views\AggProducto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtStockActual;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Views\AggProducto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtStockMinimo;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Views\AggProducto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datePickerFechaCaducidad;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Views\AggProducto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCategoria;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Views\AggProducto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDescripcionCategoria;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\Views\AggProducto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBoxProveedor;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\Views\AggProducto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBoxProductoProveedor;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\Views\AggProducto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGuardar;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\Views\AggProducto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button brtnCancelar;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.7.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Login;component/views/aggproducto.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\AggProducto.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.7.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtStockActual = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtStockMinimo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.datePickerFechaCaducidad = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.txtCategoria = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtDescripcionCategoria = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.comboBoxProveedor = ((System.Windows.Controls.ComboBox)(target));
            
            #line 55 "..\..\..\..\Views\AggProducto.xaml"
            this.comboBoxProveedor.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboBoxProveedor_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.comboBoxProductoProveedor = ((System.Windows.Controls.ComboBox)(target));
            
            #line 62 "..\..\..\..\Views\AggProducto.xaml"
            this.comboBoxProductoProveedor.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboBoxProductoProveedor_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnGuardar = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\..\Views\AggProducto.xaml"
            this.btnGuardar.Click += new System.Windows.RoutedEventHandler(this.GuardarProducto_click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.brtnCancelar = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\..\Views\AggProducto.xaml"
            this.brtnCancelar.Click += new System.Windows.RoutedEventHandler(this.Cancelar_click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

