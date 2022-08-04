using System;
using System.Web.UI;

namespace IMMustExam
{
    public partial class _Default : Page
    {
        public string messageUL = null;
        public string messageDL = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ButtonDownload_Click(object sender, EventArgs e)
        {
            try
            {
                string filePathDL = "/Asset/2023術科原始檔.docx";
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

                    FileUpload1.SaveAs(filePath + fileName);

                    Response.Redirect("UploadSuccess.aspx");                    
                }
                else
                {
                    messageUL = "- 請選擇要上傳的檔案 -";
                }
            }
            catch
            {
                messageUL = "- 遇到狀況外問題，請舉手讓試場工作人員協助交卷 -";
            }            
        }
    }
}