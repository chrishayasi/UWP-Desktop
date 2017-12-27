using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Resources;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Globalization;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x411 を参照してください

namespace App3
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        //private bool langJp = true;

        private async void GreetingButton_OnClicked(object sender, RoutedEventArgs e)
        {
            App.IslangJp = !App.IslangJp;

            if (App.IslangJp)
            {
                ApplicationLanguages.PrimaryLanguageOverride = "en";
            }
            else
            {
                ApplicationLanguages.PrimaryLanguageOverride = "ja";
            }


            

            this.Frame.Navigate(typeof(MainPage));

            var r = ResourceLoader.GetForCurrentView();

            var dlg = new MessageDialog(r.GetString("GreetingMessage"));

            await dlg.ShowAsync();
        }
    }
}
