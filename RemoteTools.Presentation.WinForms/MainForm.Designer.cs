
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
            TreeNode treeNode1 = new TreeNode("/");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            treeViewConnections = new TreeView();
            contextMenuStripConnectionTreeView = new ContextMenuStrip(components);
            cMenuAddConnection = new ToolStripMenuItem();
            cMenuRemoveConnection = new ToolStripMenuItem();
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStripConnectionTreeView.SuspendLayout();
            SuspendLayout();
            // 
            // treeViewConnections
            // 
            treeViewConnections.Dock = DockStyle.Fill;
            treeViewConnections.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            treeViewConnections.Location = new Point(0, 0);
            treeViewConnections.Name = "treeViewConnections";
            treeNode1.Name = "node_root";
            treeNode1.Text = "/";
            treeViewConnections.Nodes.AddRange(new TreeNode[] { treeNode1 });
            treeViewConnections.Size = new Size(296, 752);
            treeViewConnections.TabIndex = 0;
            treeViewConnections.MouseClick += treeView1_MouseClick;
            // 
            // contextMenuStripConnectionTreeView
            // 
            contextMenuStripConnectionTreeView.ImageScalingSize = new Size(20, 20);
            contextMenuStripConnectionTreeView.Items.AddRange(new ToolStripItem[] { cMenuAddConnection, cMenuRemoveConnection });
            contextMenuStripConnectionTreeView.Name = "contextMenuStrip1";
            contextMenuStripConnectionTreeView.Size = new Size(168, 52);
            // 
            // cMenuAddConnection
            // 
            cMenuAddConnection.Name = "cMenuAddConnection";
            cMenuAddConnection.Size = new Size(167, 24);
            cMenuAddConnection.Text = "+ Connection";
            cMenuAddConnection.Click += cMenuAddConnection_Click;
            // 
            // cMenuRemoveConnection
            // 
            cMenuRemoveConnection.Name = "cMenuRemoveConnection";
            cMenuRemoveConnection.Size = new Size(167, 24);
            cMenuRemoveConnection.Text = "- Connection";
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 752);
            Controls.Add(treeViewConnections);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "MainForm";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            contextMenuStripConnectionTreeView.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeViewConnections;
        private ContextMenuStrip contextMenuStripConnectionTreeView;
        private ToolStripMenuItem cMenuAddConnection;
        private ToolStripMenuItem cMenuRemoveConnection;
        private NotifyIcon notifyIcon1;
    }
}