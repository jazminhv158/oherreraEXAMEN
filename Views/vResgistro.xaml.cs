namespace oherreraEXAMEN.Views
{
    public partial class vResgistro : ContentPage
    {

        //VARIABLES GLOBALES
        string usuarioGlobal;
        string contrasenaGlobal;



        private const double costoCurso = 1500.0;

        public vResgistro()
        {
            InitializeComponent();
        }

        public vResgistro(string usuario, string contrasena)
        {
            InitializeComponent();
            usuarioGlobal = usuario;
            contrasenaGlobal = contrasena;

            lblSaludo.Text = $"Bienvenido {usuario}";


        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(txtPagoInicial.Text))
                {
                    DisplayAlert("Error", "Ingrese el valor de inscripción.", "OK");
                    return;
                }

                double pagoInicial = double.Parse(txtPagoInicial.Text);

                if (pagoInicial >= costoCurso)
                {
                    DisplayAlert("Aviso", "El pago inicial no puede ser igual o mayor al costo del curso.", "OK");
                    return;
                }

 
                double saldoRestante = costoCurso - pagoInicial;

             
                double cuotaBase = saldoRestante / 4;

                double cuotaConInteres = cuotaBase + (cuotaBase * 0.04);

                
                double totalAPagar = (cuotaConInteres * 4) + pagoInicial;

              
                lblResultado.Text = $"Resultado:\n\n" +
                    $"Costo del curso: ${costoCurso:F2}\n" +
                    $"Pago inicial: ${pagoInicial:F2}\n" +
                    $"Saldo restante: ${saldoRestante:F2}\n" +
                    $"Cuota mensual (4% interés): ${cuotaConInteres:F2}\n" +
                    $"Total final (incluyendo inscripción): ${totalAPagar:F2}";
            }
            catch
            {
                DisplayAlert("Error", "Ingrese valores numéricos válidos.", "OK");
            }
        }

        private void btnEnviar_Clicked(object sender, EventArgs e)
        {


        }
    }
}