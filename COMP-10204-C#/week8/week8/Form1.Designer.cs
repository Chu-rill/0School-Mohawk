namespace week8
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.colorEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutHelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.redColorEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.greenColorEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.blueColorEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileMenu,
            this.saveFileMenu,
            this.saveAsFileMenu,
            this.exitFileMenu});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorEditMenu});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutHelpMenu});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // openFileMenu
            // 
            this.openFileMenu.Name = "openFileMenu";
            this.openFileMenu.Size = new System.Drawing.Size(180, 22);
            this.openFileMenu.Text = "Open";
            // 
            // colorEditMenu
            // 
            this.colorEditMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redColorEditMenu,
            this.greenColorEditMenu,
            this.blueColorEditMenu});
            this.colorEditMenu.Name = "colorEditMenu";
            this.colorEditMenu.Size = new System.Drawing.Size(180, 22);
            this.colorEditMenu.Text = "Color";
            // 
            // aboutHelpMenu
            // 
            this.aboutHelpMenu.Name = "aboutHelpMenu";
            this.aboutHelpMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutHelpMenu.Size = new System.Drawing.Size(180, 22);
            this.aboutHelpMenu.Text = "About";
            this.aboutHelpMenu.Click += new System.EventHandler(this.aboutHelpMenu_Click);
            // 
            // saveFileMenu
            // 
            this.saveFileMenu.Name = "saveFileMenu";
            this.saveFileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFileMenu.Size = new System.Drawing.Size(180, 22);
            this.saveFileMenu.Text = "Save";
            // 
            // saveAsFileMenu
            // 
            this.saveAsFileMenu.Name = "saveAsFileMenu";
            this.saveAsFileMenu.Size = new System.Drawing.Size(180, 22);
            this.saveAsFileMenu.Text = "Save As";
            // 
            // exitFileMenu
            // 
            this.exitFileMenu.Name = "exitFileMenu";
            this.exitFileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitFileMenu.Size = new System.Drawing.Size(180, 22);
            this.exitFileMenu.Text = "Exit";
            this.exitFileMenu.Click += new System.EventHandler(this.exitFileMenu_Click);
            // 
            // redColorEditMenu
            // 
            this.redColorEditMenu.Name = "redColorEditMenu";
            this.redColorEditMenu.Size = new System.Drawing.Size(180, 22);
            this.redColorEditMenu.Text = "Red";
            this.redColorEditMenu.Click += new System.EventHandler(this.redColorEditMenu_Click);
            // 
            // greenColorEditMenu
            // 
            this.greenColorEditMenu.Name = "greenColorEditMenu";
            this.greenColorEditMenu.Size = new System.Drawing.Size(180, 22);
            this.greenColorEditMenu.Text = "Green";
            this.greenColorEditMenu.Click += new System.EventHandler(this.greenColorEditMenu_Click);
            // 
            // blueColorEditMenu
            // 
            this.blueColorEditMenu.Name = "blueColorEditMenu";
            this.blueColorEditMenu.Size = new System.Drawing.Size(180, 22);
            this.blueColorEditMenu.Text = "Blue";
            this.blueColorEditMenu.Click += new System.EventHandler(this.blueColorEditMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileMenu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorEditMenu;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutHelpMenu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveFileMenu;
        private System.Windows.Forms.ToolStripMenuItem saveAsFileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitFileMenu;
        private System.Windows.Forms.ToolStripMenuItem redColorEditMenu;
        private System.Windows.Forms.ToolStripMenuItem greenColorEditMenu;
        private System.Windows.Forms.ToolStripMenuItem blueColorEditMenu;
    }
}

