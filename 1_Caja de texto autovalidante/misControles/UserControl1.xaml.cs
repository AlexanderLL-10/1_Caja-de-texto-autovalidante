using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _1_Caja_de_texto_autovalidante.misControles
{
    /// <summary>
    /// Lógica de interacción para UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public String tipoValidacion { get; set; }

        public String contenidoBoton { get; set; }

        public UserControl1()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        private void PerderFoco(object sender, RoutedEventArgs e)
        {
            switch (tipoValidacion)
            {
                case "cp":

                    tipo.Content = "CodigoPostak";
                    if (enviarCP.Text == "")
                    {
                        mensaje.Content = "no hay cp";

                    }
                    else if (enviarCP.Text.Length != 5)
                    {
                        mensaje.Content = "datos incorrectos";
                    }
                    else
                    {
                        mensaje.Content = "dato correcto";
                    }

                    break;

                case "numero":
                    tipo.Content = "Numero telefono";
                    if (enviarCP.Text == "")
                    {
                        mensaje.Content = "no hay numero";
                    }
                    else if (enviarCP.Text.Length != 9)
                    {
                        mensaje.Content = "datos incorrectos";
                    }
                    else
                    {
                        mensaje.Content = "dato correcto";
                    }
                    break;

                case "edad":
                    tipo.Content = "Edad";
                    int edad = Int32.Parse(enviarCP.Text);

                    if (edad < 18)
                    {
                        mensaje.Content = "menor de edad";
                    }
                    else {
                        mensaje.Content = "mayor de edad";
                         }

                    break;
            }
            /*
            if (tipo.Text == "cp")
            {
                //Codigo postal:
                
                
                miBoton.Content = "enviar cp";
                
                if (cajaTexto.Text == "")
                {
                    mensaje.Content = "esta vacio";
                }
                else if (cajaTexto.Text.Length != 5)
                {
                    mensaje.Content = "el cp tiene que tener 5 caracteres";
                }
                else
                {
                    mensaje.Content = "Correcto";
                }
                
            }
            else if (tipo.Text == "numero")
            {
                //Numero movil:
                miBoton.Content = "enviar numero";
                if (cajaTexto.Text == "")
                {
                    mensaje.Content = "esta vacio";
                }
                else if (cajaTexto.Text.Length != 9)
                {
                    mensaje.Content = "tiene que tener 9 numeros";
                }
                else
                {
                    mensaje.Content = "Correcto";
                }
            }
            else if (tipo.Text == "dni")
            {
                // DNI:
                miBoton.Content = "enviar DNI";
                if (cajaTexto.Text == "")
                {
                    mensaje.Content = "esta vacio";
                }
                else if (cajaTexto.Text.Length != 9)
                {
                    mensaje.Content = "el cp tiene que tener 9 caracteres";
                }
                else
                {
                    mensaje.Content = "Correcto";
                }
            }    
            */
        }
    }
}
