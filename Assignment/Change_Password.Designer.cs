namespace Assignment
{
    partial class Change_Password
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
            this.txtNewpw = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCurrentpw = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtConfirmpw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNewpw
            // 
            this.txtNewpw.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewpw.Location = new System.Drawing.Point(353, 221);
            this.txtNewpw.Name = "txtNewpw";
            this.txtNewpw.PasswordChar = '*';
            this.txtNewpw.Size = new System.Drawing.Size(359, 43);
            this.txtNewpw.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(97, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 35);
            this.label8.TabIndex = 42;
            this.label8.Text = "New Password :";
            // 
            // txtCurrentpw
            // 
            this.txtCurrentpw.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentpw.Location = new System.Drawing.Point(353, 155);
            this.txtCurrentpw.Name = "txtCurrentpw";
            this.txtCurrentpw.PasswordChar = '*';
            this.txtCurrentpw.Size = new System.Drawing.Size(359, 43);
            this.txtCurrentpw.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(97, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 35);
            this.label7.TabIndex = 41;
            this.label7.Text = "Current Password :";
            // 
            // txtConfirmpw
            // 
            this.txtConfirmpw.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmpw.Location = new System.Drawing.Point(353, 289);
            this.txtConfirmpw.Name = "txtConfirmpw";
            this.txtConfirmpw.PasswordChar = '*';
            this.txtConfirmpw.Size = new System.Drawing.Size(359, 43);
            this.txtConfirmpw.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 35);
            this.label1.TabIndex = 44;
            this.label1.Text = "Confirm Password :";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Red;
            this.btn_back.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(582, 392);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(130, 44);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.Lime;
            this.btn_confirm.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.ForeColor = System.Drawing.Color.Black;
            this.btn_confirm.Location = new System.Drawing.Point(392, 392);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(130, 44);
            this.btn_confirm.TabIndex = 4;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(136, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(538, 72);
            this.label10.TabIndex = 79;
            this.label10.Text = "Change Your Password";
            // 
            // Change_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 491);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.txtConfirmpw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewpw);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCurrentpw);
            this.Controls.Add(this.label7);
            this.Name = "Change_Password";
            this.Text = "Change_Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewpw;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCurrentpw;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtConfirmpw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Label label10;
    }
}