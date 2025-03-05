namespace OperacionesApp.Pages;

public partial class AreaCirculo : ContentPage
{
	public AreaCirculo()
	{
		InitializeComponent();
	}

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        if(txtRadio.Text == null || txtRadio.Text == "")
        {
            Alerta("Debe ingresar un valor para el radio");
            return;
        }
        else if (txtRadio.Text.Contains("-"))
        {
            Alerta("Debe ingresar un valor positivo");
            return;
        }
        else
        {
            double radio, area;
            radio = double.Parse(txtRadio.Text);
            area = Math.PI * Math.Pow(radio, 2);
            txtResultado.Text = $"El área del círculo es: {area}";
        }
    }

    private void btnLimpiar_Clicked(object sender, EventArgs e)
    {
        txtRadio.Text = "";
        txtResultado.Text = "";
        txtRadio.Focus();

    }

    private void Alerta(string mensaje)
    {
        DisplayAlert("Error", mensaje, "Aceptar");
    }
}