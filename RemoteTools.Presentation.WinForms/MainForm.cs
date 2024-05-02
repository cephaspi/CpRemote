using Serilog;
using System;
 using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteTools.Presentation.WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {
            treeViewConnections.ContextMenuStrip = contextMenuStrip_ConnectionTreeView;
        }

        private void cMenuAddConnection_Click(object sender, EventArgs e)
        {
            if (treeViewConnections.SelectedNode != null)
            {
                treeViewConnections.SelectedNode.Nodes.Add("nnode");
                treeViewConnections.ExpandAll();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.MainForm_position = Location;
            Properties.Settings.Default.Main_Form_size = Size;
            Properties.Settings.Default.Save();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Location = Properties.Settings.Default.MainForm_position;
            Size = Properties.Settings.Default.Main_Form_size;
        }
        private void notifyIcon_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;

            var mi = typeof(NotifyIcon).GetMethod("ShowContextMenu",
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            if (mi != null) mi.Invoke(notifyIcon, null);
        }

        private void toolStripMenuItem_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem_Settings_Click(object sender, EventArgs e)
        {
            var setForm = new SettingsForm();
            setForm.ShowDialog();
        }
    }
}
