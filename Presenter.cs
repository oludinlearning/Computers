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

        private void SetViewData(Computers computer)
        {

            if (computer is Notebooks)
            {
                Notebooks temppc = new Notebooks(); 
                temppc = (Notebooks)computer;
            }
            else if (computer is PersonalComputers)
            {
                PersonalComputers temppc = new PersonalComputers();
                temppc = (PersonalComputers)computer;
            }
            else if(computer is Servers)
            {
                Servers temppc = new Servers();
                temppc = (Servers)computer;
            }

            IMainView.SetComputerType(computer.Type);
            if (computer.IsOSOn)
            {
                IMainView.SetComputerOSState("Операционная система запущена");
            }
            else {
                IMainView.SetComputerOSState("Операционная система выключена");
            }

            if (computer.IsPowerOn)
            {
                IMainView.SetComputerPowerstate("Питание подано");
            }
            else
            {
                IMainView.SetComputerPowerstate("Система обесточена");
            }

        }
        public void ShowNotebookData()
        {

            //IMainView.SetComputerType(model.notebook.Type);
            SetViewData(model.notebook);
            //view.OSState.Text = "Состояние операционной системы";
            //view.Powerstate.Text = "Состояние питания";
        }

        public void ShowServerData()
        {
            SetViewData(model.server);
            //IMainView.SetComputerType(model.server.Type);
        }

        public void ShowPCData()
        {
            SetViewData(model.pc);
            //IMainView.SetComputerType(model.pc.Type);
        }
    }
}
