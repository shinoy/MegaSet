namespace MegaSet
{
    partial class LogonForm
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
            this.userNameLabelCtl = new DevExpress.XtraEditors.LabelControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // userNameLabelCtl
            // 
            this.userNameLabelCtl.Location = new System.Drawing.Point(37, 33);
            this.userNameLabelCtl.Name = "userNameLabelCtl";
            this.userNameLabelCtl.Size = new System.Drawing.Size(36, 13);
            this.userNameLabelCtl.TabIndex = 0;
            this.userNameLabelCtl.Text = "用户名";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(37, 64);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "用户名";
            // 
            // LogonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 113);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.userNameLabelCtl);
            this.Name = "LogonForm";
            this.Text = "登陆";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl userNameLabelCtl;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}