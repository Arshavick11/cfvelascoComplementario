using cfvelascoComplementario.Modelos;
using System;
using System.Net;
using System.Threading.Tasks;

namespace cfvelascoComplementario.VISTAS;

public partial class ActualizarEliminar : ContentPage
{
    private Estudiante datos;

    public ActualizarEliminar(Estudiante datos)
    {
        InitializeComponent();
        this.datos = datos;
        lblCodigo.Text = datos.codigo.ToString();
        txtNombre.Text = datos.nombre;
        txtApellido.Text = datos.apellido;
        txtCurso.Text = datos.curso;
        txtParalelo.Text = datos.paralelo;
        txtNotaFinal.Text = datos.notaFinal.ToString();

    }

    private void btnActualizar_Clicked(object sender, EventArgs e)
    {
        try
        {
            string codigo = lblCodigo.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string curso = txtCurso.Text;
            string paralelo = txtParalelo.Text;
            string notaFional = txtNotaFinal.Text;

            string url = "http://192.168.17.53:8080/moviles/post.php?codigo=" + codigo + "&nombre=" + nombre + "&apellido=" + apellido + "&curso=" + curso + "&paralelo=" + paralelo + "&notaFinal=" + notaFional;
            WebClient cliente = new WebClient();
            var parametros = new System.Collections.Specialized.NameValueCollection();
            cliente.UploadValues(url, "PUT", parametros);
            Navigation.PushAsync(new Inicio());
        }
        catch (Exception ex)
        {
            DisplayAlert("ERROR", ex.Message, "CERRAR");
        }
    }

    private void btnEliminar_Clicked(object sender, EventArgs e)
    {
        try
        {
            string codigo = lblCodigo.Text;

            string url = "http://192.168.17.53:8080/moviles/post.php?codigo=" + codigo;
            WebClient cliente = new WebClient();
            var parametros = new System.Collections.Specialized.NameValueCollection();
            cliente.UploadValues(url, "DELETE", parametros);
            Navigation.PushAsync(new Inicio());
        }
        catch (Exception ex)
        {
            DisplayAlert("ERROR", ex.Message, "CERRAR");
        }
    }
}