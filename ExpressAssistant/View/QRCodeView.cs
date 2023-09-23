using ExpressAssistant.Model;
using ExpressAssistant.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpressAssistant.View
{
    public partial class QRCodeView : UserControl
    {
        public QRCodeView()
        {
            InitializeComponent();

            Model = new QRCodeViewModel();
        }

        public QRCodeViewModel Model { get; set; }

        private void QRCodeView_Load(object sender, EventArgs e)
        {
          
        }

        private void btnImportInfo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = " Excel文件|*.xlsx";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                try
                {
                    var data = Model.ReadExpressContext(fileName);
                    dgvExpressContext.DataSource = data;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误提示！",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
        }

        private void dgvExpressContext_SelectionChanged(object sender, EventArgs e)
        {
           if(dgvExpressContext.SelectedRows != null && dgvExpressContext.SelectedRows.Count>0)
            {
                ExpressContext ctx = (ExpressContext)dgvExpressContext.SelectedRows[0].DataBoundItem;
                picORCode.Image = Model.GenerateBarCode(ctx.ExpressNum);
            }

        }
    }
}
