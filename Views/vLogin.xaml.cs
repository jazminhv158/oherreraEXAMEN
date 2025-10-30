namespace oherreraEXAMEN.Views;

public partial class vLogin : ContentPage
{

    private readonly Dictionary<string, string> usuariosValidos = new()
    {
        {"estudiante","moviles" },
        {"uisrael","2025" }
    };
    public vLogin()
	{
		InitializeComponent();
	}

    private async void btnIngresar_Clicked_1(object sender, EventArgs e)
    {
        try
        {
            string usuario = txtUsuario.Text?.Trim();
            string contrasena = txtContrasena.Text?.Trim();


            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                DisplayAlert("Error", "Debe ingresar usuario y contraseña", "OK");
                return;
            }


            if (usuariosValidos.TryGetValue(usuario, out string passwordCorrecto) && passwordCorrecto == contrasena)
            {

                Navigation.PushAsync(new vResgistro(usuario, contrasena));

            }
            else
            {
                await DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error en login: {ex.Message}");

        }

    }
}