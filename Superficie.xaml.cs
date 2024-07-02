namespace Practica11;

public partial class Superficie : ContentPage
{
	public Superficie()
	{
		InitializeComponent();
	}

    ///<summary> Define un m�todo que se ejecuta al hacer clic en un bot�n </summary>
    private void Button_Clicked(object sender, EventArgs e)
    {

        //<Sumary> intenta convertir los textos baseEntry.Text y HeighEntry.Text a double. Si ambas conversiones son exitosas, contin�a </Sumary>
        if (double.TryParse(baseEntry.Text, out double baseValue) && double.TryParse(HeighEntry.Text, out double heighValue))
        {
            //<summary> Calcula el �rea del tri�ngulo y muestra el resultado en resultLabel  </summary>
            double area = (baseValue * heighValue) / 2;
            resultLabel.Text = $"El area del triangulo es: {area}";
        }
        else
        {
            //<summary> Si alguna conversi�n falla, muestra un mensaje de error en resultLabel </summary>
            resultLabel.Text = "Por favor, ingrese valores validos para la base y la altura.";
        }



    }


    //<summary>
    //<createddate> 26/06/2024 </createddate>
    //<company> Superficie5003073 </company>
    //<lastmodificationdate> 26/06/2024 </lastmodificationdate>
    //<lastmodificationdescription></lastmodificationdescription>
    //<lastmodifierautor> Lorena Lisseth </lastmodifierautor>
    //</summary>
}


