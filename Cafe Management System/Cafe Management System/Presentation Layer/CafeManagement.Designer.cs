
namespace Cafe_Management_System.Presentation_Layer
{
    partial class CafeManagement
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cafeListDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addCafeButton = new System.Windows.Forms.Button();
            this.addCafeNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.deleteCafeButton = new System.Windows.Forms.Button();
            this.deleteCafeIdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.updateCafeButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.updateCafeNameTextBox = new System.Windows.Forms.TextBox();
            this.searchCafeIdTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cafeListDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cafeListDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(466, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cafe List";
            // 
            // cafeListDataGridView
            // 
            this.cafeListDataGridView.AllowUserToAddRows = false;
            this.cafeListDataGridView.AllowUserToDeleteRows = false;
            this.cafeListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cafeListDataGridView.Location = new System.Drawing.Point(12, 33);
            this.cafeListDataGridView.Name = "cafeListDataGridView";
            this.cafeListDataGridView.ReadOnly = true;
            this.cafeListDataGridView.Size = new System.Drawing.Size(301, 156);
            this.cafeListDataGridView.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addCafeButton);
            this.groupBox2.Controls.Add(this.addCafeNameTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 91);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add New Cafe";
            // 
            // addCafeButton
            // 
            this.addCafeButton.Location = new System.Drawing.Point(58, 59);
            this.addCafeButton.Name = "addCafeButton";
            this.addCafeButton.Size = new System.Drawing.Size(69, 24);
            this.addCafeButton.TabIndex = 2;
            this.addCafeButton.Text = "Add";
            this.addCafeButton.UseVisualStyleBackColor = true;
            this.addCafeButton.Click += new System.EventHandler(this.addCafeButton_Click);
            // 
            // addCafeNameTextBox
            // 
            this.addCafeNameTextBox.Location = new System.Drawing.Point(85, 33);
            this.addCafeNameTextBox.Name = "addCafeNameTextBox";
            this.addCafeNameTextBox.Size = new System.Drawing.Size(112, 20);
            this.addCafeNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cafe Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.deleteCafeButton);
            this.groupBox3.Controls.Add(this.deleteCafeIdTextBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 169);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(207, 91);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete Cafe";
            // 
            // deleteCafeButton
            // 
            this.deleteCafeButton.Location = new System.Drawing.Point(58, 59);
            this.deleteCafeButton.Name = "deleteCafeButton";
            this.deleteCafeButton.Size = new System.Drawing.Size(69, 24);
            this.deleteCafeButton.TabIndex = 2;
            this.deleteCafeButton.Text = "Delete";
            this.deleteCafeButton.UseVisualStyleBackColor = true;
            this.deleteCafeButton.Click += new System.EventHandler(this.deleteCafeButton_Click);
            // 
            // deleteCafeIdTextBox
            // 
            this.deleteCafeIdTextBox.Location = new System.Drawing.Point(85, 33);
            this.deleteCafeIdTextBox.Name = "deleteCafeIdTextBox";
            this.deleteCafeIdTextBox.Size = new System.Drawing.Size(112, 20);
            this.deleteCafeIdTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cafe ID";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.updateCafeButton);
            this.groupBox4.Controls.Add(this.searchButton);
            this.groupBox4.Controls.Add(this.updateCafeNameTextBox);
            this.groupBox4.Controls.Add(this.searchCafeIdTextBox);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(12, 288);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(206, 160);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Update Cafe";
            // 
            // updateCafeButton
            // 
            this.updateCafeButton.Location = new System.Drawing.Point(58, 126);
            this.updateCafeButton.Name = "updateCafeButton";
            this.updateCafeButton.Size = new System.Drawing.Size(69, 24);
            this.updateCafeButton.TabIndex = 6;
            this.updateCafeButton.Text = "Update";
            this.updateCafeButton.UseVisualStyleBackColor = true;
            this.updateCafeButton.Click += new System.EventHandler(this.updateCafeButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(58, 69);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(69, 24);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // updateCafeNameTextBox
            // 
            this.updateCafeNameTextBox.Location = new System.Drawing.Point(85, 97);
            this.updateCafeNameTextBox.Name = "updateCafeNameTextBox";
            this.updateCafeNameTextBox.Size = new System.Drawing.Size(112, 20);
            this.updateCafeNameTextBox.TabIndex = 4;
            this.updateCafeNameTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // searchCafeIdTextBox
            // 
            this.searchCafeIdTextBox.Location = new System.Drawing.Point(85, 43);
            this.searchCafeIdTextBox.Name = "searchCafeIdTextBox";
            this.searchCafeIdTextBox.Size = new System.Drawing.Size(112, 20);
            this.searchCafeIdTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cafe Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cafe ID";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(657, 22);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(107, 39);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // CafeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CafeManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cafe Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CafeManagement_FormClosing);
            this.Load += new System.EventHandler(this.CafeManagement_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cafeListDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView cafeListDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addCafeButton;
        private System.Windows.Forms.TextBox addCafeNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button deleteCafeButton;
        private System.Windows.Forms.TextBox deleteCafeIdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox updateCafeNameTextBox;
        private System.Windows.Forms.TextBox searchCafeIdTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button updateCafeButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button backButton;
    }
}