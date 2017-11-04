namespace MegaSet
{
    partial class LocationsEditor
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
            this.components = new System.ComponentModel.Container();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.rootLocationDropDownBtn = new DevExpress.XtraEditors.DropDownButton();
            this.rootListPopMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.rootBarManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.rootListPopMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootBarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(226, 34);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 16);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "上级";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // rootLocationDropDownBtn
            // 
            this.rootLocationDropDownBtn.DropDownControl = this.rootListPopMenu;
            this.rootLocationDropDownBtn.Enabled = false;
            this.rootLocationDropDownBtn.Location = new System.Drawing.Point(30, 29);
            this.rootLocationDropDownBtn.Name = "rootLocationDropDownBtn";
            this.rootLocationDropDownBtn.Size = new System.Drawing.Size(156, 21);
            this.rootLocationDropDownBtn.TabIndex = 2;
            // 
            // rootListPopMenu
            // 
            this.rootListPopMenu.Manager = this.rootBarManager;
            this.rootListPopMenu.Name = "rootListPopMenu";
            // 
            // rootBarManager
            // 
            this.rootBarManager.DockControls.Add(this.barDockControlTop);
            this.rootBarManager.DockControls.Add(this.barDockControlBottom);
            this.rootBarManager.DockControls.Add(this.barDockControlLeft);
            this.rootBarManager.DockControls.Add(this.barDockControlRight);
            this.rootBarManager.Form = this;
            this.rootBarManager.MaxItemId = 0;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(307, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 130);
            this.barDockControlBottom.Size = new System.Drawing.Size(307, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 130);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(307, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 130);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(211, 72);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 26);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "添加";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textEdit1.Location = new System.Drawing.Point(30, 71);
            this.textEdit1.MinimumSize = new System.Drawing.Size(112, 27);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.AutoHeight = false;
            this.textEdit1.Size = new System.Drawing.Size(157, 27);
            this.textEdit1.TabIndex = 0;
            // 
            // LocationsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(307, 130);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.rootLocationDropDownBtn);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "LocationsEditor";
            this.Text = "添加站点";
            this.Load += new System.EventHandler(this.LocationsEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rootListPopMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootBarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.CheckBox checkBox1;
        private DevExpress.XtraEditors.DropDownButton rootLocationDropDownBtn;
        private DevExpress.XtraBars.PopupMenu rootListPopMenu;
        private DevExpress.XtraBars.BarManager rootBarManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;


    }
}