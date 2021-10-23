
namespace bookStoreManagement
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
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.rjButton1 = new bookStoreManagement.RJButton.RJButton();
            this.customComboBox1 = new bookStoreManagement.Custom_ComboBox.customComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox_logo.Image = global::bookStoreManagement.Properties.Resources.logo_text;
            this.pictureBox_logo.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(204, 72);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_logo.TabIndex = 0;
            this.pictureBox_logo.TabStop = false;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 40;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(332, 119);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(229, 45);
            this.rjButton1.TabIndex = 1;
            this.rjButton1.Text = "heelo :v";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // customComboBox1
            // 
            this.customComboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customComboBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customComboBox1.BorderSize = 1;
            this.customComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.customComboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.customComboBox1.FormattingEnabled = true;
            this.customComboBox1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.customComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.customComboBox1.ListTextColor = System.Drawing.Color.DimGray;
            this.customComboBox1.Location = new System.Drawing.Point(371, 248);
            this.customComboBox1.MinimumSize = new System.Drawing.Size(200, 0);
            this.customComboBox1.Name = "customComboBox1";
            this.customComboBox1.Size = new System.Drawing.Size(280, 28);
            this.customComboBox1.TabIndex = 2;
            this.customComboBox1.Texts = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 527);
            this.Controls.Add(this.customComboBox1);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.pictureBox_logo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_logo;
        private RJButton.RJButton rjButton1;
        private Custom_ComboBox.customComboBox customComboBox1;
    }
}

