namespace Nhom04_DiaDiemDuLich.GUI
{
    partial class UserControlFormKetNoi
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
            this.textBoxDBName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLoginName = new System.Windows.Forms.TextBox();
            this.textBoxIpAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKetNoi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDBName
            // 
            this.textBoxDBName.Location = new System.Drawing.Point(255, 192);
            this.textBoxDBName.Name = "textBoxDBName";
            this.textBoxDBName.Size = new System.Drawing.Size(188, 20);
            this.textBoxDBName.TabIndex = 18;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(255, 152);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(188, 20);
            this.textBoxPassword.TabIndex = 17;
            // 
            // textBoxLoginName
            // 
            this.textBoxLoginName.Location = new System.Drawing.Point(255, 107);
            this.textBoxLoginName.Name = "textBoxLoginName";
            this.textBoxLoginName.Size = new System.Drawing.Size(188, 20);
            this.textBoxLoginName.TabIndex = 16;
            // 
            // textBoxIpAddress
            // 
            this.textBoxIpAddress.Location = new System.Drawing.Point(255, 66);
            this.textBoxIpAddress.Name = "textBoxIpAddress";
            this.textBoxIpAddress.Size = new System.Drawing.Size(188, 20);
            this.textBoxIpAddress.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Server Ip Adresss:";
            // 
            // buttonKetNoi
            // 
            this.buttonKetNoi.BackgroundImage = global::Nhom04_DiaDiemDuLich.Properties.Resources.ConnectDB;
            this.buttonKetNoi.FlatAppearance.BorderSize = 0;
            this.buttonKetNoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKetNoi.Location = new System.Drawing.Point(328, 240);
            this.buttonKetNoi.Name = "buttonKetNoi";
            this.buttonKetNoi.Size = new System.Drawing.Size(72, 68);
            this.buttonKetNoi.TabIndex = 10;
            this.buttonKetNoi.UseVisualStyleBackColor = true;
            this.buttonKetNoi.Click += new System.EventHandler(this.buttonKetNoi_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Nhom04_DiaDiemDuLich.Properties.Resources.du;
            this.pictureBox1.Location = new System.Drawing.Point(412, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 169);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(91, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Login Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(91, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(91, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Database Name:";
            // 
            // UserControlFormKetNoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDBName);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLoginName);
            this.Controls.Add(this.textBoxIpAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKetNoi);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControlFormKetNoi";
            this.Size = new System.Drawing.Size(685, 381);
            this.Load += new System.EventHandler(this.UserControlFormKetNoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxDBName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLoginName;
        private System.Windows.Forms.TextBox textBoxIpAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKetNoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

    }
}
