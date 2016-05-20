using System;

using Xamarin.Forms;
using MvvmLightStart.ViewModel;

namespace MvvmLightStart
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			MainPage = new NavigationPage(new ListPage());
		}

		private static readonly ViewModelLocator _locator = new ViewModelLocator();
		public static ViewModelLocator Locator
		{
			get	{	return _locator;	}
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

