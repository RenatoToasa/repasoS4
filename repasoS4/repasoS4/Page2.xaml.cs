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
    public partial class Page2 : ContentPage
    {
        string usuario;
        public Page2(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "USUARIO CONECTADO: "+ usuario;
            this.usuario=  usuario  ;
        }

        private void txtDato_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double dato =Convert.ToDouble(txtDato.Text);
                if(dato > 100 || dato <0  )
                {
                    DisplayAlert("Error", "Fuera de rango 1 -100", "Cerrar");
                    txtDato.Text = "";
                }
            }
            catch (Exception)
            {

             
            }
        }

        private void btnAbrir_Clicked(object sender, EventArgs e)
        {
            double dato = Convert.ToDouble(txtDato.Text);
            string alumno = pkAlumnos.Items[pkAlumnos.SelectedIndex];
            Navigation.PushAsync(new Page3(usuario, dato, alumno));
        }
    }
}