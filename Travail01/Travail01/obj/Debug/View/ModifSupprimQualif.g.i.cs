﻿#pragma checksum "..\..\..\View\ModifSupprimQualif.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18B039B978F4AA59D132E0B57797482CF999BE85"
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
using Travail01.View;
using Travail01.View.MyUserControls;


namespace Travail01.View {
    
    
    /// <summary>
    /// ModifSupprimQualif
    /// </summary>
    public partial class ModifSupprimQualif : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 43 "..\..\..\View\ModifSupprimQualif.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grContent;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\View\ModifSupprimQualif.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNumQualif;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\View\ModifSupprimQualif.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNomQualif;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\View\ModifSupprimQualif.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNivQualif;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\View\ModifSupprimQualif.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDescripQualif;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\View\ModifSupprimQualif.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBoxQualif;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\..\View\ModifSupprimQualif.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btGoBack;
        
        #line default
        #line hidden
        
        
        #line 176 "..\..\..\View\ModifSupprimQualif.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btSupprimer;
        
        #line default
        #line hidden
        
        
        #line 178 "..\..\..\View\ModifSupprimQualif.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btModif;
        
        #line default
        #line hidden
        
        
        #line 180 "..\..\..\View\ModifSupprimQualif.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btAjouter;
        
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
            System.Uri resourceLocater = new System.Uri("/Travail01;component/view/modifsupprimqualif.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\ModifSupprimQualif.xaml"
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
            
            #line 13 "..\..\..\View\ModifSupprimQualif.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.PreviousPage_CanExecute);
            
            #line default
            #line hidden
            
            #line 14 "..\..\..\View\ModifSupprimQualif.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.PreviousPage_Executed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.grContent = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.txtNumQualif = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtNomQualif = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtNivQualif = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtDescripQualif = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.comboBoxQualif = ((System.Windows.Controls.ComboBox)(target));
            
            #line 100 "..\..\..\View\ModifSupprimQualif.xaml"
            this.comboBoxQualif.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBoxQualif_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btGoBack = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.btSupprimer = ((System.Windows.Controls.Button)(target));
            
            #line 176 "..\..\..\View\ModifSupprimQualif.xaml"
            this.btSupprimer.Click += new System.Windows.RoutedEventHandler(this.BtSupprimer_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btModif = ((System.Windows.Controls.Button)(target));
            
            #line 178 "..\..\..\View\ModifSupprimQualif.xaml"
            this.btModif.Click += new System.Windows.RoutedEventHandler(this.BtModif_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btAjouter = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

