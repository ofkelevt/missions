<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="missionstable.aspx.cs" Inherits="missions.missionstable" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        table,td,tr,th{border:solid black 2px; }
   
    </style>
    <script type="text/javascript">
        var data = '<%=data %>';
        var y = <%=y%>
        var x = <%=x%>
        
        function mycode() {
            alert('onload');
            const obj = JSON.parse(data);
            alert(obj.data[0].tablesqare);
            for (var i = 0; i < y + 1; i++) {
                for (var j = 0; j < x; j++) {
                    if (obj.data[x * i + j].tablesqare != "empty") {
                        var e = document.getElementById("text" + x * i + j);
                        e.title = obj.data[x * i + j].tablesqare;
                    }
                    else if (i == 0) {
                        var e = document.getElementById("text" + x * i + j);
                        e.title = "$\"title<input type=\"text\" name=\"text{x * i + j}\"  />"
                    }
                        else {
                        var e = document.getElementById("text" + x * i + j);
                        e.title = "$\"mission<input type=\"text\" name=\"text{x * i + j}\"  />" }
                    //else Window.localStorage("text" + x * i + j, "$\"mission<input type=\"text\" name=\"text{x * i + j}\"  />") 
                  
                }
            }
            
        }

        
        window.onload = mycode();
    </script>
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form method ="post">
        <%=tablex %>
    </form>
    
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
