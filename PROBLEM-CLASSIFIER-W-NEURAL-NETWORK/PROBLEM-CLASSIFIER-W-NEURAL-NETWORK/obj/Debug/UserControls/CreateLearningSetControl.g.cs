﻿#pragma checksum "..\..\..\UserControls\CreateLearningSetControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5BCD65024AD5B516B83B40C69C3E2F477D948B29"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PROBLEM_CLASSIFIER_W_NEURAL_NETWORK.UserControls;
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


namespace PROBLEM_CLASSIFIER_W_NEURAL_NETWORK.UserControls {
    
    
    /// <summary>
    /// CreateLearningSetControl
    /// </summary>
    public partial class CreateLearningSetControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\UserControls\CreateLearningSetControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_from;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\UserControls\CreateLearningSetControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_fromBrowse;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\UserControls\CreateLearningSetControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_to;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\UserControls\CreateLearningSetControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_toBrowse;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\UserControls\CreateLearningSetControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_label;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\UserControls\CreateLearningSetControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_create;
        
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
            System.Uri resourceLocater = new System.Uri("/PROBLEM-CLASSIFIER-W-NEURAL-NETWORK;component/usercontrols/createlearningsetcont" +
                    "rol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControls\CreateLearningSetControl.xaml"
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
            this.tb_from = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.btn_fromBrowse = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\UserControls\CreateLearningSetControl.xaml"
            this.btn_fromBrowse.Click += new System.Windows.RoutedEventHandler(this.btn_fromBrowse_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tb_to = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btn_toBrowse = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\UserControls\CreateLearningSetControl.xaml"
            this.btn_toBrowse.Click += new System.Windows.RoutedEventHandler(this.btn_toBrowse_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cb_label = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.btn_create = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\UserControls\CreateLearningSetControl.xaml"
            this.btn_create.Click += new System.Windows.RoutedEventHandler(this.btn_create_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

