﻿#pragma checksum "..\..\..\MyPages\HotelsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0677752D646907BDC335650B755F12FE1E20C231E3B68D096C2DDD0CBE1A2785"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using UshakovAviaSales.Classes;
using UshakovAviaSales.MyPages;


namespace UshakovAviaSales.MyPages {
    
    
    /// <summary>
    /// HotelsPage
    /// </summary>
    public partial class HotelsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\MyPages\HotelsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid hotelsGrid;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\MyPages\HotelsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cityCmb;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\MyPages\HotelsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button resetBtn;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\MyPages\HotelsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LVHotels;
        
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
            System.Uri resourceLocater = new System.Uri("/UshakovAviaSales;component/mypages/hotelspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MyPages\HotelsPage.xaml"
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
            this.hotelsGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.cityCmb = ((System.Windows.Controls.ComboBox)(target));
            
            #line 46 "..\..\..\MyPages\HotelsPage.xaml"
            this.cityCmb.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cityCmb_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.resetBtn = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\MyPages\HotelsPage.xaml"
            this.resetBtn.Click += new System.Windows.RoutedEventHandler(this.resetBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.LVHotels = ((System.Windows.Controls.ListView)(target));
            
            #line 74 "..\..\..\MyPages\HotelsPage.xaml"
            this.LVHotels.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.LVHotels_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
