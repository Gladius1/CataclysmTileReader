namespace CataclysmTileReader
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
            this.label1 = new System.Windows.Forms.Label();
            this.sourceText = new System.Windows.Forms.TextBox();
            this.compareText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.originalFile = new System.Windows.Forms.OpenFileDialog();
            this.compareFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source:";
            // 
            // sourceText
            // 
            this.sourceText.Location = new System.Drawing.Point(93, 11);
            this.sourceText.Name = "sourceText";
            this.sourceText.Size = new System.Drawing.Size(197, 20);
            this.sourceText.TabIndex = 1;
            // 
            // compareText
            // 
            this.compareText.Location = new System.Drawing.Point(93, 46);
            this.compareText.Name = "compareText";
            this.compareText.Size = new System.Drawing.Size(197, 20);
            this.compareText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Compare: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "Select original tile_config.json";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(279, 25);
            this.button2.TabIndex = 5;
            this.button2.Text = "Select your tile_config.json";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 134);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(279, 25);
            this.button3.TabIndex = 6;
            this.button3.Text = "Compare";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // originalFile
            // 
            this.originalFile.FileName = "tile_config.json";
            this.originalFile.Title = "Original tile_config.json";
            // 
            // compareFile
            // 
            this.compareFile.FileName = "tile_config.json";
            this.compareFile.Title = "Your Tile Config";
            // 
            // saveFile
            // 
            this.saveFile.FileName = "missing.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 231);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.compareText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sourceText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sourceText;
        private System.Windows.Forms.TextBox compareText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog originalFile;
        private System.Windows.Forms.OpenFileDialog compareFile;
        private System.Windows.Forms.SaveFileDialog saveFile;


    }
}

