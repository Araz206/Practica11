namespace Practica11;

public partial class Gasolina : ContentPage
{
    private const double PrecioLitros = 2.00;

    public Gasolina()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (double.TryParse(GalonesEntry.Text, out double _galones))
        {
            //Conservasión de galones a litros (1 galón = 3.78541 litror)
            double litros = _galones * 3.78542;
            //Calculo del monto a cobrar
            double MontoACobrar = litros * PrecioLitros;

            LabMontoAcobrar.Text = $"Monto a Cobrar: ${MontoACobrar:F2}";
        }

    }

    //<summary>
    //<createddate> 3/07/2024 </createddate>
    //<company> Gasolinera ejercicio 4 </company>
    //<lastmodificationdate> 5/07/2024</lastmodificationdate>
    //<lastmodificationdescription></lastmodificationdescription>
    //<lastmodifierautor> Brandon Valladares </lastmodifierautor>
    //</summary
}