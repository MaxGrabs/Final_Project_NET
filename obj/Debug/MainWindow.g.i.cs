// Updated by XamlIntelliSenseFileGenerator 2020-12-11 5:55:09 PM
#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BC62F991ECA2EE5DA8692058E11C87CCC6D2F2FBBFBDEDC6DC861BE35C935DDD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Final_Project_NET;
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


namespace Final_Project_NET
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden


#line 33 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnShowSelectedItem;

#line default
#line hidden


#line 34 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSelectLast;

#line default
#line hidden


#line 35 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSelectNext;

#line default
#line hidden


#line 36 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSelectCSharp;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Final_Project_NET;component/mainwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\MainWindow.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.lbTodoList = ((System.Windows.Controls.ListBox)(target));

#line 10 "..\..\MainWindow.xaml"
                    this.lbTodoList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lbTodoList_SelectionChanged);

#line default
#line hidden
                    return;
                case 2:
                    this.btnShowSelectedItem = ((System.Windows.Controls.Button)(target));

#line 33 "..\..\MainWindow.xaml"
                    this.btnShowSelectedItem.Click += new System.Windows.RoutedEventHandler(this.btnShowSelectedItem_Click);

#line default
#line hidden
                    return;
                case 3:
                    this.btnSelectLast = ((System.Windows.Controls.Button)(target));

#line 34 "..\..\MainWindow.xaml"
                    this.btnSelectLast.Click += new System.Windows.RoutedEventHandler(this.btnSelectLast_Click);

#line default
#line hidden
                    return;
                case 4:
                    this.btnSelectNext = ((System.Windows.Controls.Button)(target));

#line 35 "..\..\MainWindow.xaml"
                    this.btnSelectNext.Click += new System.Windows.RoutedEventHandler(this.btnSelectNext_Click);

#line default
#line hidden
                    return;
                case 5:
                    this.btnSelectCSharp = ((System.Windows.Controls.Button)(target));

#line 36 "..\..\MainWindow.xaml"
                    this.btnSelectCSharp.Click += new System.Windows.RoutedEventHandler(this.btnSelectCSharp_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }
    }
}

