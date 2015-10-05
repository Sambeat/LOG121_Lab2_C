using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class CommBase : INotifyPropertyChanged
    {
        private const int DELAI = 200;
        private ServerConnection serverConnection;
        private static CommBase commBaseInstance = null;

        public event PropertyChangedEventHandler PropertyChanged;

        public CommBase()
        {

        }



        
    }
}
