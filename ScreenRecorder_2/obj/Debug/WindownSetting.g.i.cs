﻿#pragma checksum "..\..\WindownSetting.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DB728ACC4A0B0DE657E5DEC4564F3349BFBF55AE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ScreenRecorder_2;
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


namespace ScreenRecorder_2 {
    
    
    /// <summary>
    /// WindownSetting
    /// </summary>
    public partial class WindownSetting : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\WindownSetting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox video_path;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\WindownSetting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox video_framerate;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\WindownSetting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox video_bitrate;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\WindownSetting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox video_type;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\WindownSetting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox audio_path;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\WindownSetting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox audio_bitrate;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\WindownSetting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox audio_type;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\WindownSetting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox capture_path;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\WindownSetting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox capture_type;
        
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
            System.Uri resourceLocater = new System.Uri("/ScreenRecorder_2;component/windownsetting.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WindownSetting.xaml"
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
            this.video_path = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.video_framerate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.video_bitrate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            
            #line 24 "..\..\WindownSetting.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.video_path_click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.video_type = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.audio_path = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.audio_bitrate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 40 "..\..\WindownSetting.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.audio_path_click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.audio_type = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.capture_path = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            
            #line 54 "..\..\WindownSetting.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.capture_path_click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.capture_type = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 13:
            
            #line 63 "..\..\WindownSetting.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.save_click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
