using System;
using System.Collections.Generic;

using Xamarin.Forms;
using MvvmLightStart.ViewModel;

namespace MvvmLightStart
{
	public partial class ListPage : ContentPage
	{
		public ListPage ()
		{
			InitializeComponent ();
			BindingContext = App.Locator.Main;
		}
	}
}

