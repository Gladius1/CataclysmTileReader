namespace CataclysmTileReader
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gfxBox = new System.Windows.Forms.TextBox();
            this.tileBox = new System.Windows.Forms.TextBox();
            this.jsonBox = new System.Windows.Forms.TextBox();
            this.gfxBrowse = new System.Windows.Forms.Button();
            this.tileBrowse = new System.Windows.Forms.Button();
            this.jsonBrowse = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.newMasterButton = new System.Windows.Forms.Button();
            this.oldMasterButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.progressText = new System.Windows.Forms.Label();
            this.gfxFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.tileFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.jsonFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "GFX Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tileset Folder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "JSON Folder";
            // 
            // gfxBox
            // 
            this.gfxBox.Location = new System.Drawing.Point(84, 12);
            this.gfxBox.Name = "gfxBox";
            this.gfxBox.Size = new System.Drawing.Size(269, 20);
            this.gfxBox.TabIndex = 3;
            // 
            // tileBox
            // 
            this.tileBox.Location = new System.Drawing.Point(83, 43);
            this.tileBox.Name = "tileBox";
            this.tileBox.Size = new System.Drawing.Size(270, 20);
            this.tileBox.TabIndex = 4;
            // 
            // jsonBox
            // 
            this.jsonBox.Location = new System.Drawing.Point(83, 74);
            this.jsonBox.Name = "jsonBox";
            this.jsonBox.Size = new System.Drawing.Size(270, 20);
            this.jsonBox.TabIndex = 5;
            // 
            // gfxBrowse
            // 
            this.gfxBrowse.Location = new System.Drawing.Point(359, 7);
            this.gfxBrowse.Name = "gfxBrowse";
            this.gfxBrowse.Size = new System.Drawing.Size(89, 25);
            this.gfxBrowse.TabIndex = 6;
            this.gfxBrowse.Text = "Browse";
            this.gfxBrowse.UseVisualStyleBackColor = true;
            this.gfxBrowse.Click += new System.EventHandler(this.gfxBrowse_Click);
            // 
            // tileBrowse
            // 
            this.tileBrowse.Location = new System.Drawing.Point(359, 38);
            this.tileBrowse.Name = "tileBrowse";
            this.tileBrowse.Size = new System.Drawing.Size(89, 25);
            this.tileBrowse.TabIndex = 7;
            this.tileBrowse.Text = "Browse";
            this.tileBrowse.UseVisualStyleBackColor = true;
            this.tileBrowse.Click += new System.EventHandler(this.tileBrowse_Click);
            // 
            // jsonBrowse
            // 
            this.jsonBrowse.Location = new System.Drawing.Point(359, 69);
            this.jsonBrowse.Name = "jsonBrowse";
            this.jsonBrowse.Size = new System.Drawing.Size(89, 25);
            this.jsonBrowse.TabIndex = 8;
            this.jsonBrowse.Text = "Browse";
            this.jsonBrowse.UseVisualStyleBackColor = true;
            this.jsonBrowse.Click += new System.EventHandler(this.jsonBrowse_Click);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(9, 100);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(116, 27);
            this.generateButton.TabIndex = 9;
            this.generateButton.Text = "Generate Master List";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // newMasterButton
            // 
            this.newMasterButton.Location = new System.Drawing.Point(132, 100);
            this.newMasterButton.Name = "newMasterButton";
            this.newMasterButton.Size = new System.Drawing.Size(155, 27);
            this.newMasterButton.TabIndex = 10;
            this.newMasterButton.Text = "Check Tileset vs New Master";
            this.newMasterButton.UseVisualStyleBackColor = true;
            // 
            // oldMasterButton
            // 
            this.oldMasterButton.Location = new System.Drawing.Point(293, 100);
            this.oldMasterButton.Name = "oldMasterButton";
            this.oldMasterButton.Size = new System.Drawing.Size(155, 27);
            this.oldMasterButton.TabIndex = 11;
            this.oldMasterButton.Text = "Check Tileset vs Old Master";
            this.oldMasterButton.UseVisualStyleBackColor = true;
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(10, 133);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(83, 24);
            this.helpButton.TabIndex = 12;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(365, 133);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(83, 24);
            this.aboutButton.TabIndex = 13;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            // 
            // progressText
            // 
            this.progressText.AutoSize = true;
            this.progressText.Location = new System.Drawing.Point(138, 139);
            this.progressText.Name = "progressText";
            this.progressText.Size = new System.Drawing.Size(205, 13);
            this.progressText.TabIndex = 14;
            this.progressText.Text = "Cataclysm Dark Days Ahead Tile Checker";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 164);
            this.Controls.Add(this.progressText);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.oldMasterButton);
            this.Controls.Add(this.newMasterButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.jsonBrowse);
            this.Controls.Add(this.tileBrowse);
            this.Controls.Add(this.gfxBrowse);
            this.Controls.Add(this.jsonBox);
            this.Controls.Add(this.tileBox);
            this.Controls.Add(this.gfxBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Cataclysm Dark Days Ahead Tile Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gfxBox;
        private System.Windows.Forms.TextBox tileBox;
        private System.Windows.Forms.TextBox jsonBox;
        private System.Windows.Forms.Button gfxBrowse;
        private System.Windows.Forms.Button tileBrowse;
        private System.Windows.Forms.Button jsonBrowse;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button newMasterButton;
        private System.Windows.Forms.Button oldMasterButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Label progressText;
        private System.Windows.Forms.FolderBrowserDialog gfxFolder;
        private System.Windows.Forms.FolderBrowserDialog tileFolder;
        private System.Windows.Forms.FolderBrowserDialog jsonFolder;
    }
}