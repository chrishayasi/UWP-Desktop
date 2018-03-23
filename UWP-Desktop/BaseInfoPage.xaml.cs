using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWP_Desktop.Model;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x411 を参照してください

namespace UWP_Desktop
{

    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class BaseInfoPage : Page
    {

        private ObservableCollection<CmbModel> KosekiList ;

        public BaseInfoPage()
        {
            this.InitializeComponent();

            KosekiList = new ObservableCollection<CmbModel>();
            KosekiList.Add(new CmbModel { Code = "01", Name = "北京" });
            KosekiList.Add(new CmbModel { Code = "02", Name = "天津" });
            KosekiList.Add(new CmbModel { Code = "03", Name = "上海" });
            KosekiList.Add(new CmbModel { Code = "04", Name = "広東" });
            KosekiList.Add(new CmbModel { Code = "05", Name = "河北" });
            KosekiList.Add(new CmbModel { Code = "06", Name = "河南" });
            KosekiList.Add(new CmbModel { Code = "07", Name = "四川" });
            KosekiList.Add(new CmbModel { Code = "08", Name = "福建" });
        }

        private void blank()
        {
            String selectedValue = string.Empty;
            if (this.cmbKoseki.SelectedValue != null) {
                selectedValue = ((CmbModel)this.cmbKoseki.SelectedValue).Code;
            }

            this.txtEmail.Text = selectedValue;
        }

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            this.blank();
        }
    }
}
