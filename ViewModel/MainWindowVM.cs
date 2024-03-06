using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMvvmSample.Model.DTO;

namespace WpfMvvmSample.ViewModel
{
    public class MainWindowVM  : BaseVM
    {
        private Woman newWoman;

        public Woman NewWoman
        {
            get => newWoman;
            set
            {
                newWoman = value;
                Signal();
            }
        }

        public CommandVM AddWoman { get; }

        public ObservableCollection<Woman> Women { get; set; } 

        public MainWindowVM()
        {
            AddWoman = new CommandVM(() => {
                Women.Add(newWoman);
                NewWoman = new Woman();
            });
            Women = new();
            
            NewWoman = new Woman();
        }
    }
}
