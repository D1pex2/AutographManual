﻿#pragma checksum "..\..\..\Pages\TestPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "044F39D1BE818A1FFBCDF494B1EC38E91BA511AB3CD2C7AC0B80968C89530563"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AuthographManual.Controls;
using AuthographManual.Pages;
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


namespace AuthographManual.Pages {
    
    
    /// <summary>
    /// TestPage
    /// </summary>
    public partial class TestPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Pages\TestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel StartStackPanel;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Pages\TestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TestTitleTextBlock;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Pages\TestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StartButton;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Pages\TestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel TestStackPanel;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\TestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal AuthographManual.Controls.Quest Quest;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Pages\TestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel ResultStackPanel;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\TestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock GradeTextBlock;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Pages\TestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RestartButton;
        
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
            System.Uri resourceLocater = new System.Uri("/AuthographManual;component/pages/testpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\TestPage.xaml"
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
            this.StartStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.TestTitleTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.StartButton = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Pages\TestPage.xaml"
            this.StartButton.Click += new System.Windows.RoutedEventHandler(this.StartButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TestStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.Quest = ((AuthographManual.Controls.Quest)(target));
            return;
            case 6:
            this.ResultStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 7:
            this.GradeTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.RestartButton = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\Pages\TestPage.xaml"
            this.RestartButton.Click += new System.Windows.RoutedEventHandler(this.RestartButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

