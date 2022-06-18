using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejer12DatosEmple
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnEnviar_Clicked(object sender, EventArgs e)
        {
            var emple = new Models.Empleados
            {
                nombre = txtNombre.Text,
                apellidos = txtApellidos.Text,
                edad = txtEdad.Text,
                email = txtEmail.Text,
            };

            var datos = new PageData();
            datos.BindingContext = emple;//.Suma();//Usando Bindign context con un contructor de clas
            await Navigation.PushAsync(datos);

        }
    }
}
