
namespace RemoteTools.Presentation.WinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TreeNode treeNode2 = new TreeNode("/");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            treeViewConnections = new TreeView();
            contextMenuStrip_ConnectionTreeView = new ContextMenuStrip(components);
            cMenuAddConnection = new ToolStripMenuItem();
            cMenuRemoveConnection = new ToolStripMenuItem();
            notifyIcon = new NotifyIcon(components);
            contextMenuStrip_tray = new ContextMenuStrip(components);
            toolStripMenuItem_Exit = new ToolStripMenuItem();
            panelConnections = new Panel();
            toolStripMenuItem_Settings = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            contextMenuStrip_ConnectionTreeView.SuspendLayout();
            contextMenuStrip_tray.SuspendLayout();
            SuspendLayout();
            // 
            // treeViewConnections
            // 
            treeViewConnections.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            treeViewConnections.Location = new Point(2, 435);
            treeViewConnections.Margin = new Padding(3, 2, 3, 2);
            treeViewConnections.Name = "treeViewConnections";
            treeNode2.Name = "node_root";
            treeNode2.Text = "/";
            treeViewConnections.Nodes.AddRange(new TreeNode[] { treeNode2 });
            treeViewConnections.Size = new Size(255, 118);
            treeViewConnections.TabIndex = 0;
            treeViewConnections.MouseClick += treeView1_MouseClick;
            // 
            // contextMenuStrip_ConnectionTreeView
            // 
            contextMenuStrip_ConnectionTreeView.ImageScalingSize = new Size(20, 20);
            contextMenuStrip_ConnectionTreeView.Items.AddRange(new ToolStripItem[] { cMenuAddConnection, cMenuRemoveConnection });
            contextMenuStrip_ConnectionTreeView.Name = "contextMenuStrip1";
            contextMenuStrip_ConnectionTreeView.Size = new Size(148, 48);
            // 
            // cMenuAddConnection
            // 
            cMenuAddConnection.Name = "cMenuAddConnection";
            cMenuAddConnection.Size = new Size(147, 22);
            cMenuAddConnection.Text = "+ Connection";
            cMenuAddConnection.Click += cMenuAddConnection_Click;
            // 
            // cMenuRemoveConnection
            // 
            cMenuRemoveConnection.Name = "cMenuRemoveConnection";
            cMenuRemoveConnection.Size = new Size(147, 22);
            cMenuRemoveConnection.Text = "- Connection";
            // 
            // notifyIcon
            // 
            notifyIcon.ContextMenuStrip = contextMenuStrip_tray;
            notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "CpRemote";
            notifyIcon.Visible = true;
            // 
            // contextMenuStrip_tray
            // 
            contextMenuStrip_tray.ImageScalingSize = new Size(20, 20);
            contextMenuStrip_tray.Items.AddRange(new ToolStripItem[] { toolStripMenuItem_Settings, toolStripSeparator1, toolStripMenuItem_Exit });
            contextMenuStrip_tray.Name = "contextMenuStrip_tray";
            contextMenuStrip_tray.Size = new Size(126, 54);
            // 
            // toolStripMenuItem_Exit
            // 
            toolStripMenuItem_Exit.Name = "toolStripMenuItem_Exit";
            toolStripMenuItem_Exit.Size = new Size(180, 22);
            toolStripMenuItem_Exit.Text = "Exit";
            toolStripMenuItem_Exit.Click += toolStripMenuItem_Exit_Click;
            // 
            // panelConnections
            // 
            panelConnections.AutoSize = true;
            panelConnections.BackColor = SystemColors.ActiveCaption;
            panelConnections.ContextMenuStrip = contextMenuStrip_ConnectionTreeView;
            panelConnections.Dock = DockStyle.Fill;
            panelConnections.Location = new Point(0, 0);
            panelConnections.Name = "panelConnections";
            panelConnections.Size = new Size(415, 617);
            panelConnections.TabIndex = 2;
            // 
            // toolStripMenuItem_Settings
            // 
            toolStripMenuItem_Settings.Name = "toolStripMenuItem_Settings";
            toolStripMenuItem_Settings.Size = new Size(180, 22);
            toolStripMenuItem_Settings.Text = "Settings...";
            toolStripMenuItem_Settings.Click += toolStripMenuItem_Settings_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 617);
            Controls.Add(panelConnections);
            Controls.Add(treeViewConnections);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "MainForm";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            contextMenuStrip_ConnectionTreeView.ResumeLayout(false);
            contextMenuStrip_tray.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeViewConnections;
        private ContextMenuStrip contextMenuStrip_ConnectionTreeView;
        private ToolStripMenuItem cMenuAddConnection;
        private ToolStripMenuItem cMenuRemoveConnection;
        private NotifyIcon notifyIcon;
        private ContextMenuStrip contextMenuStrip_tray;
        private ToolStripMenuItem toolStripMenuItem_Exit;
        private Panel panelConnections;
        private ToolStripMenuItem toolStripMenuItem_Settings;
        private ToolStripSeparator toolStripSeparator1;
    }
}