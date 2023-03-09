using PruefungsProjekt_Lucic.Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PruefungsProjekt_Lucic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DogViewModel vm = new DogViewModel();

            vm.NewBuddy = new Models.Dog()
            {
                Name =  " ",
                Owner = " ",
                Age = 0,
                City = " ",
                BreedType = " ",
                Gender = " ",
                DogDescription = " ",
                DateAvailable = DateTime.Now,
                HoursAvailable = 1
            };

            vm.ShowDogsFromDB();
            this.DataContext = vm;
        }

        private void MenuItemNewDog_Click(object sender, RoutedEventArgs e)
        {
            AddDogWindow newAddDogWindow = new AddDogWindow();
            DogViewModel vm = this.DataContext as DogViewModel;
            newAddDogWindow.DataContext = vm;
            newAddDogWindow.ShowDialog();
        }

        private void MenuItemUpdateDog_Click(object sender, RoutedEventArgs e)
        {
            UpdateDogWindow updateDogWindow = new UpdateDogWindow();
            DogViewModel vm = this.DataContext as DogViewModel;
            updateDogWindow.DataContext = vm;
            updateDogWindow.ShowDialog();
        }

        private void MenuItemDeleteDog_Click(object sender, RoutedEventArgs e)
        {
            DogViewModel vm = this.DataContext as DogViewModel;
            vm.DeleteDog();
        }

        private void ButtonSuchen_Click(object sender, RoutedEventArgs e)
        {
            DogViewModel vm = this.DataContext as DogViewModel;
            vm.filterDogType();
        }
    }
}
