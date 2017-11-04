namespace MegaSet
{
    partial class PasswordChangeForm
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
            this.oldpassTextB = new System.Windows.Forms.TextBox();
            this.newPass1TextB = new System.Windows.Forms.TextBox();
            this.newPass2TextB = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // oldpassTextB
            // 
            this.oldpassTextB.Location = new System.Drawing.Point(87, 21);
            this.oldpassTextB.Name = "oldpassTextB";
            this.oldpassTextB.PasswordChar = '*';
            this.oldpassTextB.Size = new System.Drawing.Size(129, 21);
            this.oldpassTextB.TabIndex = 0;
            // 
            // newPass1TextB
            // 
            this.newPass1TextB.Location = new System.Drawing.Point(87, 53);
            this.newPass1TextB.Name = "newPass1TextB";
            this.newPass1TextB.PasswordChar = '*';
            this.newPass1TextB.Size = new System.Drawing.Size(129, 21);
            this.newPass1TextB.TabIndex = 1;
            // 
            // newPass2TextB
            // 
            this.newPass2TextB.Location = new System.Drawing.Point(87, 85);
            this.newPass2TextB.Name = "newPass2TextB";
            this.newPass2TextB.PasswordChar = '*';
            this.newPass2TextB.Size = new System.Drawing.Size(129, 21);
            this.newPass2TextB.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(25, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 14);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "原密码";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(25, 53);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "新密码";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(25, 86);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "确认密码";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(25, 128);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "确定";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton2.Location = new System.Drawing.Point(141, 128);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "取消";
            // 
            // PasswordChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 170);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.newPass2TextB);
            this.Controls.Add(this.newPass1TextB);
            this.Controls.Add(this.oldpassTextB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "PasswordChangeForm";
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.PasswordChangeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox oldpassTextB;
        private System.Windows.Forms.TextBox newPass1TextB;
        private System.Windows.Forms.TextBox newPass2TextB;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;

    }
}