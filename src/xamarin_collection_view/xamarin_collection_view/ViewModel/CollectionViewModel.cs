using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace xamarin_collection_view.ViewModel
{
    public class MyModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ColorCode { get; set; }
    }

    public class CollectionViewModel : BaseViewModel
    {
        private ObservableCollection<MyModel> _myModels;
        public ObservableCollection<MyModel> MyModels
        {
            get => _myModels;
            set
            {
                _myModels = value;
                OnPropertyChanged("MyModels");
            }
        }

        public CollectionViewModel()
        {
            BuildModel();
        }

        public void BuildModel()
        {
            List<MyModel> myModels = new List<MyModel>()
            {
                new MyModel()
                {
                    Name = "Parrot",
                    Description = "The parrot",
                    ColorCode = GenerateRandomColor()
                },
                new MyModel()
                {
                    Name = "Pegion",
                    Description = "The pegion",
                    ColorCode = GenerateRandomColor()
                },
                new MyModel()
                {
                    Name = "Sparrow",
                    Description = "The sparrow",
                    ColorCode = GenerateRandomColor()
                },
                new MyModel()
                {
                    Name = "Robot",
                    Description = "The robot",
                    ColorCode = GenerateRandomColor()
                }
            };

            this.MyModels = new ObservableCollection<MyModel>(myModels);
        }

        public string GenerateRandomColor()
        {
            Random random = new Random();
            string color = string.Format("#{0:X6}", random.Next(0x1000000));

            return color;
        }
    }
}
