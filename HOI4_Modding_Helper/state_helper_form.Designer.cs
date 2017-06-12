namespace HOI4_Modding_Helper
{
    partial class state_helper_form
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.findTags = new System.Windows.Forms.Button();
            this.states_dir = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.christianityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.islamicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buddhisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.judaisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hinduisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debug_button = new System.Windows.Forms.Button();
            this.SaveSession = new System.Windows.Forms.Button();
            this.autoSave = new System.Windows.Forms.CheckBox();
            this.debug_output = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(260, 244);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "TAG";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "RELIGION";
            this.Column2.Name = "Column2";
            // 
            // findTags
            // 
            this.findTags.Dock = System.Windows.Forms.DockStyle.Top;
            this.findTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findTags.Location = new System.Drawing.Point(0, 244);
            this.findTags.Name = "findTags";
            this.findTags.Size = new System.Drawing.Size(260, 30);
            this.findTags.TabIndex = 1;
            this.findTags.Text = "TAG";
            this.findTags.UseVisualStyleBackColor = true;
            this.findTags.Click += new System.EventHandler(this.findTags_Click);
            // 
            // states_dir
            // 
            this.states_dir.Dock = System.Windows.Forms.DockStyle.Top;
            this.states_dir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.states_dir.Location = new System.Drawing.Point(0, 274);
            this.states_dir.Name = "states_dir";
            this.states_dir.Size = new System.Drawing.Size(260, 30);
            this.states_dir.TabIndex = 2;
            this.states_dir.Text = "STATES DIR";
            this.states_dir.UseVisualStyleBackColor = true;
            this.states_dir.Click += new System.EventHandler(this.states_dir_Click);
            // 
            // start
            // 
            this.start.Dock = System.Windows.Forms.DockStyle.Top;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.Location = new System.Drawing.Point(0, 304);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(260, 30);
            this.start.TabIndex = 3;
            this.start.Text = "DO IT";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 655);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(260, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.christianityToolStripMenuItem,
            this.islamicToolStripMenuItem,
            this.buddhisticToolStripMenuItem,
            this.judaisticToolStripMenuItem,
            this.hinduisticToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 114);
            // 
            // christianityToolStripMenuItem
            // 
            this.christianityToolStripMenuItem.Name = "christianityToolStripMenuItem";
            this.christianityToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.christianityToolStripMenuItem.Text = "christianity";
            this.christianityToolStripMenuItem.Click += new System.EventHandler(this.christianityToolStripMenuItem_Click);
            // 
            // islamicToolStripMenuItem
            // 
            this.islamicToolStripMenuItem.Name = "islamicToolStripMenuItem";
            this.islamicToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.islamicToolStripMenuItem.Text = "islam";
            this.islamicToolStripMenuItem.Click += new System.EventHandler(this.islamicToolStripMenuItem_Click);
            // 
            // buddhisticToolStripMenuItem
            // 
            this.buddhisticToolStripMenuItem.Name = "buddhisticToolStripMenuItem";
            this.buddhisticToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.buddhisticToolStripMenuItem.Text = "buddhism";
            this.buddhisticToolStripMenuItem.Click += new System.EventHandler(this.buddhisticToolStripMenuItem_Click);
            // 
            // judaisticToolStripMenuItem
            // 
            this.judaisticToolStripMenuItem.Name = "judaisticToolStripMenuItem";
            this.judaisticToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.judaisticToolStripMenuItem.Text = "judaism";
            this.judaisticToolStripMenuItem.Click += new System.EventHandler(this.judaisticToolStripMenuItem_Click);
            // 
            // hinduisticToolStripMenuItem
            // 
            this.hinduisticToolStripMenuItem.Name = "hinduisticToolStripMenuItem";
            this.hinduisticToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.hinduisticToolStripMenuItem.Text = "hinduism";
            this.hinduisticToolStripMenuItem.Click += new System.EventHandler(this.hinduisticToolStripMenuItem_Click);
            // 
            // debug_button
            // 
            this.debug_button.BackColor = System.Drawing.Color.Red;
            this.debug_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.debug_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.debug_button.Location = new System.Drawing.Point(0, 364);
            this.debug_button.Name = "debug_button";
            this.debug_button.Size = new System.Drawing.Size(260, 30);
            this.debug_button.TabIndex = 5;
            this.debug_button.Text = "Debug";
            this.debug_button.UseVisualStyleBackColor = false;
            this.debug_button.Visible = false;
            this.debug_button.Click += new System.EventHandler(this.debug_button_Click);
            // 
            // SaveSession
            // 
            this.SaveSession.Dock = System.Windows.Forms.DockStyle.Top;
            this.SaveSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveSession.Location = new System.Drawing.Point(0, 334);
            this.SaveSession.Name = "SaveSession";
            this.SaveSession.Size = new System.Drawing.Size(260, 30);
            this.SaveSession.TabIndex = 6;
            this.SaveSession.Text = "SAVE SESSION";
            this.SaveSession.UseVisualStyleBackColor = true;
            this.SaveSession.Click += new System.EventHandler(this.SaveSession_Click);
            // 
            // autoSave
            // 
            this.autoSave.AutoSize = true;
            this.autoSave.Checked = true;
            this.autoSave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.autoSave.Location = new System.Drawing.Point(0, 394);
            this.autoSave.Name = "autoSave";
            this.autoSave.Size = new System.Drawing.Size(260, 17);
            this.autoSave.TabIndex = 7;
            this.autoSave.Text = "autosave";
            this.autoSave.UseVisualStyleBackColor = true;
            // 
            // debug_output
            // 
            this.debug_output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debug_output.Location = new System.Drawing.Point(0, 411);
            this.debug_output.Multiline = true;
            this.debug_output.Name = "debug_output";
            this.debug_output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.debug_output.Size = new System.Drawing.Size(260, 244);
            this.debug_output.TabIndex = 8;
            // 
            // state_helper_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 678);
            this.Controls.Add(this.debug_output);
            this.Controls.Add(this.autoSave);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.debug_button);
            this.Controls.Add(this.SaveSession);
            this.Controls.Add(this.start);
            this.Controls.Add(this.states_dir);
            this.Controls.Add(this.findTags);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "state_helper_form";
            this.Text = "state_helper_form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.state_helper_form_FormClosing);
            this.Load += new System.EventHandler(this.state_helper_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button findTags;
        private System.Windows.Forms.Button states_dir;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem christianityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem islamicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buddhisticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem judaisticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hinduisticToolStripMenuItem;
        private System.Windows.Forms.Button debug_button;
        private System.Windows.Forms.Button SaveSession;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.CheckBox autoSave;
        private System.Windows.Forms.TextBox debug_output;
    }
}