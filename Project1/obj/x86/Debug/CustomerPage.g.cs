﻿#pragma checksum "C:\Users\icyhot\source\repos\cs270-project\Project1\CustomerPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8B2931BB03B87FBEB4FE0DF0A1E734B5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project1
{
    partial class CustomerPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.listview_add_customer_ = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 2:
                {
                    this.listview_delete_customer_ = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 3:
                {
                    this.btn_back_ = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 26 "..\..\..\CustomerPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btn_back_).Click += this.btn_back__Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.listview_edit_customer_ = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 5:
                {
                    this.listview_find_customer = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 6:
                {
                    this.find_customer_by_id_box_ = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7:
                {
                    global::Windows.UI.Xaml.Controls.Button element7 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 42 "..\..\..\CustomerPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element7).Click += this.FindCustomer_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.found_customer_block_ = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9:
                {
                    this.edit_customer_block_ = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    this.old_id_box_ = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 11:
                {
                    this.new_id_box_ = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 12:
                {
                    this.new_name_box_ = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 13:
                {
                    global::Windows.UI.Xaml.Controls.Button element13 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 33 "..\..\..\CustomerPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element13).Click += this.EditCustomer_Click;
                    #line default
                }
                break;
            case 14:
                {
                    this.edit_block_ = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15:
                {
                    this.delete_customer_block_ = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16:
                {
                    this.delete_customer_by_id_box_ = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 17:
                {
                    global::Windows.UI.Xaml.Controls.Button element17 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 22 "..\..\..\CustomerPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element17).Click += this.DeleteCustomer_Click;
                    #line default
                }
                break;
            case 18:
                {
                    this.delete_customer_result_block_ = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 19:
                {
                    this.add_customer_block_ = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 20:
                {
                    this.customer_name_box_ = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 21:
                {
                    this.customer_id_box_ = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 22:
                {
                    this.add_customer_button_ = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 15 "..\..\..\CustomerPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.add_customer_button_).Click += this.AddCustomer_Click;
                    #line default
                }
                break;
            case 23:
                {
                    this.error_block_ = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

