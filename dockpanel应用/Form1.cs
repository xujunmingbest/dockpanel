using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace dockpanel应用
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dockPanel1_ActiveContentChanged(object sender, EventArgs e)
        {

            /*
            DockPanelFormSide dockPanelSideLeft = new DockPanelFormSide();
            dockPanelSideLeft.Show(this.dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.DockLeft);
            dockPanelSideLeft.Text = "DockPanelLeft";

            DockPanelFormSide dockPanelSideRight = new DockPanelFormSide();
            dockPanelSideRight.Show(this.dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.DockRight);
            dockPanelSideRight.Text = "DockPanelRight";

            DockPanelFormSide dockPanelSideBottom = new DockPanelFormSide();
            dockPanelSideBottom.ShowDialog(this.dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.DockBottom);
            dockPanelSideBottom.Text = "DockPanelBottom";
            */
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DockPanelFormMain dockPanelMain1 = new DockPanelFormMain();
            dockPanelMain1.Show(this.dockPanel1);
            dockPanelMain1.Text = "MainPanel1";

            DockPanelFormMain dockPanelMain2 = new DockPanelFormMain();
            dockPanelMain2.Show(this.dockPanel1);
            dockPanelMain2.Text = "MainPanel2";

            DockPanelFormSide dockPanelSideLeft = new DockPanelFormSide();
            dockPanelSideLeft.Show(this.dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.DockLeft);
            dockPanelSideLeft.Text = "DockPanelLeft";

            DockPanelFormSide dockPanelSideRight = new DockPanelFormSide();
            dockPanelSideRight.Show(this.dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.DockRight);
            dockPanelSideRight.Text = "DockPanelRight";

            DockPanelFormSide dockPanelSideBottom = new DockPanelFormSide();
            dockPanelSideBottom.Show(this.dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.DockBottom);
            dockPanelSideBottom.Text = "DockPanelBottom";
        }
    }
}
