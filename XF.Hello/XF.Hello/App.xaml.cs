using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace XF.Hello
{
	public partial class App : Application
	{
        public static Configuracao config { get; set; }
		public App ()
		{
            if (config == null) config = new Configuracao();

			InitializeComponent();

			MainPage = new NavigationPage(new MainPage());
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
