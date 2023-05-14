<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="Lab_8.AddStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lab 8</title>
    <link type="text/css" href="App_Themes\SiteStyles.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Students</h1>
            <p id="sName">Student Name:
                <asp:TextBox ID="stdName" runat="server" CssClass="input"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="stdNameConfirm" runat="server" ControlToValidate="stdName"
                        ForeColor="Red" Display="Dynamic" EnableClientScript="true">Required!</asp:RequiredFieldValidator>           
                <br />
            </p>
            <p id="sType">Student Type:
                <asp:DropDownList ID="dropDown" runat="server"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="selectionConfirm" runat="server" 
                ErrorMessage="Required!"
                ForeColor="Red" ControlToValidate="dropDown" 
                InitialValue="Select" Display="Dynamic"></asp:RequiredFieldValidator>
                </p>
                    <br />
                    <div id="btn"> 
                        <asp:Button ID="button" Text="Add" runat="server" CssClass="button" OnClick="addStudent_Click" />
                     </div> 
                     <asp:Panel ID="panelResults" runat="server" Visible="true">
                        <asp:Table ID="tableResults" runat="server" CssClass="table table th table td table tr" style="margin-left: 10px;">
                            <asp:TableHeaderRow>
                                <asp:TableHeaderCell>ID</asp:TableHeaderCell>
                                <asp:TableHeaderCell>Name</asp:TableHeaderCell>
                            </asp:TableHeaderRow>
                            <asp:TableRow ID="noStudent" Visible="true" CssClass="error emphsis">
                                <asp:TableCell> </asp:TableCell>
                                <asp:TableCell ID="noSt">No Student Yet!</asp:TableCell>
                         </asp:TableRow>
                        </asp:Table>
                         <a ID="hr" href="RegisterCourse.aspx">Register Courses</a>
                    </asp:Panel>
            </div>
    </form>
</body>
</html>
