using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{
    class Model
    {
        public Notebooks notebook = new Notebooks();
        public Servers server = new Servers();
        public PersonalComputers pc = new PersonalComputers();

        IComputerActions<Notebooks> INotebookAction;
        IComputerActions<PersonalComputers> IPCAction;
        IComputerActions<Servers> IServerAction;

        
    }
}
