using System;
using System.Web.UI;
using System.IO;

namespace IMMustExam
{
    public partial class _Default : Page
    {
        public string messageUL = null;
        public string messageDL = null;
        public string messageIP = null;
        public string userIP = null;
        public int thisYear = DateTime.Now.Year;
        public int TWYear;

        protected void Page_Load(object sender, EventArgs e)
        {
            TWYear = thisYear - 1911;
            try
            {
                userIP = Request.UserHostAddress.Substring(0, 11);
                IPCheck();
            }
            catch
            {
                IPCheck();
            }           
        }

        protected void IPCheck()
        {
            if (userIP != "120.105.96." && userIP != "120.105.97." && userIP != "120.105.98.")
            {
                ButtonDownload.Enabled = false;
                ButtonUpload.Enabled = false;
                messageIP = "- 您並非使用本系電腦進行連線，已被禁止存取 -";
            }
        }

        protected void ButtonDownload_Click(object sender, EventArgs e)
        {
            string year = (thisYear).ToString();
            try
            {
                string filePathDL = "/Asset/"+ year + "商管術科考題.docx";
                Response.Redirect(filePathDL);
            }
            catch
            {
                messageDL = "- 遇到狀況外問題，請舉手讓試場工作人員協助下載考卷 -";
            }
        }

        protected void ButtonUpload_Click(object sender, EventArgs e)
        {
            try
            {
                if (FileUpload1.HasFile)
                {
                    string filePath = "C:/inetpub/wwwroot/Upload/";
                    string fileName = FileUpload1.PostedFile.FileName;

                    string fileExtension = Path.GetExtension(fileName);
                    if (fileExtension.ToLower() == ".docx")
                    {
                        FileUpload1.SaveAs(filePath + fileName);
                        Response.Redirect("UploadSuccess.aspx");
                    }
                    else messageUL = "- 上傳失敗(僅限上傳 *.docx 檔) -";                                        
                }
                else messageUL = "- 請選擇要上傳的檔案 -";
            }
            catch
            {
                messageUL = "- 遇到狀況外問題，請舉手讓試場工作人員協助交卷 -";
            }           
        }
    }
}