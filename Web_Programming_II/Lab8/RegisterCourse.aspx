<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterCourse.aspx.cs" Inherits="Lab_8.RegisterCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lab 8</title>
    <link type="text/css" href="App_Themes/SiteStyles.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Algonquin College Course Registration</h1>
            <p>Student Name:
                <asp:DropDownList ID="stdName" runat="server" AutoPostBack ="true" OnSelectedIndexChanged ="index_OnChange">
                <asp:ListItem Text="Select..." Value="Select" />
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="stdNameCheck" runat="server" ErrorMessage="Required!"
                ForeColor="Red" ControlToValidate="stdName" 
                InitialValue="Select" Display="Dynamic"></asp:RequiredFieldValidator>
                <br />
             </p>
                <h3><asp:Label ID="resultsNameType" runat="server" CssClass="error emphsis"/></h3>
             
                <h3><asp:Label ID="rButton" runat="server" CssClass="error emphsis"/></h3>
                <h3><asp:Label ID="RegestCompl" runat="server" CssClass="regestr"/></h3>
            <asp:Panel ID="courseSelection" runat="server">
            <h3>Following courses are currently available for registration</h3> 
                <h3><asp:Label ID="coursesValidation" runat="server" CssClass="error emphsis" Visible="false" /></h3>
               <%-- <asp:RequiredFieldValidator ID="coursesCheck" runat="server" ErrorMessage="You need to select at least one course!"
                ForeColor="Red" ControlToValidate="CheckBoxList1" 
                InitialValue="Select" Display="Dynamic"></asp:RequiredFieldValidator>--%>
                <asp:CheckBoxList ID="CheckBoxList1" runat="server"></asp:CheckBoxList>
                </asp:Panel>
            <asp:Panel ID="panelResults" runat="server" Visible="false">
           <%-- <h3><asp:Label ID="tableResults" runat="server" /></h3>--%>
                <br />
            </asp:Panel>
            <br />
            <asp:Button ID="save" runat="server" Text="save" OnClick="save_Click" CssClass="button"/>  
            <br/>
            <br/>
            <a href="AddStudent.aspx">Add Students</a>
        </div>
    </form>
</body>
</html>
