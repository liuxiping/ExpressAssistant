
namespace ExpressAssistant
{
    partial class frmShell
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ExpressAssistant.ViewModel.QRCodeViewModel qrCodeViewModel1 = new ExpressAssistant.ViewModel.QRCodeViewModel();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShell));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabQRCode = new System.Windows.Forms.TabPage();
            this.qrCodeView1 = new ExpressAssistant.View.QRCodeView();
            this.tabMain.SuspendLayout();
            this.tabQRCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabQRCode);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Margin = new System.Windows.Forms.Padding(4);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1130, 662);
            this.tabMain.TabIndex = 1;
            // 
            // tabQRCode
            // 
            this.tabQRCode.Controls.Add(this.qrCodeView1);
            this.tabQRCode.Location = new System.Drawing.Point(4, 30);
            this.tabQRCode.Margin = new System.Windows.Forms.Padding(4);
            this.tabQRCode.Name = "tabQRCode";
            this.tabQRCode.Padding = new System.Windows.Forms.Padding(4);
            this.tabQRCode.Size = new System.Drawing.Size(1122, 628);
            this.tabQRCode.TabIndex = 0;
            this.tabQRCode.Text = "批量条码生成器";
            this.tabQRCode.UseVisualStyleBackColor = true;
            // 
            // qrCodeView1
            // 
            this.qrCodeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qrCodeView1.Location = new System.Drawing.Point(4, 4);
            this.qrCodeView1.Margin = new System.Windows.Forms.Padding(4);
            this.qrCodeView1.Model = qrCodeViewModel1;
            this.qrCodeView1.Name = "qrCodeView1";
            this.qrCodeView1.Size = new System.Drawing.Size(1114, 620);
            this.qrCodeView1.TabIndex = 0;
            // 
            // frmShell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 662);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmShell";
            this.Text = "ExpressAssistant";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabMain.ResumeLayout(false);
            this.tabQRCode.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabQRCode;
        private View.QRCodeView qrCodeView1;
    }
}

