using quarks.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
// Include other necessary namespaces

namespace quarks.ViewModels
{
    public class TargetsViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Target> Targets { get; }

        public TargetsViewModel()
        {
            Targets = new ObservableCollection<Target>();
            // Load targets from the repository
        }

        // Correctly implement INotifyPropertyChanged with nullable event
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Add methods for Add, Edit, Delete operations that manipulate the Targets collection
    }
}
