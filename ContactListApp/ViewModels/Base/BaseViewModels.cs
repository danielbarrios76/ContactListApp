using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ContactListApp.ViewModels.Base
{
    /// <summary>
    /// Clase Abstracta Base para todas las ViewModels 
    /// para implementar la internfaz INotifyPropertyChanged
    /// para implementar lso metodos virtuales
    /// </summary>
    public abstract class BaseViewModels : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        bool isBusy = false;

        //Metodos abstractos para controlar la navegacion
        public virtual void OnAppearing(object navigationContext)
        {
        }

        public virtual void OnDisappearing()
        {
        }
       
        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                isBusy = value;
                OnPropertyChanged();
            }
        }
    }
}
