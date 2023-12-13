namespace IndieGameDevHub
{
    partial class frmMDIParent
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
            menuStrip = new MenuStrip();
            maintenanceToolStripMenuItem = new ToolStripMenuItem();
            mnuProjects = new ToolStripMenuItem();
            mnuDevelopers = new ToolStripMenuItem();
            mnuBrowse = new ToolStripMenuItem();
            projectsToolStripMenuItem = new ToolStripMenuItem();
            developersToolStripMenuItem = new ToolStripMenuItem();
            mnuContributors = new ToolStripMenuItem();
            viewMenu = new ToolStripMenuItem();
            toolBarToolStripMenuItem = new ToolStripMenuItem();
            statusBarToolStripMenuItem = new ToolStripMenuItem();
            windowsMenu = new ToolStripMenuItem();
            newWindowToolStripMenuItem = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            tileVerticalToolStripMenuItem = new ToolStripMenuItem();
            tileHorizontalToolStripMenuItem = new ToolStripMenuItem();
            closeAllToolStripMenuItem = new ToolStripMenuItem();
            arrangeIconsToolStripMenuItem = new ToolStripMenuItem();
            helpMenu = new ToolStripMenuItem();
            toolStripSeparator8 = new ToolStripSeparator();
            mnuAbout = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            toolStripProgressBar1 = new ToolStripProgressBar();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { maintenanceToolStripMenuItem, viewMenu, windowsMenu, helpMenu });
            menuStrip.Location = new Point(0, 0);
            menuStrip.MdiWindowListItem = windowsMenu;
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 2, 0, 2);
            menuStrip.Size = new Size(737, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // maintenanceToolStripMenuItem
            // 
            maintenanceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuProjects, mnuDevelopers, mnuBrowse, mnuContributors });
            maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            maintenanceToolStripMenuItem.Size = new Size(88, 20);
            maintenanceToolStripMenuItem.Text = "&Maintenance";
            // 
            // mnuProjects
            // 
            mnuProjects.Name = "mnuProjects";
            mnuProjects.Size = new Size(141, 22);
            mnuProjects.Tag = "projects";
            mnuProjects.Text = "&Projects";
            mnuProjects.Click += ShowNewForm;
            // 
            // mnuDevelopers
            // 
            mnuDevelopers.Name = "mnuDevelopers";
            mnuDevelopers.Size = new Size(141, 22);
            mnuDevelopers.Tag = "developers";
            mnuDevelopers.Text = "&Developers";
            mnuDevelopers.Click += ShowNewForm;
            // 
            // mnuBrowse
            // 
            mnuBrowse.DropDownItems.AddRange(new ToolStripItem[] { projectsToolStripMenuItem, developersToolStripMenuItem });
            mnuBrowse.Name = "mnuBrowse";
            mnuBrowse.Size = new Size(141, 22);
            mnuBrowse.Tag = "browse";
            mnuBrowse.Text = "&Browse";
            mnuBrowse.Click += ShowNewForm;
            // 
            // projectsToolStripMenuItem
            // 
            projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            projectsToolStripMenuItem.Size = new Size(132, 22);
            projectsToolStripMenuItem.Tag = "browseprojects";
            projectsToolStripMenuItem.Text = "Projects";
            projectsToolStripMenuItem.Click += ShowNewForm;
            // 
            // developersToolStripMenuItem
            // 
            developersToolStripMenuItem.Name = "developersToolStripMenuItem";
            developersToolStripMenuItem.Size = new Size(132, 22);
            developersToolStripMenuItem.Tag = "browsedevelopers";
            developersToolStripMenuItem.Text = "Developers";
            developersToolStripMenuItem.Click += ShowNewForm;
            // 
            // mnuContributors
            // 
            mnuContributors.Name = "mnuContributors";
            mnuContributors.Size = new Size(141, 22);
            mnuContributors.Tag = "contributors";
            mnuContributors.Text = "Contributors";
            mnuContributors.Click += ShowNewForm;
            // 
            // viewMenu
            // 
            viewMenu.DropDownItems.AddRange(new ToolStripItem[] { toolBarToolStripMenuItem, statusBarToolStripMenuItem });
            viewMenu.Name = "viewMenu";
            viewMenu.Size = new Size(44, 20);
            viewMenu.Text = "&View";
            // 
            // toolBarToolStripMenuItem
            // 
            toolBarToolStripMenuItem.Checked = true;
            toolBarToolStripMenuItem.CheckOnClick = true;
            toolBarToolStripMenuItem.CheckState = CheckState.Checked;
            toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
            toolBarToolStripMenuItem.Size = new Size(126, 22);
            toolBarToolStripMenuItem.Text = "&Toolbar";
            toolBarToolStripMenuItem.Click += ToolBarToolStripMenuItem_Click;
            // 
            // statusBarToolStripMenuItem
            // 
            statusBarToolStripMenuItem.Checked = true;
            statusBarToolStripMenuItem.CheckOnClick = true;
            statusBarToolStripMenuItem.CheckState = CheckState.Checked;
            statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            statusBarToolStripMenuItem.Size = new Size(126, 22);
            statusBarToolStripMenuItem.Text = "&Status Bar";
            statusBarToolStripMenuItem.Click += StatusBarToolStripMenuItem_Click;
            // 
            // windowsMenu
            // 
            windowsMenu.DropDownItems.AddRange(new ToolStripItem[] { newWindowToolStripMenuItem, cascadeToolStripMenuItem, tileVerticalToolStripMenuItem, tileHorizontalToolStripMenuItem, closeAllToolStripMenuItem, arrangeIconsToolStripMenuItem });
            windowsMenu.Name = "windowsMenu";
            windowsMenu.Size = new Size(68, 20);
            windowsMenu.Text = "&Windows";
            // 
            // newWindowToolStripMenuItem
            // 
            newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            newWindowToolStripMenuItem.Size = new Size(150, 22);
            newWindowToolStripMenuItem.Text = "&New Window";
            newWindowToolStripMenuItem.Click += ShowNewForm;
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(150, 22);
            cascadeToolStripMenuItem.Text = "&Cascade";
            cascadeToolStripMenuItem.Click += CascadeToolStripMenuItem_Click;
            // 
            // tileVerticalToolStripMenuItem
            // 
            tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            tileVerticalToolStripMenuItem.Size = new Size(150, 22);
            tileVerticalToolStripMenuItem.Text = "Tile &Vertical";
            tileVerticalToolStripMenuItem.Click += TileVerticalToolStripMenuItem_Click;
            // 
            // tileHorizontalToolStripMenuItem
            // 
            tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            tileHorizontalToolStripMenuItem.Size = new Size(150, 22);
            tileHorizontalToolStripMenuItem.Text = "Tile &Horizontal";
            tileHorizontalToolStripMenuItem.Click += TileHorizontalToolStripMenuItem_Click;
            // 
            // closeAllToolStripMenuItem
            // 
            closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            closeAllToolStripMenuItem.Size = new Size(150, 22);
            closeAllToolStripMenuItem.Text = "C&lose All";
            closeAllToolStripMenuItem.Click += CloseAllToolStripMenuItem_Click;
            // 
            // arrangeIconsToolStripMenuItem
            // 
            arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            arrangeIconsToolStripMenuItem.Size = new Size(150, 22);
            arrangeIconsToolStripMenuItem.Text = "&Arrange Icons";
            arrangeIconsToolStripMenuItem.Click += ArrangeIconsToolStripMenuItem_Click;
            // 
            // helpMenu
            // 
            helpMenu.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator8, mnuAbout });
            helpMenu.Name = "helpMenu";
            helpMenu.Size = new Size(44, 20);
            helpMenu.Text = "&Help";
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(128, 6);
            // 
            // mnuAbout
            // 
            mnuAbout.Name = "mnuAbout";
            mnuAbout.Size = new Size(131, 22);
            mnuAbout.Tag = "about";
            mnuAbout.Text = "&About ... ...";
            mnuAbout.Click += ShowNewForm;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel, toolStripProgressBar1 });
            statusStrip.Location = new Point(0, 501);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(737, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(39, 17);
            toolStripStatusLabel.Text = "Status";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 16);
            // 
            // frmMDIParent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(737, 523);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmMDIParent";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Indie Game Developer Hub";
            Load += frmMDIParent_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion


        private MenuStrip menuStrip;
        private StatusStrip statusStrip;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripStatusLabel toolStripStatusLabel;
        private ToolStripMenuItem mnuAbout;
        private ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private ToolStripMenuItem viewMenu;
        private ToolStripMenuItem toolBarToolStripMenuItem;
        private ToolStripMenuItem statusBarToolStripMenuItem;
        private ToolStripMenuItem windowsMenu;
        private ToolStripMenuItem newWindowToolStripMenuItem;
        private ToolStripMenuItem cascadeToolStripMenuItem;
        private ToolStripMenuItem tileVerticalToolStripMenuItem;
        private ToolStripMenuItem closeAllToolStripMenuItem;
        private ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private ToolStripMenuItem helpMenu;
        private ToolTip toolTip;
        private ToolStripMenuItem maintenanceToolStripMenuItem;
        private ToolStripMenuItem mnuProjects;
        private ToolStripMenuItem mnuDevelopers;
        private ToolStripMenuItem mnuBrowse;
        private ToolStripMenuItem mnuContributors;
        private ToolStripMenuItem projectsToolStripMenuItem;
        private ToolStripMenuItem developersToolStripMenuItem;
        private ToolStripProgressBar toolStripProgressBar1;
    }
}



