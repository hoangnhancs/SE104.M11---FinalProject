
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
            this.custom_picture_box1 = new bookStoreManagement.Custom_PictureBox.custom_picture_box();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.customComboBox1 = new bookStoreManagement.Custom_ComboBox.customComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custom_picture_box1)).BeginInit();
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
            // custom_picture_box1
            // 
            this.custom_picture_box1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.custom_picture_box1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.custom_picture_box1.BorderColor2 = System.Drawing.Color.HotPink;
            this.custom_picture_box1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.custom_picture_box1.BorderSize = 2;
            this.custom_picture_box1.GradientAngle = 50F;
            this.custom_picture_box1.Image = global::bookStoreManagement.Properties.Resources.logo_text2;
            this.custom_picture_box1.Location = new System.Drawing.Point(856, 35);
            this.custom_picture_box1.Name = "custom_picture_box1";
            this.custom_picture_box1.Size = new System.Drawing.Size(49, 49);
            this.custom_picture_box1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.custom_picture_box1.TabIndex = 3;
            this.custom_picture_box1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(613, 160);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // customComboBox1
            // 
            this.customComboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customComboBox1.BorderColor = System.Drawing.Color.Navy;
            this.customComboBox1.BorderSize = 1;
            this.customComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.customComboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.customComboBox1.FormattingEnabled = true;
            this.customComboBox1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.customComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.customComboBox1.ListTextColor = System.Drawing.Color.DimGray;
            this.customComboBox1.Location = new System.Drawing.Point(191, 202);
            this.customComboBox1.MinimumSize = new System.Drawing.Size(200, 0);
            this.customComboBox1.Name = "customComboBox1";
            this.customComboBox1.Size = new System.Drawing.Size(200, 28);
            this.customComboBox1.TabIndex = 6;
            this.customComboBox1.Texts = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 527);
            this.Controls.Add(this.customComboBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.custom_picture_box1);
            this.Controls.Add(this.pictureBox_logo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custom_picture_box1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_logo;
        private Custom_PictureBox.custom_picture_box custom_picture_box1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Custom_ComboBox.customComboBox customComboBox1;
    }
}

