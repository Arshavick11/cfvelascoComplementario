namespace cfvelascoComplementario.VISTAS;

public partial class loging : ContentPage
{

    int count = 0;
    String[] usuarios = { "estudiante2024", "examen1", "Cristian" };
    String[] contrasenia = { "uisrael2024", "parcial1", "2024" };

    public loging()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        String usuario = usu.Text;

        if (usuarios.Contains(usu.Text))
            if (contrasenia.Contains(con.Text))
            {
                DisplayAlert("Incio de sesion", "Bienvenido", "OK");
                Navigation.PushAsync(new VISTAS.Inicio());
                usu.Text = "";
                con.Text = "";
            }
            else
            {
                DisplayAlert("Error", "Usuario o Contraseña Incorrecta", "OK");
            }

        SemanticScreenReader.Announce(CounterBtn.Text);
    }

    private void Acerca_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Acerca de la App", "Aplicacion creada por Cristian Velasco", "OK");
    }
}
