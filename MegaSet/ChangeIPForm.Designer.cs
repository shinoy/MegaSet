namespace MegaSet
{
    partial class ChangeIPForm
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
            this.spinEdit4 = new DevExpress.XtraEditors.SpinEdit();
            this.spinEdit3 = new DevExpress.XtraEditors.SpinEdit();
            this.spinEdit2 = new DevExpress.XtraEditors.SpinEdit();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.ChangeBtn = new DevExpress.XtraEditors.SimpleButton();
            this.CancelBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // spinEdit4
            // 
            this.spinEdit4.EditValue = new decimal(new int[] {
            192,
            0,
            0,
            0});
            this.spinEdit4.Location = new System.Drawing.Point(186, 23);
            this.spinEdit4.Name = "spinEdit4";
            this.spinEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit4.Properties.IsFloatValue = false;
            this.spinEdit4.Properties.Mask.EditMask = "N00";
            this.spinEdit4.Properties.MaxValue = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.spinEdit4.Size = new System.Drawing.Size(48, 20);
            this.spinEdit4.TabIndex = 13;
            // 
            // spinEdit3
            // 
            this.spinEdit3.EditValue = new decimal(new int[] {
            192,
            0,
            0,
            0});
            this.spinEdit3.Location = new System.Drawing.Point(132, 23);
            this.spinEdit3.Name = "spinEdit3";
            this.spinEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit3.Properties.IsFloatValue = false;
            this.spinEdit3.Properties.Mask.EditMask = "N00";
            this.spinEdit3.Properties.MaxValue = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.spinEdit3.Size = new System.Drawing.Size(48, 20);
            this.spinEdit3.TabIndex = 12;
            // 
            // spinEdit2
            // 
            this.spinEdit2.EditValue = new decimal(new int[] {
            192,
            0,
            0,
            0});
            this.spinEdit2.Location = new System.Drawing.Point(78, 23);
            this.spinEdit2.Name = "spinEdit2";
            this.spinEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit2.Properties.IsFloatValue = false;
            this.spinEdit2.Properties.Mask.EditMask = "N00";
            this.spinEdit2.Properties.MaxValue = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.spinEdit2.Size = new System.Drawing.Size(48, 20);
            this.spinEdit2.TabIndex = 11;
            // 
            // spinEdit1
            // 
            this.spinEdit1.EditValue = new decimal(new int[] {
            192,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(24, 23);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit1.Properties.IsFloatValue = false;
            this.spinEdit1.Properties.Mask.EditMask = "N00";
            this.spinEdit1.Properties.MaxValue = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.spinEdit1.Size = new System.Drawing.Size(48, 20);
            this.spinEdit1.TabIndex = 10;
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.Location = new System.Drawing.Point(34, 68);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(75, 23);
            this.ChangeBtn.TabIndex = 14;
            this.ChangeBtn.Text = "设置";
            this.ChangeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(149, 68);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 15;
            this.CancelBtn.Text = "取消";
            // 
            // ChangeIPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 112);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ChangeBtn);
            this.Controls.Add(this.spinEdit4);
            this.Controls.Add(this.spinEdit3);
            this.Controls.Add(this.spinEdit2);
            this.Controls.Add(this.spinEdit1);
            this.Name = "ChangeIPForm";
            this.Text = "修改节点IP";
            this.Load += new System.EventHandler(this.ChangeIPForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SpinEdit spinEdit4;
        private DevExpress.XtraEditors.SpinEdit spinEdit3;
        private DevExpress.XtraEditors.SpinEdit spinEdit2;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private DevExpress.XtraEditors.SimpleButton ChangeBtn;
        private DevExpress.XtraEditors.SimpleButton CancelBtn;
    }
}