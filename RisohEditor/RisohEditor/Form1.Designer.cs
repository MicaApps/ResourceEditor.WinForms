namespace RisohEditor
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {            
            if (disposing && (components != null))
            {                
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {            
            this.m_treeView = new System.Windows.Forms.TreeView();
            this.m_tabControl = new System.Windows.Forms.TabControl();
            this.codePage = new System.Windows.Forms.TabPage();
            this.m_codeEditor = new System.Windows.Forms.TextBox();
            this.hexPage = new System.Windows.Forms.TabPage();
            this.m_hexViewer = new System.Windows.Forms.TextBox();
            this.m_bmpView = new System.Windows.Forms.Panel();
            this.m_toolBar = new System.Windows.Forms.ToolStrip();
            this.m_newButton = new System.Windows.Forms.ToolStripButton();
            this.m_openButton = new System.Windows.Forms.ToolStripButton();
            this.m_saveButton = new System.Windows.Forms.ToolStripButton();
            this.m_saveAsButton = new System.Windows.Forms.ToolStripButton();
            this.m_exitButton = new System.Windows.Forms.ToolStripButton();
            this.m_toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.m_extractButton = new System.Windows.Forms.ToolStripButton();
            this.m_replaceButton = new System.Windows.Forms.ToolStripButton();
            this.m_deleteButton = new System.Windows.Forms.ToolStripButton();
            this.m_addButton = new System.Windows.Forms.ToolStripButton();
            this.m_toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.m_searchButton = new System.Windows.Forms.ToolStripButton();
            this.m_toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.m_aboutButton = new System.Windows.Forms.ToolStripButton();
            this.m_statusBar = new System.Windows.Forms.StatusStrip();
            this.m_statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.m_splitter1 = new System.Windows.Forms.SplitContainer();
            this.m_splitter2 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.m_tabControl.SuspendLayout();
            this.codePage.SuspendLayout();
            this.hexPage.SuspendLayout();
            this.m_toolBar.SuspendLayout();
            this.m_statusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_splitter1)).BeginInit();
            this.m_splitter1.Panel1.SuspendLayout();
            this.m_splitter1.Panel2.SuspendLayout();
            this.m_splitter1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_splitter2)).BeginInit();
            this.m_splitter2.Panel1.SuspendLayout();
            this.m_splitter2.Panel2.SuspendLayout();
            this.m_splitter2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // m_treeView
            // 
            this.m_treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_treeView.Location = new System.Drawing.Point(0, 0);
            this.m_treeView.Name = "m_treeView";
            this.m_treeView.Size = new System.Drawing.Size(203, 432);
            this.m_treeView.TabIndex = 0;
            this.m_treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_AfterSelect);
            this.m_treeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView_NodeMouseDoubleClick);
            // 
            // m_tabControl
            // 
            this.m_tabControl.Controls.Add(this.codePage);
            this.m_tabControl.Controls.Add(this.hexPage);
            this.m_tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_tabControl.Location = new System.Drawing.Point(0, 0);
            this.m_tabControl.Name = "m_tabControl";
            this.m_tabControl.SelectedIndex = 0;
            this.m_tabControl.Size = new System.Drawing.Size(608, 216);
            this.m_tabControl.TabIndex = 0;
            // 
            // codePage
            // 
            this.codePage.Controls.Add(this.pictureBox1);
            this.codePage.Controls.Add(this.m_codeEditor);
            this.codePage.Location = new System.Drawing.Point(4, 22);
            this.codePage.Name = "codePage";
            this.codePage.Padding = new System.Windows.Forms.Padding(3);
            this.codePage.Size = new System.Drawing.Size(600, 190);
            this.codePage.TabIndex = 0;
            this.codePage.Text = "代码";
            this.codePage.UseVisualStyleBackColor = true;
            // 
            // m_codeEditor
            // 
            this.m_codeEditor.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_codeEditor.Font = new System.Drawing.Font("Consolas", 10F);
            this.m_codeEditor.Location = new System.Drawing.Point(3, 3);
            this.m_codeEditor.Multiline = true;
            this.m_codeEditor.Name = "m_codeEditor";
            this.m_codeEditor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.m_codeEditor.Size = new System.Drawing.Size(425, 184);
            this.m_codeEditor.TabIndex = 0;
            // 
            // hexPage
            // 
            this.hexPage.Controls.Add(this.m_hexViewer);
            this.hexPage.Location = new System.Drawing.Point(4, 22);
            this.hexPage.Name = "hexPage";
            this.hexPage.Padding = new System.Windows.Forms.Padding(3);
            this.hexPage.Size = new System.Drawing.Size(588, 190);
            this.hexPage.TabIndex = 1;
            this.hexPage.Text = "十六进制";
            this.hexPage.UseVisualStyleBackColor = true;
            // 
            // m_hexViewer
            // 
            this.m_hexViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_hexViewer.Font = new System.Drawing.Font("Courier New", 9F);
            this.m_hexViewer.Location = new System.Drawing.Point(3, 3);
            this.m_hexViewer.Multiline = true;
            this.m_hexViewer.Name = "m_hexViewer";
            this.m_hexViewer.ReadOnly = true;
            this.m_hexViewer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.m_hexViewer.Size = new System.Drawing.Size(582, 184);
            this.m_hexViewer.TabIndex = 0;
            // 
            // m_bmpView
            // 
            this.m_bmpView.BackColor = System.Drawing.Color.White;
            this.m_bmpView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_bmpView.Location = new System.Drawing.Point(0, 0);
            this.m_bmpView.Name = "m_bmpView";
            this.m_bmpView.Size = new System.Drawing.Size(608, 212);
            this.m_bmpView.TabIndex = 1;
            // 
            // m_toolBar
            // 
            this.m_toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_newButton,
            this.m_openButton,
            this.m_saveButton,
            this.m_saveAsButton,
            this.m_exitButton,
            this.m_toolStripSeparator1,
            this.m_extractButton,
            this.m_replaceButton,
            this.m_deleteButton,
            this.m_addButton,
            this.m_toolStripSeparator2,
            this.m_searchButton,
            this.m_toolStripSeparator3,
            this.m_aboutButton});
            this.m_toolBar.Location = new System.Drawing.Point(0, 0);
            this.m_toolBar.Name = "m_toolBar";
            this.m_toolBar.Size = new System.Drawing.Size(815, 25);
            this.m_toolBar.TabIndex = 1;
            this.m_toolBar.Text = "toolStrip1";
            // 
            // m_newButton
            // 
            this.m_newButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.m_newButton.Name = "m_newButton";
            this.m_newButton.Size = new System.Drawing.Size(36, 22);
            this.m_newButton.Text = "新建";
            this.m_newButton.Click += new System.EventHandler(this.m_newButton_Click);
            // 
            // m_openButton
            // 
            this.m_openButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.m_openButton.Name = "m_openButton";
            this.m_openButton.Size = new System.Drawing.Size(36, 22);
            this.m_openButton.Text = "打开";
            this.m_openButton.Click += new System.EventHandler(this.m_openButton_Click);
            // 
            // m_saveButton
            // 
            this.m_saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.m_saveButton.Name = "m_saveButton";
            this.m_saveButton.Size = new System.Drawing.Size(36, 22);
            this.m_saveButton.Text = "保存";
            this.m_saveButton.Click += new System.EventHandler(this.m_saveButton_Click);
            // 
            // m_saveAsButton
            // 
            this.m_saveAsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.m_saveAsButton.Name = "m_saveAsButton";
            this.m_saveAsButton.Size = new System.Drawing.Size(48, 22);
            this.m_saveAsButton.Text = "另存为";
            this.m_saveAsButton.Click += new System.EventHandler(this.m_saveAsButton_Click);
            // 
            // m_exitButton
            // 
            this.m_exitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.m_exitButton.Name = "m_exitButton";
            this.m_exitButton.Size = new System.Drawing.Size(36, 22);
            this.m_exitButton.Text = "退出";
            this.m_exitButton.Click += new System.EventHandler(this.m_exitButton_Click);
            // 
            // m_toolStripSeparator1
            // 
            this.m_toolStripSeparator1.Name = "m_toolStripSeparator1";
            this.m_toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // m_extractButton
            // 
            this.m_extractButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.m_extractButton.Name = "m_extractButton";
            this.m_extractButton.Size = new System.Drawing.Size(36, 22);
            this.m_extractButton.Text = "提取";
            this.m_extractButton.Click += new System.EventHandler(this.m_extractButton_Click);
            // 
            // m_replaceButton
            // 
            this.m_replaceButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.m_replaceButton.Name = "m_replaceButton";
            this.m_replaceButton.Size = new System.Drawing.Size(36, 22);
            this.m_replaceButton.Text = "替换";
            this.m_replaceButton.Click += new System.EventHandler(this.m_replaceButton_Click);
            // 
            // m_deleteButton
            // 
            this.m_deleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.m_deleteButton.Name = "m_deleteButton";
            this.m_deleteButton.Size = new System.Drawing.Size(36, 22);
            this.m_deleteButton.Text = "删除";
            this.m_deleteButton.Click += new System.EventHandler(this.m_deleteButton_Click);
            // 
            // m_addButton
            // 
            this.m_addButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.m_addButton.Name = "m_addButton";
            this.m_addButton.Size = new System.Drawing.Size(36, 22);
            this.m_addButton.Text = "添加";
            this.m_addButton.Click += new System.EventHandler(this.m_addButton_Click);
            // 
            // m_toolStripSeparator2
            // 
            this.m_toolStripSeparator2.Name = "m_toolStripSeparator2";
            this.m_toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // m_searchButton
            // 
            this.m_searchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.m_searchButton.Name = "m_searchButton";
            this.m_searchButton.Size = new System.Drawing.Size(36, 22);
            this.m_searchButton.Text = "搜索";
            this.m_searchButton.Click += new System.EventHandler(this.m_searchButton_Click);
            // 
            // m_toolStripSeparator3
            // 
            this.m_toolStripSeparator3.Name = "m_toolStripSeparator3";
            this.m_toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // m_aboutButton
            // 
            this.m_aboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.m_aboutButton.Name = "m_aboutButton";
            this.m_aboutButton.Size = new System.Drawing.Size(36, 22);
            this.m_aboutButton.Text = "关于";
            this.m_aboutButton.Click += new System.EventHandler(this.m_aboutButton_Click);
            // 
            // m_statusBar
            // 
            this.m_statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_statusLabel});
            this.m_statusBar.Location = new System.Drawing.Point(0, 457);
            this.m_statusBar.Name = "m_statusBar";
            this.m_statusBar.Size = new System.Drawing.Size(815, 22);
            this.m_statusBar.TabIndex = 2;
            this.m_statusBar.Text = "statusStrip1";
            // 
            // m_statusLabel
            // 
            this.m_statusLabel.Name = "m_statusLabel";
            this.m_statusLabel.Size = new System.Drawing.Size(32, 17);
            this.m_statusLabel.Text = "就绪";
            // 
            // m_splitter1
            // 
            this.m_splitter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_splitter1.Location = new System.Drawing.Point(0, 25);
            this.m_splitter1.Name = "m_splitter1";
            // 
            // m_splitter1.Panel1
            // 
            this.m_splitter1.Panel1.Controls.Add(this.m_treeView);
            // 
            // m_splitter1.Panel2
            // 
            this.m_splitter1.Panel2.Controls.Add(this.m_splitter2);
            this.m_splitter1.Size = new System.Drawing.Size(815, 432);
            this.m_splitter1.SplitterDistance = 203;
            this.m_splitter1.TabIndex = 0;
            // 
            // m_splitter2
            // 
            this.m_splitter2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_splitter2.Location = new System.Drawing.Point(0, 0);
            this.m_splitter2.Name = "m_splitter2";
            this.m_splitter2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // m_splitter2.Panel1
            // 
            this.m_splitter2.Panel1.Controls.Add(this.m_tabControl);
            // 
            // m_splitter2.Panel2
            // 
            this.m_splitter2.Panel2.Controls.Add(this.m_bmpView);
            this.m_splitter2.Size = new System.Drawing.Size(608, 432);
            this.m_splitter2.SplitterDistance = 216;
            this.m_splitter2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(428, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 184);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 479);
            this.Controls.Add(this.m_splitter1);
            this.Controls.Add(this.m_toolBar);
            this.Controls.Add(this.m_statusBar);
            this.Name = "Form1";
            this.Text = "RisohEditor - C# 版本";
            this.m_tabControl.ResumeLayout(false);
            this.codePage.ResumeLayout(false);
            this.codePage.PerformLayout();
            this.hexPage.ResumeLayout(false);
            this.hexPage.PerformLayout();
            this.m_toolBar.ResumeLayout(false);
            this.m_toolBar.PerformLayout();
            this.m_statusBar.ResumeLayout(false);
            this.m_statusBar.PerformLayout();
            this.m_splitter1.Panel1.ResumeLayout(false);
            this.m_splitter1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_splitter1)).EndInit();
            this.m_splitter1.ResumeLayout(false);
            this.m_splitter2.Panel1.ResumeLayout(false);
            this.m_splitter2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_splitter2)).EndInit();
            this.m_splitter2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView m_treeView;
        private System.Windows.Forms.TabControl m_tabControl;
        private System.Windows.Forms.TabPage codePage;
        private System.Windows.Forms.TextBox m_codeEditor;
        private System.Windows.Forms.TabPage hexPage;
        private System.Windows.Forms.TextBox m_hexViewer;
        private System.Windows.Forms.Panel m_bmpView;
        private System.Windows.Forms.ToolStrip m_toolBar;
        private System.Windows.Forms.ToolStripButton m_newButton;
        private System.Windows.Forms.ToolStripButton m_openButton;
        private System.Windows.Forms.ToolStripButton m_saveButton;
        private System.Windows.Forms.ToolStripButton m_saveAsButton;
        private System.Windows.Forms.ToolStripButton m_exitButton;
        private System.Windows.Forms.ToolStripSeparator m_toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton m_extractButton;
        private System.Windows.Forms.ToolStripButton m_replaceButton;
        private System.Windows.Forms.ToolStripButton m_deleteButton;
        private System.Windows.Forms.ToolStripButton m_addButton;
        private System.Windows.Forms.ToolStripSeparator m_toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton m_searchButton;
        private System.Windows.Forms.ToolStripSeparator m_toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton m_aboutButton;
        private System.Windows.Forms.StatusStrip m_statusBar;
        private System.Windows.Forms.ToolStripStatusLabel m_statusLabel;
        private System.Windows.Forms.SplitContainer m_splitter1;
        private System.Windows.Forms.SplitContainer m_splitter2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

