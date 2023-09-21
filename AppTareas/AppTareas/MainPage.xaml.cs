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
			if (double.TryParse(valor, out double entra))
			{
				string selectedOption = opciones.Items[opciones.SelectedIndex];
				string resultMessage = string.Empty;

				switch (selectedOption)
				{
					case "Peso":
						double libras = entra * 2.20462;
						resultMessage = $"{entra} Kilos en libras son: {libras} libras";
						break;

					case "Volumen":
						double galones = entra / 3.78541;
						resultMessage = $"{entra} litros en galones son: {galones} galones";
						break;

					case "Temperatura":
						double grados = (entra * 9 / 5) + 32;
						resultMessage = $"{entra} grados C° en grados F° son: {grados} grados F°";
						break;

					default:
						resultMessage = "Seleccione una opción válida.";
						break;
				}

				DisplayAlert("Conversión", resultMessage, "Aceptar");
			}
			else
			{
				DisplayAlert("Error", "Ingrese un valor numérico válido.", "Aceptar");
			}
		}
	}
}
