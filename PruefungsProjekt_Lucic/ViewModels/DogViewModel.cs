using PruefungsProjekt_Lucic.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruefungsProjekt_Lucic.ViewModels
{
    class DogViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        public DogViewModel()
        {
            Dogs = new ObservableCollection<Dog>();
        }

        public ObservableCollection<Dog> Dogs { get; set; }

        public Dog NewBuddy { get; set; } 

        DogDBContext _ctx = new DogDBContext();

        public void ShowDogsFromDB()
        {
            Dogs = new ObservableCollection<Dog>();

            foreach (Dog dog in _ctx.Dogs)
            {
                Dogs.Add(dog);
            }
            RaisePropertyChanged("StatusBarCount");
        }

        public void AddDog()
        {
            var newDog = new Dog()
            {
                Name = NewBuddy.Name,
                Owner = NewBuddy.Owner,
                Age = NewBuddy.Age,
                City = NewBuddy.City,
                DogType = NewBuddy.DogType,
                DogDescription = NewBuddy.DogDescription,
                MeetingPlace = NewBuddy.MeetingPlace,
                Gender = NewBuddy.Gender,
                HoursAvailable = NewBuddy.HoursAvailable
            };

            _ctx.Dogs.Add(NewBuddy);
            _ctx.SaveChanges();
            Dogs.Add(newDog);
            RaisePropertyChanged("StatusBarCount");
        }

        public void DeleteDog()
        {
            var dogToDelete = _ctx.Dogs.Find(ChosenDog.DogID);

            _ctx.Dogs.Remove(dogToDelete);
            _ctx.SaveChanges();

            Dogs.Remove(dogToDelete);
            RaisePropertyChanged("StatusBarCount");
        }

        public string searchText { get; set; }

        public void filterDogType()
        {
            Dogs = new ObservableCollection<Dog>();
            foreach (Dog dog in _ctx.Dogs.Where(p => p.DogType.Contains(searchText)))
            {
                Dogs.Add(dog);
            }
            RaisePropertyChanged("Dogs");
            RaisePropertyChanged("StatusBarCount");

        }

        private Dog _chosenDog;

        public Dog ChosenDog
        {
            get { return _chosenDog; }
            set { _chosenDog = value;
                RaisePropertyChanged("ChosenDog");
            }
        }

        private string _statusBarCount;

        public string StatusBarCount
        {
            get { 
                if (Dogs.Count == 0)
                {
                    return "There are no available buddies at the moment.";
                }
                return $"There are {Dogs.Count} dogs in need of buddies!"; }
        }

        public void UpdateDog()
        {
            var dogToUpdate = _ctx.Dogs.Find(ChosenDog.DogID);

            _ctx.SaveChanges();
            
        }

    }
}
