﻿using System;
using Xamarin.Forms;

namespace Actividad7
{
	public class Pagina2: ContentPage
	{
		public Pagina2 ()
		{
			Label texto = new Label {
				Text = "Página 2",
				TextColor = Color.Green
			};

			Button boton2 = new Button
			{
				Text = "Click para navegar a la página3",
			};

			boton2.Clicked += (sender, e) => {
				this.Navigation.PushAsync(new Pagina3());

			};

			//Stacklayout permite apilar los controles verticalmente
			StackLayout stackLayout = new StackLayout
			{
				Children =
				{
					texto,
					boton2
				}
			};


			//Como esta clase hereda de ContentPage, podemos usar estas propiedades directamente
			this.Content = stackLayout;
			this.Padding = new Thickness (5, Device.OnPlatform (20, 5, 5), 5, 5);
		}
	}
}

