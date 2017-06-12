namespace HOI4_Modding_Helper
{
    partial class GFX_Helper
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
            this.generated_gfx_text_box = new System.Windows.Forms.TextBox();
            this.Start_Button = new System.Windows.Forms.Button();
            this.YML_panel = new System.Windows.Forms.Panel();
            this.path_to_yml_txt = new System.Windows.Forms.TextBox();
            this.path_to_yml = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.path_to_dds_txt = new System.Windows.Forms.TextBox();
            this.path_to_dds_folder = new System.Windows.Forms.Button();
            this.EC2013_check = new System.Windows.Forms.CheckBox();
            this.YML_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // generated_gfx_text_box
            // 
            this.generated_gfx_text_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generated_gfx_text_box.Location = new System.Drawing.Point(0, 103);
            this.generated_gfx_text_box.Multiline = true;
            this.generated_gfx_text_box.Name = "generated_gfx_text_box";
            this.generated_gfx_text_box.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.generated_gfx_text_box.Size = new System.Drawing.Size(452, 238);
            this.generated_gfx_text_box.TabIndex = 0;
            // 
            // Start_Button
            // 
            this.Start_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Start_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Start_Button.Location = new System.Drawing.Point(0, 64);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(452, 39);
            this.Start_Button.TabIndex = 3;
            this.Start_Button.Text = "Сгенерировать GFX макет";
            this.Start_Button.UseVisualStyleBackColor = false;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // YML_panel
            // 
            this.YML_panel.Controls.Add(this.path_to_yml_txt);
            this.YML_panel.Controls.Add(this.path_to_yml);
            this.YML_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.YML_panel.Location = new System.Drawing.Point(0, 0);
            this.YML_panel.Name = "YML_panel";
            this.YML_panel.Size = new System.Drawing.Size(452, 32);
            this.YML_panel.TabIndex = 4;
            // 
            // path_to_yml_txt
            // 
            this.path_to_yml_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.path_to_yml_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.path_to_yml_txt.Location = new System.Drawing.Point(0, 0);
            this.path_to_yml_txt.Name = "path_to_yml_txt";
            this.path_to_yml_txt.Size = new System.Drawing.Size(388, 30);
            this.path_to_yml_txt.TabIndex = 3;
            this.path_to_yml_txt.TextChanged += new System.EventHandler(this.path_to_yml_txt_TextChanged);
            // 
            // path_to_yml
            // 
            this.path_to_yml.BackColor = System.Drawing.Color.Red;
            this.path_to_yml.Dock = System.Windows.Forms.DockStyle.Right;
            this.path_to_yml.Location = new System.Drawing.Point(388, 0);
            this.path_to_yml.Name = "path_to_yml";
            this.path_to_yml.Size = new System.Drawing.Size(64, 32);
            this.path_to_yml.TabIndex = 2;
            this.path_to_yml.Text = "...";
            this.path_to_yml.UseVisualStyleBackColor = false;
            this.path_to_yml.Click += new System.EventHandler(this.path_to_yml_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.path_to_dds_txt);
            this.panel1.Controls.Add(this.path_to_dds_folder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 32);
            this.panel1.TabIndex = 5;
            // 
            // path_to_dds_txt
            // 
            this.path_to_dds_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.path_to_dds_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.path_to_dds_txt.Location = new System.Drawing.Point(0, 0);
            this.path_to_dds_txt.Name = "path_to_dds_txt";
            this.path_to_dds_txt.Size = new System.Drawing.Size(388, 30);
            this.path_to_dds_txt.TabIndex = 3;
            this.path_to_dds_txt.TextChanged += new System.EventHandler(this.path_to_dds_txt_TextChanged);
            // 
            // path_to_dds_folder
            // 
            this.path_to_dds_folder.BackColor = System.Drawing.Color.Red;
            this.path_to_dds_folder.Dock = System.Windows.Forms.DockStyle.Right;
            this.path_to_dds_folder.Location = new System.Drawing.Point(388, 0);
            this.path_to_dds_folder.Name = "path_to_dds_folder";
            this.path_to_dds_folder.Size = new System.Drawing.Size(64, 32);
            this.path_to_dds_folder.TabIndex = 2;
            this.path_to_dds_folder.Text = "...";
            this.path_to_dds_folder.UseVisualStyleBackColor = false;
            this.path_to_dds_folder.Click += new System.EventHandler(this.path_to_dds_folder_Click);
            // 
            // EC2013_check
            // 
            this.EC2013_check.AutoSize = true;
            this.EC2013_check.Checked = true;
            this.EC2013_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EC2013_check.Location = new System.Drawing.Point(12, 80);
            this.EC2013_check.Name = "EC2013_check";
            this.EC2013_check.Size = new System.Drawing.Size(93, 17);
            this.EC2013_check.TabIndex = 6;
            this.EC2013_check.Text = "EC2013 mode";
            this.EC2013_check.UseVisualStyleBackColor = true;
            // 
            // GFX_Helper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 341);
            this.Controls.Add(this.EC2013_check);
            this.Controls.Add(this.generated_gfx_text_box);
            this.Controls.Add(this.Start_Button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.YML_panel);
            this.Name = "GFX_Helper";
            this.Text = "GFX_Helper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GFX_Helper_FormClosing);
            this.YML_panel.ResumeLayout(false);
            this.YML_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox generated_gfx_text_box;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Panel YML_panel;
        private System.Windows.Forms.Button path_to_yml;
        private System.Windows.Forms.TextBox path_to_yml_txt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox path_to_dds_txt;
        private System.Windows.Forms.Button path_to_dds_folder;
        private System.Windows.Forms.CheckBox EC2013_check;
    }
}