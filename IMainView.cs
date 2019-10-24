using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{
    interface IMainView
    {
        void SetComputerType(string type);
        event MainView.RadioChecked RadioNotebook_Checked;
        event MainView.RadioChecked RadioPC_Checked;
        event MainView.RadioChecked RadioServer_Checked;
    }
}
