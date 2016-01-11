using System;
using Xamarin.Forms;
using Marioneta;

namespace CodecampSDQ2016
{
	public class SessionViewCell : ViewCell
	{
		public SessionViewCell ()
		{
			View = CreateView();
		}

		View CreateView ()
		{
			var builder = new RelativeBuilder();

			var charlista = new Label
			{
				FontAttributes = FontAttributes.Bold,
				FontSize = 18,
				TextColor = Color.Black
			};

			charlista.SetBinding<Session>(Label.TextProperty, m => m.Charlista);

			var sessionName = new Label
			{
				TextColor = Color.Black,
				FontSize = 14
			};

			var sessionNameContainer = new StackLayout
			{
				Padding = new Thickness(0,0,16,0),
				Children = 
				{
					sessionName
				}
			};

			sessionName.SetBinding<Session>(Label.TextProperty, m => m.Charla);

			var lugar = new Label
			{
				TextColor = Color.FromHex("3498db")
			};

			lugar.SetBinding<Session>(Label.TextProperty, m => m.Lugar);

			var hora = new Label
			{
				TextColor = Color.FromHex("3498db"),
				FontSize = 14
			};

			hora.SetBinding<Session>(Label.TextProperty, m => m.HoraInicio);

			builder
				.AddView(charlista)
				.WithPadding(new Thickness(16,12,0,4));
			
			builder
				.AddView(sessionNameContainer)
				.BelowOf(charlista)
				.ExpandViewToParentWidth()
				.AlignLeft(charlista)
				.WithPadding(new Thickness(0,8,0,0));

			builder
				.AddView(lugar)
				.BelowOf(sessionNameContainer)
				.AlignLeft(sessionNameContainer)
				.WithPadding(new Thickness(0,10,0,0));
			
			builder
				.AddView(hora)
				.AlignTop(lugar)
				.AlignParentRight()
				.WithPadding(new Thickness(0,4,16,0));

			return builder
				.ApplyConfiguration((p,v)=>{
					p.Padding = new Thickness(10);
			}).BuildLayout();
		}
	}
}

