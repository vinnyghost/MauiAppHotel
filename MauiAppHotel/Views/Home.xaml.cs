using MauiAppHotel.Views;

namespace MauiAppHotel;

public partial class Home : ContentPage
{
    public Home()
    {
        InitializeComponent();
    }
            private async void OnComecarClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ContratacaoHospedagem());
    }
}