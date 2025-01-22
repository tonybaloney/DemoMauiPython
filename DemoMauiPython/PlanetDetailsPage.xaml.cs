using DemoMauiPython.Models;

namespace DemoMauiPython;

public partial class PlanetDetailsPage : ContentPage
{
    public PlanetDetailsPage(Planet planet)
    {
        InitializeComponent();

        BindingContext = planet;
    }

    async void BackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
