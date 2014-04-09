namespace CataclysmTileReader
{
    partial class Tileset_Checker
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
            this.tileconfigBox = new System.Windows.Forms.TextBox();
            this.tileconfigButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.jsonfolderBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.jsonfolderDiag = new System.Windows.Forms.FolderBrowserDialog();
            this.tileconfigDiag = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "tile_config.json";
            // 
            // tileconfigBox
            // 
            this.tileconfigBox.Location = new System.Drawing.Point(95, 12);
            this.tileconfigBox.Name = "tileconfigBox";
            this.tileconfigBox.Size = new System.Drawing.Size(184, 20);
            this.tileconfigBox.TabIndex = 1;
            this.tileconfigBox.Text = "C:\\Cata\\gfx\\tile_config.json";
            // 
            // tileconfigButton
            // 
            this.tileconfigButton.Location = new System.Drawing.Point(285, 12);
            this.tileconfigButton.Name = "tileconfigButton";
            this.tileconfigButton.Size = new System.Drawing.Size(116, 19);
            this.tileconfigButton.TabIndex = 2;
            this.tileconfigButton.Text = "Browse";
            this.tileconfigButton.UseVisualStyleBackColor = true;
            this.tileconfigButton.Click += new System.EventHandler(this.tileconfigButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(285, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 19);
            this.button2.TabIndex = 5;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.jsonfolderButton_Click);
            // 
            // jsonfolderBox
            // 
            this.jsonfolderBox.Location = new System.Drawing.Point(95, 38);
            this.jsonfolderBox.Name = "jsonfolderBox";
            this.jsonfolderBox.ShortcutsEnabled = false;
            this.jsonfolderBox.Size = new System.Drawing.Size(184, 20);
            this.jsonfolderBox.TabIndex = 4;
            this.jsonfolderBox.Text = "C:\\Cata\\data\\json\\";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "\\data\\json folder";
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(9, 63);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(86, 29);
            this.checkButton.TabIndex = 6;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(101, 71);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(130, 13);
            this.status.TabIndex = 9;
            this.status.Text = "Status: Waiting for Input...";
            // 
            // tileconfigDiag
            // 
            this.tileconfigDiag.FileName = "tile_config.json";
            this.tileconfigDiag.FileOk += new System.ComponentModel.CancelEventHandler(this.tileconfigDiag_FileOk);
            // 
            // saveFile
            // 
            this.saveFile.DefaultExt = "txt";
            this.saveFile.FileName = "missing.txt";
            // 
            // Tileset_Checker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 106);
            this.Controls.Add(this.status);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.jsonfolderBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tileconfigButton);
            this.Controls.Add(this.tileconfigBox);
            this.Controls.Add(this.label1);
            this.Name = "Tileset_Checker";
            this.Text = "Tileset Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tileconfigBox;
        private System.Windows.Forms.Button tileconfigButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox jsonfolderBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.FolderBrowserDialog jsonfolderDiag;
        private System.Windows.Forms.OpenFileDialog tileconfigDiag;
        private System.Windows.Forms.SaveFileDialog saveFile;
    }
}