using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;

namespace AppTareas
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
		private void Convertir(object sender, EventArgs e)
		{
			string valor = entrada.Text;
			double entra = Convert.ToInt32(valor);
			opciones.SelectedIndexChanged += (s, args) =>
			{
				if (opciones.SelectedIndex != -1)
				{
					string selectedOption = opciones.Items[opciones.SelectedIndex];
					if (selectedOption == "Peso")
					{
						double libras = entra * 2.20462;
						DisplayAlert("Conversión", $"{entra} Kilos en libras son : {libras} libras", "Aceptar");
					}
					else if (selectedOption == "Volumen")
					{
						double galones = entra / 3.78541;
						DisplayAlert("Conversión", $"{entra} litros en galones son : {galones} galones", "Aceptar");

					}
					else if (selectedOption == "Temperatura")
					{
						double grados = (entra * 9 / 5) + 32;
						DisplayAlert("Conversión", $"{entra} grados C° en grados F° son : {grados} centigrados", "Aceptar");
					}
					else
					{
						DisplayAlert("Error", $"Hubo un error", "Aceptar");
					}
				}
			};
		}

	}
}
