﻿#pragma checksum "..\..\..\PL\Projectsform.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46DA1714CB0802DA383C1606A6BF80214B7A14ED"
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


namespace WpfApplication2.PL {
    
    
    /// <summary>
    /// Projectsform
    /// </summary>
    public partial class Projectsform : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        /// <summary>
        /// Addbtn Name Field
        /// </summary>
        
        #line 14 "..\..\..\PL\Projectsform.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.Button Addbtn;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\PL\Projectsform.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exit;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\PL\Projectsform.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock date;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\PL\Projectsform.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtname;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\PL\Projectsform.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtid;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\PL\Projectsform.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid projectdg;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\PL\Projectsform.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn positionno;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\PL\Projectsform.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn positionname;
        
        #line default
        #line hidden
        
        /// <summary>
        /// Updatebtn Name Field
        /// </summary>
        
        #line 66 "..\..\..\PL\Projectsform.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.Button Updatebtn;
        
        #line default
        #line hidden
        
        /// <summary>
        /// Deletebtn Name Field
        /// </summary>
        
        #line 80 "..\..\..\PL\Projectsform.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.Button Deletebtn;
        
        #line default
        #line hidden
        
        /// <summary>
        /// clearbtn Name Field
        /// </summary>
        
        #line 94 "..\..\..\PL\Projectsform.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.Button clearbtn;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApplication2;component/pl/projectsform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PL\Projectsform.xaml"
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
            this.Addbtn = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\PL\Projectsform.xaml"
            this.Addbtn.Click += new System.Windows.RoutedEventHandler(this.Addbtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.exit = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\PL\Projectsform.xaml"
            this.exit.Click += new System.Windows.RoutedEventHandler(this.exit_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.date = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.txtname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtid = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.projectdg = ((System.Windows.Controls.DataGrid)(target));
            
            #line 59 "..\..\..\PL\Projectsform.xaml"
            this.projectdg.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.project_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.positionno = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 8:
            this.positionname = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 9:
            this.Updatebtn = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\PL\Projectsform.xaml"
            this.Updatebtn.Click += new System.Windows.RoutedEventHandler(this.Updatebtn_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Deletebtn = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\..\PL\Projectsform.xaml"
            this.Deletebtn.Click += new System.Windows.RoutedEventHandler(this.Deletebtn_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.clearbtn = ((System.Windows.Controls.Button)(target));
            
            #line 94 "..\..\..\PL\Projectsform.xaml"
            this.clearbtn.Click += new System.Windows.RoutedEventHandler(this.clearbtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

