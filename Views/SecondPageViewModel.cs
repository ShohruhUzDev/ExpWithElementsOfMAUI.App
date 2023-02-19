using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace ExpWithElementsOfMAUI.Views
{
    public partial class SecondPageViewModel  :ObservableObject
    {
        public SecondPageViewModel()
        {
            people=new ObservableCollection<Person>();
        }

        [ObservableProperty]
        string name;

        [ObservableProperty]
        int age;

        [ObservableProperty]
        ObservableCollection<Person> people;

        [RelayCommand]
        public void Add()
        {
            People.Add(new Person(Name, Age));
            Name= string.Empty;
            Age = 0;
        }
        [RelayCommand]
        public void Delete(Person person)
        {
            people.Remove(person);

        }



    }
}
