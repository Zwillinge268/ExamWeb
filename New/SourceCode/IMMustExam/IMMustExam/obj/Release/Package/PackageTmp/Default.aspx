<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="IMMustExam._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <center><h1>- <%=TWYear %>學年度明新科技大學資管系 -</h1></center>
    <center><h2>- 四技甄選【商管群】術科考試 -</h2></center>
    <br /><br />

<!------------------------------------------------------------------------------------------>

<div class="panel panel-info">
    <div class="panel-heading">
        <h1 align="center">- 考題放置區 -</h1>
    </div>
    <div class="panel-body">
        <center>
            <br /><br />
            <asp:Button ID="ButtonDownload" runat="server" Text="下載試題" OnClick="ButtonDownload_Click" CssClass="btn btn-default bgGray" Font-Size="Large"/>
            <a href="Example.html" target="_blank" class="btn btn-default bgGray" style="font-size:large ">成品展示</a>
            <br /><br />
            <span style="color:red"><h4><b><%= messageDL %></b></h4></span>
        </center>
    </div>
</div>

<!------------------------------------------------------------------------------------------->

<div class="panel panel-info">
    <div class="panel-heading">
        <h1 align="center">- 檔案上傳區 -</h1>
    </div>
    <div class="panel-body">
        <center>
            <br />
            <h4>請將試題檔案檔名更改為答題檔案檔名 <font color="red">准考證號碼 - 姓名</font></h4>
            <h4>例如：2080260099-曾國霖.docx</h4>
            <br /><br />
            <asp:FileUpload ID="FileUpload1" runat="server" Font-Size="Large" accept=".docx"/>
            <br />
            <asp:Button ID="ButtonUpload" runat="server" Text="上傳檔案" OnClick="ButtonUpload_Click" Font-Size="Large"/>
            <br /><br />
            <span style="color:red"><h4><b><%= messageUL %></b></h4></span>
        </center>
    </div>
</div>

<!------------------------------------------------------------------------------------------->

    <center><span style="color:red"><h3><b><%= messageIP %></b></h3></span></center>

</asp:Content>