namespace achicaizaS2.Views;

public partial class vlogin : ContentPage
{
	public vlogin()
	{
		InitializeComponent();
	}

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new Views.vPrincipal();
    }
}