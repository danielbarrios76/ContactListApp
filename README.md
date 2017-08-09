# ContactListApp

Siquiengo la linea de los contactos, una aplicacion simple para mostrar el uso de MVVM con Xamarin.Form ListView con la estrategia PCL.


No esta incluido el proyecto iOS por que no tengo una Mac para compilar, pero no deberia tener problemas en funcionar tambien.


Descripcion:

La solucion consta de 3 proyectos:

*  ContactsListApp (core del MVVM)

*  ContactsListApp.Android

*  ContactsListApp.UWP

**No se incluye el proyecto .iOS**


Los proyectos .Android y . UWP no tienen modificaciones con respecto a la plantilla de Visual Studio

El proyecto ContactsApp es el PCL y contiene el Model, el ViewModels y la View, que en este caso es la MainPage Unica para los proyectos

En Model tenemos la Clase Plana Contacts, que tiene propiedades publicas simples.

En ViewModels tenemos una carpeta Base, en donde esta la Clase Abstracta BaseViewModel para ordenar un poco el codigo e impelmentar ahi la  Interface INOTIFYPROPIETYCHANGED y algunas propiedas de uso estrategico como isBusy. Esta clase abstracta es la Base para las ViewModels. La Clase ContactListViewModels, es la que interactura con la View hereda de BaseViewModel.

La MainPage.XAML es la View que hace los llamados a la ViewModels depediendo de las acciones del usuario.

Un ejemplo cortito y simple, para ir encaminando al desarrollo de la App completa.
