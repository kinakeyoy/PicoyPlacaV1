using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PicoYPlacaV1
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            btnmotos.Clicked += Btnmotos_Clicked;
		}

        private void Btnmotos_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new placaPage());
        }
    }
}
