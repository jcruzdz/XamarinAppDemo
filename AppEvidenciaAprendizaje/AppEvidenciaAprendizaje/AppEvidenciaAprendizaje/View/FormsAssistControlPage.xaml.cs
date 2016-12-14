using AppEvidenciaAprendizaje.Model.Entities;
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
            LvStudents.ItemSelected += LvStudents_ItemSelected;
        }

        void LvStudents_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Student selectetedStudent = (Student)e.SelectedItem;
            if (selectetedStudent == null)
                return;
            Navigation.PushAsync(new StudentDetailPage(selectetedStudent));
            LvStudents.SelectedItem = null;
        }
    }
}
