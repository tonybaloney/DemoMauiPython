using CSnakes.Runtime;
using DemoMauiPython.Models;

namespace DemoMauiPython;

public partial class PlanetDetailsPage : ContentPage
{
    public PlanetDetailsPage(Planet planet, IPythonEnvironment pythonEnvironment)
    {
        InitializeComponent();
        planet.SpacePlotter = pythonEnvironment.SpacePlotter(); // TODO : Find a better way to link the resources

        // Get the background color of the page
        planet.SpacePlotter.SetTheme(BackgroundColor.ToHex());

        BindingContext = planet;
    }

    async void BackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
