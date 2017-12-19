using OgameMobileProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OgameMobileProject.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GamePage : ContentPage
	{
        public LoginModel Account { get; }
		public GamePage (LoginModel account)
		{
			InitializeComponent ();
            Account = account;
            MainBrowser.Source = new UrlWebViewSource
            {
                Url = "https://tw.ogame.gameforge.com/"
            };
            MainBrowser.Navigated += MainBrowser_Navigated;

		}

        public void MainBrowser_Navigated(object sender, WebNavigatedEventArgs e)
        {
            var browser = (WebView)sender;
            //If home page, login
            if(e.Url == "https://tw.ogame.gameforge.com/")
            {
                browser.Eval("javascript:document.getElementById('serverLogin').value = '" + Account.Server + "';"+
                "document.getElementById('usernameLogin').value='" + Account.Username + "';"+
                "document.getElementById('passwordLogin').value='" + Account.Password + "';"+
                "document.getElementById('loginSubmit').click();");
            }
        }

        /// <summary>
        /// Get the WebView object for control
        /// </summary>
        /// <returns></returns>
        public WebView GetBrowser()
        {
            return MainBrowser;
        }
	}
}