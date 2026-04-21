namespace achicaizaS2.Views;

public partial class vPrincipal : ContentPage
{
	public vPrincipal()
	{
		InitializeComponent();
	}

    private async void btnSeleccionar_Clicked(object sender, EventArgs e)
    {
        if (pPaises.SelectedItem == null)
        {
            await DisplayAlert("Error", "Debe seleccionar un país", "OK");
            return;
        }

        string dato = pPaises.SelectedItem.ToString();
        await DisplayAlert("Pais seleccionado", dato, "Cerrar");
    }
}