using ContactListApp.Model;
using ContactListApp.ViewModels.Base;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace ContactListApp.ViewModels
{
    class ContactListViewModels : BaseViewModels
    {
        private Contacts selectedContact;

        //Comandos para tareas desde la vista
        public Command CommandRefreshContactList { get; set; }
        public Command CommandLoadContactList { get; set; }
        

        //Lista (coleccion) de contactos
        public ObservableCollection<Contacts> contactList { get; set; }

        /// <summary>
        /// Para realizar acciones al actualziar la lista
        /// </summary>
        private void RefreshContactList()
        {
            //Acciones al refrescar el ListView
        }
        
        /// <summary>
        /// Metodo para cargar algunos datos a la lista
        /// 
        /// </summary>
        private void LoadContactList()
        {
          //Llenamos con algunos ejemplos la lista
            contactList.Add(new Contacts
            {
                lastName = "Barrios",
                firstName = "Daniel",
                email = "danielbarrios76@hotmail.com",
                address = "Lagoria 1734",
                phoneNumber = "11345678912"
            });
            contactList.Add(new Contacts
            {
                lastName = "Diaz",
                firstName = "Juana",
                email = "juanadiaz@email.com",
                address = "Illia de la Rua 1234",
                phoneNumber = "1234567890"
            }); contactList.Add(new Contacts
            {
                lastName = "Perez",
                firstName = "Milagros",
                email = "mialgrosperez@email.com",
                address = "Corrientes 10345",
                phoneNumber = "11345678902"
            });
            contactList.Add(new Contacts
            {
                lastName = "Rodriguez",
                firstName = "Alejandra",
                email = "rodriguezalejandra@email.com",
                address = "9 de julio 345",
                phoneNumber = "11098765432"
            });
        }

        /// <summary>
        /// Constructor
        /// Inicializa la Lista de contactos (coleccion)
        /// Define el comando para cargar los datos
        /// </summary>
        public ContactListViewModels()
        {

            contactList = new ObservableCollection<Contacts>();
            CommandRefreshContactList = new Command( () => RefreshContactList());
            CommandLoadContactList = new Command(  () => LoadContactList());
                        
        }


        public Contacts SelectedContact
        {
            get { return selectedContact; }
            set
            {
                if (selectedContact != value)
                {
                    selectedContact = value;
                    OnPropertyChanged();
                    DisplayMessage();
                }
                    
            }
        }

        /// <summary>
        /// Mostrar un mensaje con el detalle del contacto seleccionado
        /// </summary>
        public void DisplayMessage()
        {
            IsBusy = true;
            Application.Current.MainPage.DisplayAlert("Contact Detail", $"{selectedContact.lastName}\n" +
                                                                        $"{selectedContact.firstName}\n" +
                                                                        $"{selectedContact.email}\n" +
                                                                        $"{selectedContact.phoneNumber}\n", 
                                                                        "Ok");
            IsBusy = false;
        }

        //*******

    }
}
