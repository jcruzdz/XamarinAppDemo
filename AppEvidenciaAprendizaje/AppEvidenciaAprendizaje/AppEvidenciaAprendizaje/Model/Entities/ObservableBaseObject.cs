using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AppEvidenciaAprendizaje.Model.Entities
{
    public class ObservableBaseObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate
        {

        };

        /// <summary> 
        /// CallerMemberName obtiene el nombre de la propiedad que lo invocó.
        /// </summary>
        /// <param name="name"></param>
        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            if (PropertyChanged == null)
            {
                return;
            }

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}