using AppEvidenciaAprendizaje.Storage;

namespace AppEvidenciaAprendizaje.Model.Entities
{
    public class Student : ObservableBaseObject, IKeyObject
    {
        //Implementación de la intefaz IKeyObject, es necesaria para utilizar SQLite.
        public string Key { get; set; }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }
        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; OnPropertyChanged(); }
        }

        private string group;
        public string Group
        {
            get { return group; }
            set { group = value; OnPropertyChanged(); }
        }

        private string studentNumber;
        public string StudentNumber
        {
            get { return studentNumber; }
            set { studentNumber = value; OnPropertyChanged(); }
        }

        public double average;
        public double Average
        {
            get { return average; }
            set { average = value; OnPropertyChanged(); }
        }
    }
}
