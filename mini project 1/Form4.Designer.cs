namespace mini_project_1
{
    partial class Form4
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.uploadPhotoButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.uploadInfoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(29, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 312);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(316, 70);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(121, 20);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "Enter First Name:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(316, 137);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(120, 20);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Enter Last Name:";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(316, 209);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(101, 20);
            this.labelCountry.TabIndex = 3;
            this.labelCountry.Text = "Enter Country:";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(316, 278);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(98, 20);
            this.labelGender.TabIndex = 4;
            this.labelGender.Text = "Enter Gender:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(483, 70);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(131, 27);
            this.firstNameTextBox.TabIndex = 5;
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(483, 202);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(131, 27);
            this.countryTextBox.TabIndex = 6;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(483, 134);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(131, 27);
            this.lastNameTextBox.TabIndex = 7;
            // 
            // genderTextBox
            // 
            this.genderTextBox.Location = new System.Drawing.Point(483, 275);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(131, 27);
            this.genderTextBox.TabIndex = 8;
            // 
            // uploadPhotoButton
            // 
            this.uploadPhotoButton.Location = new System.Drawing.Point(71, 377);
            this.uploadPhotoButton.Name = "uploadPhotoButton";
            this.uploadPhotoButton.Size = new System.Drawing.Size(158, 30);
            this.uploadPhotoButton.TabIndex = 9;
            this.uploadPhotoButton.Text = "Upload Photo";
            this.uploadPhotoButton.UseVisualStyleBackColor = true;
            this.uploadPhotoButton.Click += new System.EventHandler(this.uploadPhotoButton_Click);
            // 
            // profileButton
            // 
            this.profileButton.Location = new System.Drawing.Point(540, 448);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(141, 30);
            this.profileButton.TabIndex = 10;
            this.profileButton.Text = "See Profile";
            this.profileButton.UseVisualStyleBackColor = true;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // uploadInfoButton
            // 
            this.uploadInfoButton.Location = new System.Drawing.Point(483, 337);
            this.uploadInfoButton.Name = "uploadInfoButton";
            this.uploadInfoButton.Size = new System.Drawing.Size(131, 31);
            this.uploadInfoButton.TabIndex = 11;
            this.uploadInfoButton.Text = "Save Info";
            this.uploadInfoButton.UseVisualStyleBackColor = true;
            this.uploadInfoButton.Click += new System.EventHandler(this.uploadInfoButton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 490);
            this.Controls.Add(this.uploadInfoButton);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.uploadPhotoButton);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelFirstName;
        private Label labelLastName;
        private Label labelCountry;
        private Label labelGender;
        private TextBox firstNameTextBox;
        private TextBox countryTextBox;
        private TextBox lastNameTextBox;
        private TextBox genderTextBox;
        private Button uploadPhotoButton;
        private Button profileButton;
        private Button uploadInfoButton;
    }
}