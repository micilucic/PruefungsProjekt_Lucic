using PruefungsProjekt_Lucic.ViewModels;
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
using System.Windows.Shapes;

namespace PruefungsProjekt_Lucic
{
    /// <summary>
    /// Interaction logic for AddDogWindow.xaml
    /// </summary>
    public partial class AddDogWindow : Window
    {
        public AddDogWindow()
        {
            InitializeComponent();
        }

        private void Button_New_Dog_Click(object sender, RoutedEventArgs e)
        {
            DogViewModel vm = this.DataContext as DogViewModel;
            vm.AddDog();
            this.Close();
        }
    }
}
