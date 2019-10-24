using System;
using System.Windows.Forms;

namespace Computers
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
        }

        public delegate void RadioChecked();
        public event RadioChecked RadioNotebook_Checked;
        public event RadioChecked RadioPC_Checked;
        public event RadioChecked RadioServer_Checked;
        public void SetComputerType(string computerType)
        {
            this.ComputerType.Text = computerType;
        }
        
        private void PowerOn_Click(object sender, EventArgs e)
        {
        }

        private void Shutdown_Button_Click(object sender, EventArgs e)
        {

        }

        private void RadioNotebook_CheckedChanged(object sender, EventArgs e)
        {
            RadioNotebook_Checked();
        }

        private void RadioPC_CheckedChanged(object sender, EventArgs e)
        {
            RadioPC_Checked();
        }

        private void RadioServer_CheckedChanged(object sender, EventArgs e)
        {
            RadioServer_Checked();
        }
    }
}
