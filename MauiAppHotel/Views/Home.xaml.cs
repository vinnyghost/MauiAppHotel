using MauiAppHotel.Views; // Adiciona a diretiva 'using' para acessar a pasta Views

namespace MauiAppHotel; // Use o namespace correto do seu arquivo Home
// Se Home também estiver na pasta Views, mude para: namespace MauiAppHotel.Views;

public partial class Home : ContentPage
{
    public Home()
    {
        InitializeComponent();
    }

    // Este é o método chamado quando o botão "Começar Agora" é clicado
    private async void OnComecarClicked(object sender, EventArgs e)
    {
        // Navega para a sua tela de cálculo de diária, usando o nome da classe exato.
        await Navigation.PushAsync(new ContratacaoHospedagem());
    }
}