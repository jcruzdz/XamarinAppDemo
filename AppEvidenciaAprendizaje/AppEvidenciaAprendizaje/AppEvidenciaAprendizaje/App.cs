using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppEvidenciaAprendizaje.View;
using Xamarin.Forms;

namespace AppEvidenciaAprendizaje
{
    public class App : Application
    {
        public App()
        {
            //Aquí sigue siendo la raíz "FormsAssistControlPage".
            //Se implementó un Navigation Page para poder cambiar de vista.
            MainPage = new NavigationPage(new FormsAssistControlPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
