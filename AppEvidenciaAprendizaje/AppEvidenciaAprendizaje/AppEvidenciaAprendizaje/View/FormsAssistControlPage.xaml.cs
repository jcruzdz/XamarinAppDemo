using AppEvidenciaAprendizaje.ViewModel;
using Xamarin.Forms;

namespace AppEvidenciaAprendizaje.View
{
    public partial class FormsAssistControlPage : ContentPage
    {
        public FormsAssistControlPage()
        {
            InitializeComponent();
            //Se genera la relación entre la vista y el ViewModel
            this.BindingContext = new StudentDirectoryVM();
        }
    }
}
