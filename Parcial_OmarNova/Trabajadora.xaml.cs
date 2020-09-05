using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Parcial_OmarNova
{
    /// <summary>
    /// Lógica de interacción para Trabajadora.xaml
    /// </summary>
    public partial class Trabajadora : Page
    {

        
        public Trabajadora()
        {
            InitializeComponent();
            cmbPanes.Items.Add("Aliñados");
            cmbPanes.Items.Add("No Aliñado");
            cmbPanes.Items.Add("Especial");
            
            
        }
        Double ventasTotales,contador;
        List<String> ventas = new List<string>();
        DateTime tiempo = DateTime.Now;
        List<String> clientesVendidos = new List<string>();

        private void ir_Click(object sender, RoutedEventArgs e)
        {
            MainWindow login = (MainWindow)Window.GetWindow(this);
            login.frameMain.NavigationService.Navigate(new Administradora());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Double Precio, cantidad;
            contador += 1;
            ventas.Add(txtNombreCliente.Text);
            ventas.Add(txtCedula.Text);
            ventas.Add(cmbPanes.Text);
            clientesVendidos.Add(txtNombreCliente.Text);

            if (cmbPanes.Text == "Aliñados")
            {
                cantidad = Convert.ToDouble(txtCantidadPanes.Text);
                Precio = cantidad * 1000;
                ventasTotales += Precio;
                ventas.Add(Precio + " Pesos");

            }
            else if (cmbPanes.Text == "No Aliñado")
            {
                cantidad = Convert.ToDouble(txtCantidadPanes.Text);
                Precio = cantidad * 500;
                ventasTotales += Precio;
                ventas.Add(Precio + " Pesos");

            }
            else
            {
                cantidad = Convert.ToDouble(txtCantidadPanes.Text);
                Precio = cantidad * 2000;
                ventasTotales += Precio;
                ventas.Add(Precio + " Pesos");

            }
            ventas.Add(tiempo.ToString());

            txtRegistro.Text = String.Join("\n", ventas);
            txtResumen.Text = ("Ventas Totales = " + contador + "\n" + "Ganancias Obtenidas = " + ventasTotales + " Pesos" );

            Administradora admin = new Administradora();
            admin.txtProductos.Text = Convert.ToString(contador);
            admin.txtGanancias.Text = Convert.ToString(ventasTotales);
            admin.txtClientes.Text = String.Join(",", clientesVendidos);

        }
    }
}
