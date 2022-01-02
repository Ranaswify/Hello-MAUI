using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;

namespace Hello_MAUI
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void OnButtonClicked(object sender, EventArgs e)
		{
			App.Current.MainPage.DisplayAlert("", "Hello World.", "Okay");

		}
	}
}
