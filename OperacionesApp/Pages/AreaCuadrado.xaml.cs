namespace OperacionesApp.Pages;

public partial class AreaCuadrado : ContentPage
{
    public AreaCuadrado()
	{
		InitializeComponent();
	}

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        if (txtLado.Text == null || txtLado.Text == "")
        {
            Alerta("Debe ingresar un valor para el lado");
            return;

        } else if (txtLado.Text.Contains("-"))
        {

            Alerta("Debe ingresar un valor positivo");
            return;

        }
        else
        {
            double lado, area;
            lado = double.Parse(txtLado.Text);
            area = lado * lado;
            txtResultado.Text = $"El área del cuadrado es: {area}";
        }

    }

    private void btnLimpiar_Clicked(object sender, EventArgs e)
    {
        txtLado.Text = "";
        txtResultado.Text = "";
        txtLado.Focus();
    }

    private void Alerta(string mensaje)
    {
        DisplayAlert("Error", mensaje, "Aceptar");
    }
}