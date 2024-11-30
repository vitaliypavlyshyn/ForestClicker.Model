using ForestClicker.Model.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ForestClicker.Model.ViewModels
{
    public class DataViewModel : ViewModelBase
    {
        public DataViewModel()
        {
            SetControlVisibility = new Command(ControlVisibility);
            BuyForestCommand = new Command(BuyForest);
            BuyAnimalCommand = new Command(BuyAnimal);  
            KillPoacherCommand = new Command(KillPoacher); 
        }
        

        private string _visibleControl = "Forests";
        public string VisibleControl
        {
            get => _visibleControl;
            set
            {
                _visibleControl = value;
                OnPropertyChanged("VisibleControl");
            }
        }

        public ICommand SetControlVisibility { get; set; }

        public void ControlVisibility(object args)
        {
            VisibleControl = args.ToString();
        }

        private ForestViewModel _selectedForest;
        public ForestViewModel SelectedForest
        {
            get => _selectedForest;
            set
            {
                _selectedForest = value;
                OnPropertyChanged("SelectedForest");
            }
        }

        public ICommand BuyForestCommand { get; set; }
        public void BuyForest(object args)
        {
            if (args is ForestViewModel forest)
            {
                if (forest.Count < forest.MaxCount)
                {
                    forest.Count++;
                }
            }
        }


        private AnimalViewModel _selectedAnimal;
        public AnimalViewModel SelectedAnimal
        {
            get => _selectedAnimal;
            set
            {
                _selectedAnimal = value;
                OnPropertyChanged("SelectedAnimal");
            }
        }

        public ICommand BuyAnimalCommand { get; set; }
        public void BuyAnimal(object args)
        {
            if (args is AnimalViewModel animal)
            {
                if (animal.Count < animal.MaxCount)
                {
                    animal.Count++;
                }
            }
        }


        private PoacherViewModel _selectedPoacher;
        public PoacherViewModel SelectedPoacher
        {
            get => _selectedPoacher;
            set
            {
                _selectedPoacher = value;
                OnPropertyChanged("SelectedPoacher");
            }
        }

        public ICommand KillPoacherCommand { get; set; }
        public void KillPoacher(object args)
        {
            if (args is PoacherViewModel poacher)
            {
                if (poacher.Count > 0)
                {
                    poacher.Count--;
                }
            }
        }


        private ObservableCollection<ForestViewModel> _forests;
        public ObservableCollection<ForestViewModel> Forests
        {
            get => _forests;
            set
            {
                _forests = value;
                OnPropertyChanged("Forests");
            }
        }

        private ObservableCollection<AnimalViewModel> _animals;
        public ObservableCollection<AnimalViewModel> Animals
        {
            get => _animals;
            set
            {
                _animals = value;
                OnPropertyChanged("Animals");
            }
        }

        private ObservableCollection<PoacherViewModel> _poachers;
        public ObservableCollection<PoacherViewModel> Poachers
        {
            get => _poachers;
            set
            {
                _poachers = value;
                OnPropertyChanged("Poachers");
            }
        }

    }
}
