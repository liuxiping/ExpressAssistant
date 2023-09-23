using ExpressAssistant.Model;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;
using ZXing.QrCode;

namespace ExpressAssistant.ViewModel
{
    public class QRCodeViewModel
    {

        /// <summary>
        /// 生产二维吗
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="version"></param>
        /// <param name="pixel"></param>
        /// <param name="icon_path"></param>
        /// <param name="icon_size"></param>
        /// <param name="icon_border"></param>
        /// <param name="white_edge"></param>
        /// <returns></returns>
        public Image GenerateQRCode(string msg, int pixel)
        {
            Image image = new BarcodeWriter()
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new QrCodeEncodingOptions
                {
                    DisableECI = true,
                    CharacterSet = "UTF-8",
                    Width = 400,
                    Height = 400,
                    Margin = 0
                }
            }.Write(msg);
            return image;

        }


        public Image GenerateBarCode(string msg )
        {
            Image image = new BarcodeWriter()
            {
                Format = BarcodeFormat.CODE_128,
                Options = new QrCodeEncodingOptions
                {
                    DisableECI = true,
                    CharacterSet = "UTF-8",
                    Width = 400,
                    Height = 100,
                    Margin = 0
                }
            }.Write(msg);
            return image;
        }

        /// <summary>
        /// 导入数据
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public List<ExpressContext> ReadExpressContext(string fileName)
        {

            List<ExpressContext> data = new List<ExpressContext>();
            //excel工作表
            ISheet sheet = null;
            //数据开始行(排除标题行)
            int startRow = 2;

            //根据文件流创建excel数据结构,NPOI的工厂类WorkbookFactory会自动识别excel版本，创建出不同的excel数据结构
            IWorkbook workbook = WorkbookFactory.Create(fileName);
            sheet = workbook.GetSheetAt(0);

            int numIndex = 0;
            int siteNameIndex = 1;
            int expressNumIndex = 2;

            if (sheet != null)
            {
                //
                IRow headerRow = sheet.GetRow(1);
                //一行最后一个cell的编号 即总的列数
                int cellCount = headerRow.LastCellNum;

                for (int i = headerRow.FirstCellNum; i < cellCount; ++i)
                {
                    ICell cell = headerRow.GetCell(i);
                    if (cell.StringCellValue.Trim() == "序号")
                    {
                        numIndex = i;
                    }
                    if (cell.StringCellValue.Trim() == "网点名称")
                    {
                        siteNameIndex = i;
                    }
                    if (cell.StringCellValue.Trim() == "运单号")
                    {
                        expressNumIndex = i;
                    }

                }

                //最后一列的标号
                int rowCount = sheet.LastRowNum;
                for (int i = startRow; i <= rowCount; ++i)
                {
                    IRow row = sheet.GetRow(i);
                    if (row == null || row.FirstCellNum < 0) continue; //没有数据的行默认是null　　　　　　　

                    ExpressContext c = new ExpressContext();
                    c.Num = row.GetCell(numIndex).ToString().Trim();
                    c.SiteName = row.GetCell(siteNameIndex).ToString().Trim();
                    c.ExpressNum = row.GetCell(expressNumIndex).ToString().Trim();

                    data.Add(c);
                }
            }
            return data;

        }
    }
}
