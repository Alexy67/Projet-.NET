using Prism.Mvvm;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DataTemplates
{
    public class MainWindowViewModel : BindableBase
    {
        private IClass selectedClass;

        public ObservableCollection<IClass> AvailableClasses { get; private set; }

        public IClass SelectedClass
        {
            get { return selectedClass; }
            set { SetProperty(ref selectedClass, value); }
        }

        public MainWindowViewModel()
        {
            IClass cl1 = new ClassA() { Number = 1 };
            IClass cl2 = new ClassB() { Text = "b1" };
            IClass cl3 = new ClassA() { Number = 2 };
            List<IClass> myList = new List<IClass>() { cl1, cl2, cl3 };
            AvailableClasses = new ObservableCollection<IClass>(myList);
        }
    }
}