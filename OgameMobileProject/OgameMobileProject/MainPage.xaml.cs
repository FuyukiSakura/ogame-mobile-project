using OgameMobileProject.Model;
using OgameMobileProject.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace OgameMobileProject
{
	public partial class MainPage : ContentPage
	{
        public GamePage Current { get; set; }
		public MainPage()
		{
			InitializeComponent();
		}

        public async void LoginButton_Clicked(object sender, EventArgs e)
        {
            var account = new LoginModel
            {
                Username = UsernameEntry.Text,
                Password = PasswordEntry.Text
            };

            Current = new GamePage(account);
            await Navigation.PushAsync(Current);
        }
    }
}
