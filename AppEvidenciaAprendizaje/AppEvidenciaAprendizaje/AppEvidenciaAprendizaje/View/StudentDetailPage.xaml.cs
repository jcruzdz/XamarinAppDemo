using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppEvidenciaAprendizaje.Model.Entities;
using Xamarin.Forms;

namespace AppEvidenciaAprendizaje.View
{
    public partial class StudentDetailPage : ContentPage
    {
        public StudentDetailPage(Student selectedStudent)
        {
            InitializeComponent();
            this.BindingContext = selectedStudent;
        }
    }
}
