<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="missionstable.aspx.cs" Inherits="missions.missionstable" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        table,td,tr,th{border:solid black 2px; }
   
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form method ="post">
        <%=tablex %>
    </form>
    <table>
        <tr>
            <td>
                <form method ="post">
                    <input type="submit" name="submit" value ="submit text" />
                </form>
            </td>
            <td>
                <form>
                    <input type ="submit" name="addr" value="add row" />
                </form>
            </td>
            <td>
                <form>
                    <input type ="submit" name="addl" value="add lengh" />
                </form>
            </td>
            
        </tr>
   </table>
   
</asp:Content>
