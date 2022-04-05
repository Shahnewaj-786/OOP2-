
namespace Cafe_Management_System.Presentation_Layer
{
    partial class OrderManagement
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
            this.orderListDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.addOrderComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addOrderPriceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addOrderNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.deleteOrderButton = new System.Windows.Forms.Button();
            this.deleteOrderIdTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderListDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.orderListDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(401, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order List";
            // 
            // orderListDataGridView
            // 
            this.orderListDataGridView.AllowUserToAddRows = false;
            this.orderListDataGridView.AllowUserToDeleteRows = false;
            this.orderListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderListDataGridView.Location = new System.Drawing.Point(12, 28);
            this.orderListDataGridView.Name = "orderListDataGridView";
            this.orderListDataGridView.ReadOnly = true;
            this.orderListDataGridView.Size = new System.Drawing.Size(363, 152);
            this.orderListDataGridView.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Controls.Add(this.addOrderComboBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.addOrderPriceTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.addOrderNameTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(16, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 176);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add New Order";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(71, 144);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(91, 26);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addOrderComboBox
            // 
            this.addOrderComboBox.FormattingEnabled = true;
            this.addOrderComboBox.Location = new System.Drawing.Point(91, 105);
            this.addOrderComboBox.Name = "addOrderComboBox";
            this.addOrderComboBox.Size = new System.Drawing.Size(142, 21);
            this.addOrderComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cafe";
            // 
            // addOrderPriceTextBox
            // 
            this.addOrderPriceTextBox.Location = new System.Drawing.Point(91, 73);
            this.addOrderPriceTextBox.Name = "addOrderPriceTextBox";
            this.addOrderPriceTextBox.Size = new System.Drawing.Size(142, 20);
            this.addOrderPriceTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            // 
            // addOrderNameTextBox
            // 
            this.addOrderNameTextBox.Location = new System.Drawing.Point(91, 37);
            this.addOrderNameTextBox.Name = "addOrderNameTextBox";
            this.addOrderNameTextBox.Size = new System.Drawing.Size(142, 20);
            this.addOrderNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.deleteOrderButton);
            this.groupBox3.Controls.Add(this.deleteOrderIdTextBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(18, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(268, 95);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete Order";
            // 
            // deleteOrderButton
            // 
            this.deleteOrderButton.Location = new System.Drawing.Point(69, 58);
            this.deleteOrderButton.Name = "deleteOrderButton";
            this.deleteOrderButton.Size = new System.Drawing.Size(91, 26);
            this.deleteOrderButton.TabIndex = 7;
            this.deleteOrderButton.Text = "Delete";
            this.deleteOrderButton.UseVisualStyleBackColor = true;
            this.deleteOrderButton.Click += new System.EventHandler(this.deleteOrderButton_Click);
            // 
            // deleteOrderIdTextBox
            // 
            this.deleteOrderIdTextBox.Location = new System.Drawing.Point(89, 25);
            this.deleteOrderIdTextBox.Name = "deleteOrderIdTextBox";
            this.deleteOrderIdTextBox.Size = new System.Drawing.Size(142, 20);
            this.deleteOrderIdTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Order ID";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(648, 32);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(102, 38);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // OrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "OrderManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderManagement_FormClosing);
            this.Load += new System.EventHandler(this.OrderManagement_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderListDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView orderListDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox addOrderComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addOrderPriceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addOrderNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button deleteOrderButton;
        private System.Windows.Forms.TextBox deleteOrderIdTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button backButton;
    }
}