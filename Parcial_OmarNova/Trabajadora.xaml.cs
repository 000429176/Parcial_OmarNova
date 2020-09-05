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
            DateTime tiempo = DateTime.Now;

        }


        
        
        
        
    }
}
