namespace Practica11;

public partial class Dino : ContentPage
{
	public Dino()
	{
		InitializeComponent();
	}

    private void Convertir_Clicked(object sender, EventArgs e)
        //Este es un boton para convertir todo los datos que le piden a la
        //persona en el formulario 
    {
        if(!string.IsNullOrEmpty(entry1.Text) && !string.IsNullOrEmpty(entry2.Text))
        {
            //En este còdigo se establecen las variables y a que entry van a pertenecer las variable
            //Luego de eso se le proporciona las formulas 
            // Luego desde el entr3 le colocamos las respectivas variables juntas para formar la respuesta 
            double ResPeso, ResAltu, Peso, Altu;
            string nombre;
            Peso = Convert.ToDouble(entry1.Text);
            Altu = Convert.ToDouble(entry2.Text);
            nombre = entry.Text;
            ResPeso = (Peso * 2.2046);
            ResAltu = (Altu * 100);
            entry3.Text = nombre + ".   " + "Peso: " + ResPeso.ToString() + "Lb" + "   " + "Altura: " + ResAltu + "cm";
        }
        else
        {
            DisplayAlert("Error", "Introduce todos los numeros", "Ok");
        }
    }

    //<summary>
    //<createddate> 27/06/2024 </createddate>
    //<company> Dino6796008 </company>
    //<lastmodificationdate> 27/06/2024 </lastmodificationdate>
    //<lastmodificationdescription></lastmodificationdescription>
    //<lastmodifierautor> Jemima Arenivar  </lastmodifierautor>
    //</summary>

}