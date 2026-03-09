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

namespace AirlineReservationSystem.UI.UserControls
{
    /// <summary>
    /// Interaction logic for PasswordTextbox.xaml
    /// </summary>
    public partial class PasswordTextbox : UserControl
    {
        public PasswordTextbox()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            pwInput.Clear();
            pwInput.Focus();
        }
    }
}
