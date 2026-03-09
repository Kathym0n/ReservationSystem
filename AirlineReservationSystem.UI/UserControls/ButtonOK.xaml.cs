using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for ButtonOK.xaml
    /// </summary>
    public partial class ButtonOK : UserControl, INotifyPropertyChanged
    {
        public ButtonOK()
        {
            DataContext = this;
            InitializeComponent();
        }
        private int _placeholder;
        public event PropertyChangedEventHandler? PropertyChanged;

        public int Placeholder
        {
            get { return _placeholder; }
            set 
            { 
                _placeholder = value;
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
                MessageBoxResult result = MessageBox.Show("Bitte erneut versuchen!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
