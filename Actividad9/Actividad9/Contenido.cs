﻿using System;
using Xamarin.Forms;

namespace Actividad9
{
	public class Contenido: ContentPage
	{
		public Contenido ()
		{
			Label texto = new Label {
				Text = "Esta es la pagina de contenido!!!",
				TextColor = Color.White
			};

			//Stacklayout permite apilar los controles verticalmente
			StackLayout stackLayout = new StackLayout
			{
				Children =
				{
					texto,

				}
				};


			//Como esta clase hereda de ContentPage, podemos usar estas propiedades directamente
			this.Content = stackLayout;
			this.Padding = new Thickness (5, Device.OnPlatform (20, 5, 5), 5, 5);


		}
	}
}

