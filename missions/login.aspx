<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="missions.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form method="post">
        username<input type="text" name="user"/><br />
        password<input type="password" name="pass"/><br />
        <input type="submit" name="check" value="login" />
        <%=error %>
        <p>crate user <a href="signup.aspx">signup</a></p>
        
    </form>
</asp:Content>
