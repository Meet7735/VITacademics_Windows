﻿

#pragma checksum "C:\Users\Vinay\Source\Repos\VITacademics_Windows\VITacademics\VITacademics.WindowsPhone\UIControls\EnhancedTimetableControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2152BB56008DB33731588F025CA4F65C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VITacademics.UIControls
{
    partial class EnhancedTimetableControl : global::Windows.UI.Xaml.Controls.UserControl, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 219 "..\..\UIControls\EnhancedTimetableControl.xaml"
                ((global::Windows.UI.Xaml.Controls.ListViewBase)(target)).ItemClick += this.List_ItemClick;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 166 "..\..\UIControls\EnhancedTimetableControl.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Holding += this.ItemRootBorder_Holding;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 131 "..\..\UIControls\EnhancedTimetableControl.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Holding += this.ItemRootBorder_Holding;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 90 "..\..\UIControls\EnhancedTimetableControl.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Holding += this.ItemRootBorder_Holding;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 41 "..\..\UIControls\EnhancedTimetableControl.xaml"
                ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target)).Click += this.EditMenuItem_Click;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 42 "..\..\UIControls\EnhancedTimetableControl.xaml"
                ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target)).Click += this.DeleteMenuItem_Click;
                 #line default
                 #line hidden
                break;
            case 7:
                #line 32 "..\..\UIControls\EnhancedTimetableControl.xaml"
                ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target)).Click += this.AddMenuItem_Click;
                 #line default
                 #line hidden
                break;
            case 8:
                #line 276 "..\..\UIControls\EnhancedTimetableControl.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.DateButton_Click;
                 #line default
                 #line hidden
                break;
            case 9:
                #line 278 "..\..\UIControls\EnhancedTimetableControl.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.ManualEventAddButton_Click;
                 #line default
                 #line hidden
                break;
            case 10:
                #line 314 "..\..\UIControls\EnhancedTimetableControl.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.SetReminderButton_Click;
                 #line default
                 #line hidden
                break;
            case 11:
                #line 317 "..\..\UIControls\EnhancedTimetableControl.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.CancelButton_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


