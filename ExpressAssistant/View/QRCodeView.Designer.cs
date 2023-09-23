
namespace ExpressAssistant.View
{
    partial class QRCodeView
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImportInfo = new System.Windows.Forms.Button();
            this.dgvExpressContext = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSiteName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpressNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picORCode = new System.Windows.Forms.PictureBox();
            this.colNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpressContext)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picORCode)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(910, 519);
            this.splitContainer1.SplitterDistance = 634;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvExpressContext);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 519);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "快递单号信息";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnImportInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 470);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 46);
            this.panel1.TabIndex = 1;
            // 
            // btnImportInfo
            // 
            this.btnImportInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportInfo.Location = new System.Drawing.Point(515, 7);
            this.btnImportInfo.Name = "btnImportInfo";
            this.btnImportInfo.Size = new System.Drawing.Size(100, 30);
            this.btnImportInfo.TabIndex = 0;
            this.btnImportInfo.Text = "导入快递信息";
            this.btnImportInfo.UseVisualStyleBackColor = true;
            this.btnImportInfo.Click += new System.EventHandler(this.btnImportInfo_Click);
            // 
            // dgvExpressContext
            // 
            this.dgvExpressContext.AllowUserToAddRows = false;
            this.dgvExpressContext.AllowUserToDeleteRows = false;
            this.dgvExpressContext.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpressContext.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.colSiteName,
            this.colExpressNum});
            this.dgvExpressContext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExpressContext.Location = new System.Drawing.Point(3, 19);
            this.dgvExpressContext.MultiSelect = false;
            this.dgvExpressContext.Name = "dgvExpressContext";
            this.dgvExpressContext.ReadOnly = true;
            this.dgvExpressContext.RowTemplate.Height = 25;
            this.dgvExpressContext.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpressContext.Size = new System.Drawing.Size(628, 451);
            this.dgvExpressContext.TabIndex = 0;
            this.dgvExpressContext.SelectionChanged += new System.EventHandler(this.dgvExpressContext_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Num";
            this.dataGridViewTextBoxColumn1.HeaderText = "序号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // colSiteName
            // 
            this.colSiteName.DataPropertyName = "SiteName";
            this.colSiteName.HeaderText = "网点名称";
            this.colSiteName.Name = "colSiteName";
            this.colSiteName.ReadOnly = true;
            this.colSiteName.Width = 200;
            // 
            // colExpressNum
            // 
            this.colExpressNum.DataPropertyName = "ExpressNum";
            this.colExpressNum.HeaderText = "快递单号";
            this.colExpressNum.Name = "colExpressNum";
            this.colExpressNum.ReadOnly = true;
            this.colExpressNum.Width = 200;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picORCode);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 519);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "二维吗";
            // 
            // picORCode
            // 
            this.picORCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picORCode.Location = new System.Drawing.Point(3, 19);
            this.picORCode.Name = "picORCode";
            this.picORCode.Size = new System.Drawing.Size(266, 497);
            this.picORCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picORCode.TabIndex = 0;
            this.picORCode.TabStop = false;
            // 
            // colNum
            // 
            this.colNum.HeaderText = "序号";
            this.colNum.Name = "colNum";
            // 
            // colSite
            // 
            this.colSite.HeaderText = "网点";
            this.colSite.Name = "colSite";
            // 
            // QRCodeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "QRCodeView";
            this.Size = new System.Drawing.Size(910, 519);
            this.Load += new System.EventHandler(this.QRCodeView_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpressContext)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picORCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnImportInfo;
        private System.Windows.Forms.DataGridView dgvExpressContext;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picORCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSite;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSiteName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpressNum;
    }
}
