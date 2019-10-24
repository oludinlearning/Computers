using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{
    class Presenter : IPresenter
    {
        Model model;
        IMainView IMainView;
        public Presenter(IMainView IView) {
            IMainView = IView;
            model = new Model();
            IMainView.RadioNotebook_Checked += this.ShowNotebookData;
            IMainView.RadioPC_Checked += this.ShowPCData;
            IMainView.RadioServer_Checked += this.ShowServerData;

        }

        
        public void ShowNotebookData()
        {

            IMainView.SetComputerType(model.notebook.Type);
            //view.OSState.Text = "Состояние операционной системы";
            //view.Powerstate.Text = "Состояние питания";
        }

        public void ShowServerData()
        {
            IMainView.SetComputerType(model.server.Type);
        }

        public void ShowPCData()
        {
            IMainView.SetComputerType(model.pc.Type);
        }
    }
}
