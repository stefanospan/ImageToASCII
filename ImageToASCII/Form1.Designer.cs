namespace ImageToASCII
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
            this.imageOriginal = new System.Windows.Forms.PictureBox();
            this.uploadButton = new System.Windows.Forms.Button();
            this.convertButton = new System.Windows.Forms.Button();
            this.imageTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageOriginal)).BeginInit();
            this.SuspendLayout();
            // 
            // imageOriginal
            // 
            this.imageOriginal.Location = new System.Drawing.Point(27, 34);
            this.imageOriginal.Name = "imageOriginal";
            this.imageOriginal.Size = new System.Drawing.Size(380, 420);
            this.imageOriginal.TabIndex = 0;
            this.imageOriginal.TabStop = false;
            // 
            // uploadButton
            // 
            this.uploadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.uploadButton.FlatAppearance.BorderSize = 0;
            this.uploadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadButton.Font = new System.Drawing.Font("Century Gothic", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.uploadButton.Location = new System.Drawing.Point(74, 485);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(286, 64);
            this.uploadButton.TabIndex = 2;
            this.uploadButton.Text = "Upload";
            this.uploadButton.UseVisualStyleBackColor = false;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.convertButton.FlatAppearance.BorderSize = 0;
            this.convertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertButton.Font = new System.Drawing.Font("Century Gothic", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.convertButton.Location = new System.Drawing.Point(906, 620);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(286, 64);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // imageTextBox
            // 
            this.imageTextBox.Font = new System.Drawing.Font("Courier New", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageTextBox.Location = new System.Drawing.Point(447, 34);
            this.imageTextBox.Multiline = true;
            this.imageTextBox.Name = "imageTextBox";
            this.imageTextBox.Size = new System.Drawing.Size(745, 559);
            this.imageTextBox.TabIndex = 4;
            this.imageTextBox.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1204, 696);
            this.Controls.Add(this.imageTextBox);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.imageOriginal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageOriginal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imageOriginal;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TextBox imageTextBox;
    }
}

