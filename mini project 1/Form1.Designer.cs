namespace mini_project_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CountriesListBox = new System.Windows.Forms.ListBox();
            this.TownsListBox = new System.Windows.Forms.ListBox();
            this.adminFormButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.databaseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CountriesListBox
            // 
            this.CountriesListBox.FormattingEnabled = true;
            this.CountriesListBox.ItemHeight = 20;
            this.CountriesListBox.Location = new System.Drawing.Point(63, 70);
            this.CountriesListBox.Name = "CountriesListBox";
            this.CountriesListBox.Size = new System.Drawing.Size(198, 264);
            this.CountriesListBox.TabIndex = 0;
            // 
            // TownsListBox
            // 
            this.TownsListBox.FormattingEnabled = true;
            this.TownsListBox.ItemHeight = 20;
            this.TownsListBox.Location = new System.Drawing.Point(555, 70);
            this.TownsListBox.Name = "TownsListBox";
            this.TownsListBox.Size = new System.Drawing.Size(198, 264);
            this.TownsListBox.TabIndex = 1;
            // 
            // adminFormButton
            // 
            this.adminFormButton.Location = new System.Drawing.Point(337, 362);
            this.adminFormButton.Name = "adminFormButton";
            this.adminFormButton.Size = new System.Drawing.Size(138, 62);
            this.adminFormButton.TabIndex = 2;
            this.adminFormButton.Text = "Admin";
            this.adminFormButton.UseVisualStyleBackColor = true;
            this.adminFormButton.Visible = false;
            this.adminFormButton.Click += new System.EventHandler(this.adminFormButton_Click);
            // 
            // profileButton
            // 
            this.profileButton.Location = new System.Drawing.Point(83, 362);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(138, 62);
            this.profileButton.TabIndex = 3;
            this.profileButton.Text = "Profile";
            this.profileButton.UseVisualStyleBackColor = true;
            this.profileButton.Visible = false;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // databaseButton
            // 
            this.databaseButton.Location = new System.Drawing.Point(599, 362);
            this.databaseButton.Name = "databaseButton";
            this.databaseButton.Size = new System.Drawing.Size(138, 62);
            this.databaseButton.TabIndex = 4;
            this.databaseButton.Text = "Database";
            this.databaseButton.UseVisualStyleBackColor = true;
            this.databaseButton.Visible = false;
            this.databaseButton.Click += new System.EventHandler(this.databaseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.databaseButton);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.adminFormButton);
            this.Controls.Add(this.TownsListBox);
            this.Controls.Add(this.CountriesListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox CountriesListBox;
        private ListBox TownsListBox;
        private Button adminFormButton;
        private Button profileButton;
        private Button databaseButton;
    }
}