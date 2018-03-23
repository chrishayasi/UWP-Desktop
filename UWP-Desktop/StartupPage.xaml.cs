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

// 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=234238 を参照してください

namespace UWP_Desktop
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class StartupPage : Page
    {
        public StartupPage()
        {
            this.InitializeComponent();
        }

        private void BaseInfo_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(BaseInfoPage));
        }

        private void EmpInfo_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(EmpInfoPage));
        }

        private void HomeInfo_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(HomeInfoPage));
        }

        private void BtnGotoPivot_Click(object sender, RoutedEventArgs e)
        {
            //this.Frame.Navigate(typeof(PivotStylePage));
            this.blankMethod();
            MyFrame.Navigate(typeof(PivotStylePage));
        }
        private void blankMethod()
        {
            
        }
    }
}
