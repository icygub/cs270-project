using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Project1 {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CargoPlanePage : Page {
        public CargoPlanePage() {
            this.InitializeComponent();
        }

        private void btn_back_cargo_plane__Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(MainPage), null);
        }

        private void btn_add_plane__Click(object sender, RoutedEventArgs e) {
            TextBox planeNumber = box_plane_number_;
            //if (TextIsConvertibleToInt(box_pl))
        }

        private bool TextIsConvertibleToInt(TextBox textBox) {
            try {
                int.Parse(textBox.Text);
                return true;
            }
            catch {
                //textBlock.Text = "ID input is not an int.";
                return false;
            }
        }

       
    }
}
