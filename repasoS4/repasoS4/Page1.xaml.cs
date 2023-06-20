using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace repasoS4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = "uisrael";
            string contrasena = "2023";
            if(txtUsuario.Text==usuario && txtContrasena.Text == contrasena)
            {
                Navigation.PushAsync(new Page2(usuario));
            }
            else
            {
                DisplayAlert("Error", "Usuario/Contraseña incorrectos", "Cerrar");
            }
        }

        private void btnCancelar_Clicked(object sender, EventArgs e)
        {

        }
    }
}