
namespace User_Registration
{
    partial class Userlist
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
            this.userListDataGridView = new System.Windows.Forms.DataGridView();
            this.userREgistration = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.userListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userListDataGridView
            // 
            this.userListDataGridView.AllowUserToAddRows = false;
            this.userListDataGridView.AllowUserToDeleteRows = false;
            this.userListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userListDataGridView.Location = new System.Drawing.Point(40, 36);
            this.userListDataGridView.Name = "userListDataGridView";
            this.userListDataGridView.ReadOnly = true;
            this.userListDataGridView.Size = new System.Drawing.Size(773, 226);
            this.userListDataGridView.TabIndex = 0;
            // 
            // userREgistration
            // 
            this.userREgistration.AutoSize = true;
            this.userREgistration.Location = new System.Drawing.Point(631, 276);
            this.userREgistration.Name = "userREgistration";
            this.userREgistration.Size = new System.Drawing.Size(76, 13);
            this.userREgistration.TabIndex = 1;
            this.userREgistration.TabStop = true;
            this.userREgistration.Text = "Add New User";
            this.userREgistration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.userREgistration_LinkClicked);
            // 
            // Userlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 298);
            this.Controls.Add(this.userREgistration);
            this.Controls.Add(this.userListDataGridView);
            this.Name = "Userlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Userlist_FormClosing);
            this.Load += new System.EventHandler(this.Userlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView userListDataGridView;
        private System.Windows.Forms.LinkLabel userREgistration;
    }
}