using System.Collections.Generic;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace RegistrationForm;

public partial class listString : Window

{
  

    public listString()
    {
        InitializeComponent();
        List<Person> nannana = new List<Person>();
        nannana = Nan.nanna;
        asd.ItemsSource = nannana;
    }
}