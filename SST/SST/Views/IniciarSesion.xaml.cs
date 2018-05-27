using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SST.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IniciarSesion : ContentPage
	{
		public IniciarSesion ()
		{
			InitializeComponent (); 

        }
  
        public async void SiguienteButton_Clicked(Object sender, EventArgs args)
        {

            await Navigation.PushAsync(new RegistroPersona());
        }
    }
}