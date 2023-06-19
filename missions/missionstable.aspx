<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="missionstable.aspx.cs" Inherits="missions.missionstable" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        table,td,tr,th{border:solid black 2px; }
   
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <body onload="">

    
    <form method ="post">
        <%=tablex %>
    </form>
    <p id="hi"></p>
    <script type="text/javascript" >
        function onload()
        {
            const obj = JSON.parse(data);
            document.getElementById("hi").innerHTML = obj.data[0].tablesqare;
            for (var i = 0; i < y + 1; i++) {
                for (var j = 0; j < x; j++) {
                    Session["text" + x * i + j] = obj.data[x * i + j].tablesqare;
                }
            }
        } 
        
        
    </script>
    <table>
        <tr>
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
