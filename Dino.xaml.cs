namespace Practica11;

public partial class Dino : ContentPage
{
	public Dino()
	{
		InitializeComponent();
	}

    private void Convertir_Clicked(object sender, EventArgs e)
    {
        if(!string.IsNullOrEmpty(entry1.Text) && !string.IsNullOrEmpty(entry2.Text))
        {
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
   
}