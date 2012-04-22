namespace CloudBoard
{
    partial class Form_Setup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Setup));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip_main = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton_File = new System.Windows.Forms.ToolStripDropDownButton();
            this.saveSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl_main = new System.Windows.Forms.TabControl();
            this.tabPage_history = new System.Windows.Forms.TabPage();
            this.tabPage_config = new System.Windows.Forms.TabPage();
            this.tabPage_debug = new System.Windows.Forms.TabPage();
            this.tabControl_Config = new System.Windows.Forms.TabControl();
            this.tabPage_imageuploadsettings = new System.Windows.Forms.TabPage();
            this.tabPage_fileuploadsettings = new System.Windows.Forms.TabPage();
            this.tabPage_textuploadsettings = new System.Windows.Forms.TabPage();
            this.tabPage_miscsettings = new System.Windows.Forms.TabPage();
            this.tabControl_Miscsettings = new System.Windows.Forms.TabControl();
            this.tabPage_FTPsettings = new System.Windows.Forms.TabPage();
            this.tabPage_APIkeys = new System.Windows.Forms.TabPage();
            this.tabPage_URLs = new System.Windows.Forms.TabPage();
            this.tabPage_Hotkeysettings = new System.Windows.Forms.TabPage();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip_main.SuspendLayout();
            this.tabControl_main.SuspendLayout();
            this.tabPage_config.SuspendLayout();
            this.tabControl_Config.SuspendLayout();
            this.tabPage_miscsettings.SuspendLayout();
            this.tabControl_Miscsettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControl_main);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(505, 317);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(505, 342);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip_main);
            // 
            // toolStrip_main
            // 
            this.toolStrip_main.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton_File});
            this.toolStrip_main.Location = new System.Drawing.Point(3, 0);
            this.toolStrip_main.Name = "toolStrip_main";
            this.toolStrip_main.Size = new System.Drawing.Size(50, 25);
            this.toolStrip_main.TabIndex = 0;
            // 
            // toolStripDropDownButton_File
            // 
            this.toolStripDropDownButton_File.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveSettingsToolStripMenuItem,
            this.uploadFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton_File.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton_File.Image")));
            this.toolStripDropDownButton_File.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton_File.Name = "toolStripDropDownButton_File";
            this.toolStripDropDownButton_File.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton_File.Text = "File";
            // 
            // saveSettingsToolStripMenuItem
            // 
            this.saveSettingsToolStripMenuItem.Name = "saveSettingsToolStripMenuItem";
            this.saveSettingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveSettingsToolStripMenuItem.Text = "Save settings";
            // 
            // uploadFileToolStripMenuItem
            // 
            this.uploadFileToolStripMenuItem.Name = "uploadFileToolStripMenuItem";
            this.uploadFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.uploadFileToolStripMenuItem.Text = "Upload file";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // tabControl_main
            // 
            this.tabControl_main.Controls.Add(this.tabPage_history);
            this.tabControl_main.Controls.Add(this.tabPage_config);
            this.tabControl_main.Controls.Add(this.tabPage_debug);
            this.tabControl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_main.Location = new System.Drawing.Point(0, 0);
            this.tabControl_main.Name = "tabControl_main";
            this.tabControl_main.SelectedIndex = 0;
            this.tabControl_main.Size = new System.Drawing.Size(505, 317);
            this.tabControl_main.TabIndex = 0;
            // 
            // tabPage_history
            // 
            this.tabPage_history.Location = new System.Drawing.Point(4, 22);
            this.tabPage_history.Name = "tabPage_history";
            this.tabPage_history.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_history.Size = new System.Drawing.Size(466, 288);
            this.tabPage_history.TabIndex = 0;
            this.tabPage_history.Text = "Upload history";
            this.tabPage_history.UseVisualStyleBackColor = true;
            // 
            // tabPage_config
            // 
            this.tabPage_config.Controls.Add(this.tabControl_Config);
            this.tabPage_config.Location = new System.Drawing.Point(4, 22);
            this.tabPage_config.Name = "tabPage_config";
            this.tabPage_config.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_config.Size = new System.Drawing.Size(497, 291);
            this.tabPage_config.TabIndex = 1;
            this.tabPage_config.Text = "Configuration";
            this.tabPage_config.UseVisualStyleBackColor = true;
            // 
            // tabPage_debug
            // 
            this.tabPage_debug.Location = new System.Drawing.Point(4, 22);
            this.tabPage_debug.Name = "tabPage_debug";
            this.tabPage_debug.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_debug.Size = new System.Drawing.Size(466, 288);
            this.tabPage_debug.TabIndex = 2;
            this.tabPage_debug.Text = "Debug";
            this.tabPage_debug.UseVisualStyleBackColor = true;
            // 
            // tabControl_Config
            // 
            this.tabControl_Config.Controls.Add(this.tabPage_imageuploadsettings);
            this.tabControl_Config.Controls.Add(this.tabPage_fileuploadsettings);
            this.tabControl_Config.Controls.Add(this.tabPage_textuploadsettings);
            this.tabControl_Config.Controls.Add(this.tabPage_URLs);
            this.tabControl_Config.Controls.Add(this.tabPage_miscsettings);
            this.tabControl_Config.Controls.Add(this.tabPage_Hotkeysettings);
            this.tabControl_Config.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Config.Location = new System.Drawing.Point(3, 3);
            this.tabControl_Config.Name = "tabControl_Config";
            this.tabControl_Config.SelectedIndex = 0;
            this.tabControl_Config.Size = new System.Drawing.Size(491, 285);
            this.tabControl_Config.TabIndex = 0;
            // 
            // tabPage_imageuploadsettings
            // 
            this.tabPage_imageuploadsettings.Location = new System.Drawing.Point(4, 22);
            this.tabPage_imageuploadsettings.Name = "tabPage_imageuploadsettings";
            this.tabPage_imageuploadsettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_imageuploadsettings.Size = new System.Drawing.Size(483, 259);
            this.tabPage_imageuploadsettings.TabIndex = 0;
            this.tabPage_imageuploadsettings.Text = "Image uploads";
            this.tabPage_imageuploadsettings.UseVisualStyleBackColor = true;
            // 
            // tabPage_fileuploadsettings
            // 
            this.tabPage_fileuploadsettings.Location = new System.Drawing.Point(4, 22);
            this.tabPage_fileuploadsettings.Name = "tabPage_fileuploadsettings";
            this.tabPage_fileuploadsettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_fileuploadsettings.Size = new System.Drawing.Size(452, 256);
            this.tabPage_fileuploadsettings.TabIndex = 1;
            this.tabPage_fileuploadsettings.Text = "File uploads";
            this.tabPage_fileuploadsettings.UseVisualStyleBackColor = true;
            // 
            // tabPage_textuploadsettings
            // 
            this.tabPage_textuploadsettings.Location = new System.Drawing.Point(4, 22);
            this.tabPage_textuploadsettings.Name = "tabPage_textuploadsettings";
            this.tabPage_textuploadsettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_textuploadsettings.Size = new System.Drawing.Size(452, 256);
            this.tabPage_textuploadsettings.TabIndex = 2;
            this.tabPage_textuploadsettings.Text = "Text uploads";
            this.tabPage_textuploadsettings.UseVisualStyleBackColor = true;
            // 
            // tabPage_miscsettings
            // 
            this.tabPage_miscsettings.Controls.Add(this.tabControl_Miscsettings);
            this.tabPage_miscsettings.Location = new System.Drawing.Point(4, 22);
            this.tabPage_miscsettings.Name = "tabPage_miscsettings";
            this.tabPage_miscsettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_miscsettings.Size = new System.Drawing.Size(483, 259);
            this.tabPage_miscsettings.TabIndex = 3;
            this.tabPage_miscsettings.Text = "Misc settings";
            this.tabPage_miscsettings.UseVisualStyleBackColor = true;
            // 
            // tabControl_Miscsettings
            // 
            this.tabControl_Miscsettings.Controls.Add(this.tabPage_FTPsettings);
            this.tabControl_Miscsettings.Controls.Add(this.tabPage_APIkeys);
            this.tabControl_Miscsettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Miscsettings.Location = new System.Drawing.Point(3, 3);
            this.tabControl_Miscsettings.Name = "tabControl_Miscsettings";
            this.tabControl_Miscsettings.SelectedIndex = 0;
            this.tabControl_Miscsettings.Size = new System.Drawing.Size(477, 253);
            this.tabControl_Miscsettings.TabIndex = 0;
            // 
            // tabPage_FTPsettings
            // 
            this.tabPage_FTPsettings.Location = new System.Drawing.Point(4, 22);
            this.tabPage_FTPsettings.Name = "tabPage_FTPsettings";
            this.tabPage_FTPsettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_FTPsettings.Size = new System.Drawing.Size(469, 227);
            this.tabPage_FTPsettings.TabIndex = 0;
            this.tabPage_FTPsettings.Text = "FTP settings";
            this.tabPage_FTPsettings.UseVisualStyleBackColor = true;
            // 
            // tabPage_APIkeys
            // 
            this.tabPage_APIkeys.Location = new System.Drawing.Point(4, 22);
            this.tabPage_APIkeys.Name = "tabPage_APIkeys";
            this.tabPage_APIkeys.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_APIkeys.Size = new System.Drawing.Size(469, 227);
            this.tabPage_APIkeys.TabIndex = 1;
            this.tabPage_APIkeys.Text = "API keys";
            this.tabPage_APIkeys.UseVisualStyleBackColor = true;
            // 
            // tabPage_URLs
            // 
            this.tabPage_URLs.Location = new System.Drawing.Point(4, 22);
            this.tabPage_URLs.Name = "tabPage_URLs";
            this.tabPage_URLs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_URLs.Size = new System.Drawing.Size(452, 256);
            this.tabPage_URLs.TabIndex = 4;
            this.tabPage_URLs.Text = "URL shortener";
            this.tabPage_URLs.UseVisualStyleBackColor = true;
            // 
            // tabPage_Hotkeysettings
            // 
            this.tabPage_Hotkeysettings.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Hotkeysettings.Name = "tabPage_Hotkeysettings";
            this.tabPage_Hotkeysettings.Size = new System.Drawing.Size(452, 256);
            this.tabPage_Hotkeysettings.TabIndex = 5;
            this.tabPage_Hotkeysettings.Text = "Hotkey settings";
            this.tabPage_Hotkeysettings.UseVisualStyleBackColor = true;
            // 
            // Form_Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 342);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Form_Setup";
            this.Text = "CloudBoard";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip_main.ResumeLayout(false);
            this.toolStrip_main.PerformLayout();
            this.tabControl_main.ResumeLayout(false);
            this.tabPage_config.ResumeLayout(false);
            this.tabControl_Config.ResumeLayout(false);
            this.tabPage_miscsettings.ResumeLayout(false);
            this.tabControl_Miscsettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip_main;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton_File;
        private System.Windows.Forms.ToolStripMenuItem saveSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl_main;
        private System.Windows.Forms.TabPage tabPage_history;
        private System.Windows.Forms.TabPage tabPage_config;
        private System.Windows.Forms.TabControl tabControl_Config;
        private System.Windows.Forms.TabPage tabPage_imageuploadsettings;
        private System.Windows.Forms.TabPage tabPage_fileuploadsettings;
        private System.Windows.Forms.TabPage tabPage_textuploadsettings;
        private System.Windows.Forms.TabPage tabPage_miscsettings;
        private System.Windows.Forms.TabControl tabControl_Miscsettings;
        private System.Windows.Forms.TabPage tabPage_FTPsettings;
        private System.Windows.Forms.TabPage tabPage_APIkeys;
        private System.Windows.Forms.TabPage tabPage_debug;
        private System.Windows.Forms.TabPage tabPage_URLs;
        private System.Windows.Forms.TabPage tabPage_Hotkeysettings;
    }
}

