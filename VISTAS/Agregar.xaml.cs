namespace cfvelascoComplementario.VISTAS;

public partial class Agregar : ContentPage
{
	public Agregar()
	{
		InitializeComponent();
	}

    private async void btnAgregar_Clicked(object sender, EventArgs e)
    {

        try
        {
            var httpClient = new HttpClient();
            var parametros = new List<KeyValuePair<string, string>>
        {
            new KeyValuePair<string, string>("nombre", txtNombre.Text),
            new KeyValuePair<string, string>("apellido", txtApellido.Text),
            new KeyValuePair<string, string>("curso", txtCurso.Text),
            new KeyValuePair<string, string>("paralelo", txtParalelo.Text),
            new KeyValuePair<string, string>("notaFinal", txtNotaFinal.Text)
        };

            var content = new FormUrlEncodedContent(parametros);
            var response = await httpClient.PostAsync("http://192.168.17.53:8080/moviles/post.php?codigo=", content);

            if (response.IsSuccessStatusCode)
            {
                await DisplayAlert("Éxito", "Estudiante agregado correctamente", "OK");
                await Navigation.PushAsync(new Inicio());
            }
            else
            {
                await DisplayAlert("Error", "No se pudo agregar el estudiante", "OK");
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", ex.Message, "OK");
        }
    }
}