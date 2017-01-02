using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Section2Exercise
{
	public partial class QuotesPage : ContentPage
	{
		int x;
		public QuotesPage()
		{
			InitializeComponent();
			quote.Text = GetQuote();
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			quote.Text = GetQuote();
		}

		string GetQuote()
		{
			string quoteText;
			if(x < quotes.Length)
			{
				quoteText = quotes[x];
				x++;
			} 
			else {
				x = 0;
				quoteText = quotes[x];
				x++;
			};

			return quoteText;
		}

		string[] quotes = new string[] { 
			"Right now I’m having amnesia and déjà vu at the same time. I think I’ve forgotten this before." ,
			"What's another word for thesaurus?",
			"I have a hobby. I have the world’s largest collection of sea shells. I keep it scattered on beaches all over the world. Maybe you’ve seen some of it.",
			"I stayed up all night playing poker with tarot cards. I got a full house and four people died.",
			"It was the first time I was ever in love, and I learned a lot. Before that I'd never even thought about killing myself."
		};
	}
}
