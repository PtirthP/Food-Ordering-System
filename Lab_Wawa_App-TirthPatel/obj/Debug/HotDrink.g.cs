﻿#pragma checksum "..\..\HotDrink.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C6D40A4860714D554CC01443049A99EB44FFEA1F690DDB857DA92522235C934A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Lab_Wawa_App_TirthPatel;
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


namespace Lab_Wawa_App_TirthPatel {
    
    
    /// <summary>
    /// HotDrink
    /// </summary>
    public partial class HotDrink : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\HotDrink.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblHeading;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\HotDrink.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgOrder;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\HotDrink.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblOrder;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\HotDrink.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPrevious;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\HotDrink.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image btnPrevious1;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\HotDrink.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCheckout;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\HotDrink.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnHotChocolate;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\HotDrink.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnHotCoffee;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\HotDrink.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtOrder;
        
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
            System.Uri resourceLocater = new System.Uri("/Lab_Wawa_App-TirthPatel;component/hotdrink.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\HotDrink.xaml"
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
            this.lblHeading = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.imgOrder = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.lblOrder = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.btnPrevious = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\HotDrink.xaml"
            this.btnPrevious.Click += new System.Windows.RoutedEventHandler(this.btnPrevious_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnPrevious1 = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.btnCheckout = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\HotDrink.xaml"
            this.btnCheckout.Click += new System.Windows.RoutedEventHandler(this.btnCheckout_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnHotChocolate = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\HotDrink.xaml"
            this.btnHotChocolate.Click += new System.Windows.RoutedEventHandler(this.btnHotChocolate_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnHotCoffee = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\HotDrink.xaml"
            this.btnHotCoffee.Click += new System.Windows.RoutedEventHandler(this.btnHotCoffee_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.txtOrder = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

