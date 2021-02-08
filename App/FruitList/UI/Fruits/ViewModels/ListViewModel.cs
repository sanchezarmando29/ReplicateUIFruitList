using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using FruitList.Controls;
using FruitList.Domain.Fruits;
using FruitList.UI.ViewModels;
using FruitList.UseCases.Fruits;
using Prism.Navigation;

namespace FruitList.UI.Fruits.ViewModels
{
    public class ListViewModel : ViewModelBase
    {

        private readonly GetCurrentUserFruits _getCurrentUserFruits;

        private OrientationData _selectedOrientationData;

        public ObservableCollection<string> OrientationsData { get; set; }

        public ObservableCollection<Fruit> Fruits { get; set; }

        public OrientationData SelectedOrientationData
        {
            get
            {
                return _selectedOrientationData;
            }
            set
            {
                SetProperty(ref _selectedOrientationData, value);
            }
        }

        public ListViewModel(INavigationService navigationService, GetCurrentUserFruits getCurrentUserFruits)
            : base(navigationService)
        {
            // TODO: Change To Icons.
            OrientationsData = new ObservableCollection<string>(Enum.GetNames(typeof(OrientationData)));
            Fruits = new ObservableCollection<Fruit>();
            SelectedOrientationData = OrientationData.List;
            _getCurrentUserFruits = getCurrentUserFruits;
            Title = "Main Page";

            LoadFruits();
        }

        private async void LoadFruits()
        {
            IReadOnlyList<Fruit> resultFruits = await _getCurrentUserFruits.Invoke();

            foreach (Fruit item in resultFruits)
            {
                Fruits.Add(item);
            }
        }
    }
}