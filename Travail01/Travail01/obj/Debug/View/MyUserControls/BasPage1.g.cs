#pragma checksum "..\..\..\..\View\MyUserControls\BasPage1.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E97FB6D1DD89AF6241E880C44CEDD07C3731A064"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
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
using Travail01.View.MyUserControls;


namespace Travail01.View.MyUserControls {
    
    
    /// <summary>
    /// BasPage1
    /// </summary>
    public partial class BasPage1 : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 45 "..\..\..\..\View\MyUserControls\BasPage1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btQuit;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\View\MyUserControls\BasPage1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btSupprime;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\View\MyUserControls\BasPage1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btModif;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\View\MyUserControls\BasPage1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btNouveau;
        
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
            System.Uri resourceLocater = new System.Uri("/Travail01;component/view/myusercontrols/baspage1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\MyUserControls\BasPage1.xaml"
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
            this.btQuit = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\..\View\MyUserControls\BasPage1.xaml"
            this.btQuit.Click += new System.Windows.RoutedEventHandler(this.BtQuit_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btSupprime = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\..\View\MyUserControls\BasPage1.xaml"
            this.btSupprime.Click += new System.Windows.RoutedEventHandler(this.BtSupprime_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btModif = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\..\View\MyUserControls\BasPage1.xaml"
            this.btModif.Click += new System.Windows.RoutedEventHandler(this.BtModif_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btNouveau = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\..\View\MyUserControls\BasPage1.xaml"
            this.btNouveau.Click += new System.Windows.RoutedEventHandler(this.BtNouveau_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

