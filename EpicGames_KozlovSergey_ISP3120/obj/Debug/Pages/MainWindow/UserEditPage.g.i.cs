﻿#pragma checksum "..\..\..\..\Pages\MainWindow\UserEditPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "30D6628DE4B072969F436A5F968238D2DFA78A3D2A9BE06B6881E1362834E5B1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using EpicGames_KozlovSergey_ISP3120.Pages.MainWindow;
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


namespace EpicGames_KozlovSergey_ISP3120.Pages.MainWindow {
    
    
    /// <summary>
    /// UserEditPage
    /// </summary>
    public partial class UserEditPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\Pages\MainWindow\UserEditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NicknameTextBox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Pages\MainWindow\UserEditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image UserImage;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Pages\MainWindow\UserEditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoveImageButton;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Pages\MainWindow\UserEditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChooseImageButton;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Pages\MainWindow\UserEditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EndEditUser;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\Pages\MainWindow\UserEditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteUserButton;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\Pages\MainWindow\UserEditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelEditButton;
        
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
            System.Uri resourceLocater = new System.Uri("/EpicGames_KozlovSergey_ISP3120;component/pages/mainwindow/usereditpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\MainWindow\UserEditPage.xaml"
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
            this.NicknameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.UserImage = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.RemoveImageButton = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\..\Pages\MainWindow\UserEditPage.xaml"
            this.RemoveImageButton.Click += new System.Windows.RoutedEventHandler(this.RemoveImageButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ChooseImageButton = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\..\Pages\MainWindow\UserEditPage.xaml"
            this.ChooseImageButton.Click += new System.Windows.RoutedEventHandler(this.ChooseImageButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.EndEditUser = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\Pages\MainWindow\UserEditPage.xaml"
            this.EndEditUser.Click += new System.Windows.RoutedEventHandler(this.EndEditUser_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DeleteUserButton = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\..\Pages\MainWindow\UserEditPage.xaml"
            this.DeleteUserButton.Click += new System.Windows.RoutedEventHandler(this.DeleteUserButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.CancelEditButton = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\..\Pages\MainWindow\UserEditPage.xaml"
            this.CancelEditButton.Click += new System.Windows.RoutedEventHandler(this.CancelEditButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

