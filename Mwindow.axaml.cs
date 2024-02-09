using System.Collections.Generic;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace RegistrationForm;



public partial class Mwindow : Window
{
 
  

    public Mwindow()
    {
        InitializeComponent();
        List<Person> listString = new List<Person>()
        {
            new Person()
            {
                name = "qwe",
                email = "qwe"
            },
            new Person()
            {
                name = "123",
                email = "123"
            }
            
        };
        
        
        

        Nan.nanna = listString;
        
        ASD.ItemsSource = listString;
    }


    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        listString ls = new listString();
        ls.Show();
    }
}