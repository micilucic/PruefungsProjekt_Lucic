using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruefungsProjekt_Lucic.Models
{
    class Dog : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChange(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        private int _dogID;

        [Key]
        public int DogID
        {
            get { return _dogID; }
            set { _dogID = value;
                RaisePropertyChange("DogID");
            }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value;
                RaisePropertyChange("Name");
            }
        }

        private string _owner;

        public string Owner
        {
            get { return _owner; }
            set { _owner = value;
                RaisePropertyChange("Owner");
            }
        }

        private string _city;

        public string City
        {
            get { return _city; }
            set { _city = value;
                RaisePropertyChange("City");
            }
        }

        private string _breedType;

        public string BreedType
        {
            get { return _breedType; }
            set { _breedType = value;
                RaisePropertyChange("BreedType");
             }
        }

        private string _dogDescription;

        public string DogDescription
        {
            get { return _dogDescription; }
            set { _dogDescription = value;
                RaisePropertyChange("DogDescription");
            }
        }


        private string _meetingPlace;

        public string MeetingPlace
        {
            get { return _meetingPlace; }
            set { _meetingPlace = value;
                RaisePropertyChange("MeetingPlace");
            }
        }

        private string _gender;

        public string Gender
        {
            get { return _gender; }
            set { _gender = value;
                RaisePropertyChange("Gender");
            }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value;
                RaisePropertyChange("Age");
            }
        }

        private int _hoursAvailable;

        public int HoursAvailable
        {
            get { return _hoursAvailable; }
            set { _hoursAvailable = value; }
        }


        private DateTime _dateAvailable;

        public DateTime DateAvailable
        {
            get { return _dateAvailable; }
            set { _dateAvailable = value;
                RaisePropertyChange("DateAvailable");
            }
      
        }



    }
}
