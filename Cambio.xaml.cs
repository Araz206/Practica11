namespace Practica11;

public partial class Cambio : ContentPage
{
	public Cambio()
	{
		InitializeComponent();
	}

    //<summary> Define un método que se ejecuta cuando se hace clic en un botón </summary>
    private void Button_Clicked(object sender, EventArgs e)
    {
        //<summary> Obtiene los textos ingresados en CostoArticuloEntry y DineroEntregadoEntry </summary>
        string costoArticuloText = CostoArticuloEntry.Text;
        string dineroEntregadoText = DineroEntregadoEntry.Text;

        //<summary> Intenta convertir los textos costoArticuloText y dineroEntregadoText a números (double). Si ambas conversiones son exitosas, sigue </summary>
        if (double.TryParse(costoArticuloText, out double costoArticulo) &&
            double.TryParse(dineroEntregadoText, out double dineroEntregado))
        {
            //<summary> Calcula el cambio restando el costo del artículo del dinero entregado </summary>
            double cambio = dineroEntregado - costoArticulo;

            if (cambio >= 0)
            {
                //<summary> Si el cambio es mayor o igual a 0, muestra el cambio en ResultadoLabel con dos decimales </summary>
                ResultadoLabel.Text = $"El cambio es: ${cambio:F2}";
            }
            else
            {
                //<summary> Si el cambio es negativo, muestra un mensaje indicando que el dinero entregado no es suficiente </summary>
                ResultadoLabel.Text = "El dinero entregado no es suficiente.";

            }
        }
        else
        {
            //<summary> Si alguna conversión falla, muestra un mensaje indicando que se deben ingresar valores válidos </summary>
            ResultadoLabel.Text = "Por favor ingrese valores validos.";
        }




    }


    //<summary>
    //<createddate> 27/06/2024 </createddate>
    //<company> CambioCliente5003073 </company>
    //<lastmodificationdate> 27/06/2024 </lastmodificationdate>
    //<lastmodificationdescription></lastmodificationdescription>
    //<lastmodifierautor> Lorena Lisseth </lastmodifierautor>
    //</summary>
}

