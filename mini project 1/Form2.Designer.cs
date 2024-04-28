namespace mini_project_1
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
            this.label4 = new System.Windows.Forms.Label();
            this.countryNameTextBox = new System.Windows.Forms.TextBox();
            this.townNameTextBox = new System.Windows.Forms.TextBox();
            this.countryIdTextBox = new System.Windows.Forms.TextBox();
            this.townIdTextBox = new System.Windows.Forms.TextBox();
            this.addCountryButton = new System.Windows.Forms.Button();
            this.deleteTownButton = new System.Windows.Forms.Button();
            this.updateTownButton = new System.Windows.Forms.Button();
            this.deleteCountryButton = new System.Windows.Forms.Button();
            this.updateCountryButton = new System.Windows.Forms.Button();
            this.addTownButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(592, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Country:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(570, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Town:";
            // 
            // countryNameTextBox
            // 
            this.countryNameTextBox.Location = new System.Drawing.Point(141, 116);
            this.countryNameTextBox.Name = "countryNameTextBox";
            this.countryNameTextBox.Size = new System.Drawing.Size(126, 27);
            this.countryNameTextBox.TabIndex = 4;
            // 
            // townNameTextBox
            // 
            this.townNameTextBox.Location = new System.Drawing.Point(637, 116);
            this.townNameTextBox.Name = "townNameTextBox";
            this.townNameTextBox.Size = new System.Drawing.Size(126, 27);
            this.townNameTextBox.TabIndex = 5;
            // 
            // countryIdTextBox
            // 
            this.countryIdTextBox.Location = new System.Drawing.Point(141, 55);
            this.countryIdTextBox.Name = "countryIdTextBox";
            this.countryIdTextBox.Size = new System.Drawing.Size(126, 27);
            this.countryIdTextBox.TabIndex = 6;
            // 
            // townIdTextBox
            // 
            this.townIdTextBox.Location = new System.Drawing.Point(637, 55);
            this.townIdTextBox.Name = "townIdTextBox";
            this.townIdTextBox.Size = new System.Drawing.Size(126, 27);
            this.townIdTextBox.TabIndex = 7;
            // 
            // addCountryButton
            // 
            this.addCountryButton.Location = new System.Drawing.Point(141, 203);
            this.addCountryButton.Name = "addCountryButton";
            this.addCountryButton.Size = new System.Drawing.Size(126, 30);
            this.addCountryButton.TabIndex = 8;
            this.addCountryButton.Text = "Add";
            this.addCountryButton.UseVisualStyleBackColor = true;
            this.addCountryButton.Click += new System.EventHandler(this.addCountryButton_Click);
            // 
            // deleteTownButton
            // 
            this.deleteTownButton.Location = new System.Drawing.Point(637, 363);
            this.deleteTownButton.Name = "deleteTownButton";
            this.deleteTownButton.Size = new System.Drawing.Size(126, 30);
            this.deleteTownButton.TabIndex = 10;
            this.deleteTownButton.Text = "Delete";
            this.deleteTownButton.UseVisualStyleBackColor = true;
            this.deleteTownButton.Click += new System.EventHandler(this.deleteTownButton_Click);
            // 
            // updateTownButton
            // 
            this.updateTownButton.Location = new System.Drawing.Point(637, 282);
            this.updateTownButton.Name = "updateTownButton";
            this.updateTownButton.Size = new System.Drawing.Size(126, 30);
            this.updateTownButton.TabIndex = 11;
            this.updateTownButton.Text = "Update";
            this.updateTownButton.UseVisualStyleBackColor = true;
            this.updateTownButton.Click += new System.EventHandler(this.updateTownButton_Click);
            // 
            // deleteCountryButton
            // 
            this.deleteCountryButton.Location = new System.Drawing.Point(141, 363);
            this.deleteCountryButton.Name = "deleteCountryButton";
            this.deleteCountryButton.Size = new System.Drawing.Size(126, 30);
            this.deleteCountryButton.TabIndex = 12;
            this.deleteCountryButton.Text = "Delete";
            this.deleteCountryButton.UseVisualStyleBackColor = true;
            this.deleteCountryButton.Click += new System.EventHandler(this.deleteCountryButton_Click);
            // 
            // updateCountryButton
            // 
            this.updateCountryButton.Location = new System.Drawing.Point(141, 282);
            this.updateCountryButton.Name = "updateCountryButton";
            this.updateCountryButton.Size = new System.Drawing.Size(126, 30);
            this.updateCountryButton.TabIndex = 13;
            this.updateCountryButton.Text = "Update";
            this.updateCountryButton.UseVisualStyleBackColor = true;
            this.updateCountryButton.Click += new System.EventHandler(this.updateCountryButton_Click);
            // 
            // addTownButton
            // 
            this.addTownButton.Location = new System.Drawing.Point(637, 203);
            this.addTownButton.Name = "addTownButton";
            this.addTownButton.Size = new System.Drawing.Size(126, 30);
            this.addTownButton.TabIndex = 14;
            this.addTownButton.Text = "Add";
            this.addTownButton.UseVisualStyleBackColor = true;
            this.addTownButton.Click += new System.EventHandler(this.addTownButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 468);
            this.Controls.Add(this.addTownButton);
            this.Controls.Add(this.updateCountryButton);
            this.Controls.Add(this.deleteCountryButton);
            this.Controls.Add(this.updateTownButton);
            this.Controls.Add(this.deleteTownButton);
            this.Controls.Add(this.addCountryButton);
            this.Controls.Add(this.townIdTextBox);
            this.Controls.Add(this.countryIdTextBox);
            this.Controls.Add(this.townNameTextBox);
            this.Controls.Add(this.countryNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox countryNameTextBox;
        private TextBox townNameTextBox;
        private TextBox countryIdTextBox;
        private TextBox townIdTextBox;
        private Button addCountryButton;
        private Button deleteTownButton;
        private Button updateTownButton;
        private Button deleteCountryButton;
        private Button updateCountryButton;
        private Button addTownButton;
    }
}