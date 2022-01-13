using System;
using CodeSnippets.XamlAndMvvm;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

namespace MauiApp1
{
	//<SetBindingContext>
	public partial class MainView : ContentPage
	{
		public MainView()
		{
			InitializeComponent();

			BindingContext = new MainViewModel();
		}
	}
	//</SetBindingContext>
}