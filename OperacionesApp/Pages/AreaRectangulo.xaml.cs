namespace OperacionesApp.Pages;

public partial class AreaRectangulo : ContentPage
{
	public AreaRectangulo()
	{
		InitializeComponent();
	}

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        if(txtBase.Text == null || txtBase.Text == "")
        {
            Alerta("Debe ingresar un valor para la base");
            return;
        }
        else if (txtAltura.Text == null || txtAltura.Text == "")
        {
            Alerta("Debe ingresar un valor para la altura");
            return;
        }
        else if (txtBase.Text.Contains("-") || txtAltura.Text.Contains("-"))
        {
            Alerta("Debe ingresar un valor positivo");
            return;
        }
        else
        {
            double baseRectangulo, alturaRectangulo, area;
            baseRectangulo = double.Parse(txtBase.Text);
            alturaRectangulo = double.Parse(txtAltura.Text);
            area = baseRectangulo * alturaRectangulo;
            txtResultado.Text = $"El área del rectángulo es: {area}";
        }
    }

    private void btnLimpiar_Clicked(object sender, EventArgs e)
    {
        txtBase.Text = "";
        txtAltura.Text = "";
        txtResultado.Text = "";
        txtBase.Focus();

    }

    private void Alerta(string mensaje)
    {
        DisplayAlert("Error", mensaje, "Aceptar");
    }
}