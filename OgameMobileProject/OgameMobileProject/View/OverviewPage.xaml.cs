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
	public partial class OverviewPage : ContentPage
	{
        public GamePage Controller { get; }
		public OverviewPage (GamePage controller)
		{
			InitializeComponent ();
            Controller = controller;
		}
	}
}