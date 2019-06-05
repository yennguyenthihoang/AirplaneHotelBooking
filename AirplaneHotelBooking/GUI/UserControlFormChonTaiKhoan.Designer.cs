namespace Nhom04_DiaDiemDuLich.GUI
{
    partial class UserControlFormChonTaiKhoan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.BackgroundImage = global::Nhom04_DiaDiemDuLich.Properties.Resources.Admin_min_icon;
            this.buttonAdmin.Location = new System.Drawing.Point(337, 87);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(128, 128);
            this.buttonAdmin.TabIndex = 1;
            this.buttonAdmin.UseVisualStyleBackColor = true;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // buttonUser
            // 
            this.buttonUser.BackColor = System.Drawing.Color.Transparent;
            this.buttonUser.BackgroundImage = global::Nhom04_DiaDiemDuLich.Properties.Resources.User_Group_icon;
            this.buttonUser.Location = new System.Drawing.Point(110, 87);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(128, 128);
            this.buttonUser.TabIndex = 0;
            this.buttonUser.UseVisualStyleBackColor = false;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(106, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Chức năng User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(333, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Chức năng Admin";
            // 
            // UserControlFormChonTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.buttonUser);
            this.Name = "UserControlFormChonTaiKhoan";
            this.Size = new System.Drawing.Size(570, 371);
            this.Load += new System.EventHandler(this.UserControlFormChonTaiKhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
