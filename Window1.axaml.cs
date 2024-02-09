using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace RegistrationForm;

public partial class Window1 : Window
{
    public Window1(string _name)
    {
        InitializeComponent();
        name.Text = _name;
    }
}