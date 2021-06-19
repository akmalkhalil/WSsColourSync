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
using Windows.UI.ViewManagement;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

// Useful resources
// https://docs.microsoft.com/en-us/windows/uwp/design/style/color#accent-color
//
//


namespace WSsColourSync
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public string todaysCol { get; set; }
        UISettings UISetObj;
        UIColorType abc;

        private string GetCurrentAccentCol()
        {
            this.UISetObj = new UISettings();
            var col = this.UISetObj.GetColorValue(UIColorType.Accent);
            string colString = col.ToString();
            return colString;
        }
        public MainPage()
        {
            this.InitializeComponent();

            this.DataContextChanged += (s, e) => this.Bindings.Update();
            // https://devblogs.microsoft.com/oldnewthing/20170405-00/?p=95905
            // https://docs.microsoft.com/en-us/uwp/api/windows.ui.viewmanagement.uisettings.getcolorvalue?view=winrt-20348#Windows_UI_ViewManagement_UISettings_GetColorValue_Windows_UI_ViewManagement_UIColorType_
            //this.todaysCol = 
            this.todaysCol = GetCurrentAccentCol();

        }

        private void TitleTB_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void TextBlock_SelectionChanged_1(object sender, RoutedEventArgs e)
        {

        }

    }
}
