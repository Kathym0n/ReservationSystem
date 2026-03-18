using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for NavigationBar.xaml
    /// </summary>
    public partial class NavigationBar : UserControl
    {
        public NavigationBar()
        {
            DataContext = this;
            InitializeComponent();
        }

        private string _boundText;

        public  event PropertyChangedEventHandler? PropertyChanged;
        public string BoundText
        {
            get { return _boundText; }
            set 
            { 
                _boundText = value;
                OnPropertyChanged("BoundText");
            }
        }


        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            BoundText = "Logout";
        }
    }
}
