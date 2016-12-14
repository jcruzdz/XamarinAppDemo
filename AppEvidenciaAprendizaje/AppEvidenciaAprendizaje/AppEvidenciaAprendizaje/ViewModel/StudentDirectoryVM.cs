using System.Collections.ObjectModel;
using System.Threading.Tasks;
using AppEvidenciaAprendizaje.Model.Entities;
using AppEvidenciaAprendizaje.Model.Services;
using Xamarin.Forms;

namespace AppEvidenciaAprendizaje.ViewModel
{
    public class StudentDirectoryVM : ObservableBaseObject
    {
        private ObservableCollection<Student> Students { get; set; }
        public ListView LvStudents { get; set; }

        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { isBusy = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// Los comandos funcionan para conectarse con algunos elementos de la vista que
        ///  lo permiten como un botón.
        /// </summary>
        public Command LoadDirectoryCommand { get; set; }

        public StudentDirectoryVM()
        {
            Students = new ObservableCollection<Student>();
            IsBusy = false;
            LoadDirectoryCommand = new Command((obj) => LoadDirectory());
            //LoadDirectory();
        }

        async void LoadDirectory()
        {
            //¿Está ocupada?
            if (!IsBusy)
            {
                IsBusy = true;
                await Task.Delay(3000);
                var loadedDirectory = StudentDirectoryService.LoadStudentDirectory();
                foreach (var student in loadedDirectory.Students)
                {
                    Students.Add(student);
                }
                IsBusy = false;
            }
        }
    }
}