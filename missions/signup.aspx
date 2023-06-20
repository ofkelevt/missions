<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="missions.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form name="signup" method="post" onsubmit="return checkForm()">
        <p>
        user name <input type="text" name="user"  />
        first name<input type="text" name="fname"/> last name <input type="text" name="lname"/>
        password<input type="password" name="spass" />
        comfirm password<input type="password" name="cpass"  />
        email<input type="email" name="email" />
        phone number<input type="text" name="phonenum" />
        <input type="submit" name="submitsign" value="submit" />
        </p>
        <%=eror %>

    </form>
     <script type="text/javascript">
         function checkform()
         {
             if (document.signup.user.value == "") {
                 alert('right your username pls')
                 return false;
             }
             if (document.signup.fname.value == "") {
                 alert('right your name pls')
                 return false;
             }
             if (document.signup.cpass.value == "") {
                 alert('your password cannot be empty')
                 return false;
             }
             if (document.signup.cpass.value.length < 8) {
                 alert('your password is too short')
                 return false;
             }
             var num = 123456789
             var fname = document.signup.fname.value
             var lname = document.signup.lname.value
             var ffname = document.signup.phonenum.value
                 for (var i = 0; i < alphb.length; i++) {
                 var ch = fname.charAt(i);
                 if (!(num.indexOf(ch) == -1)) {
                     alert('your first name cannot conntain numbers')
                     return false
                 }
                 var ch = fname.charAt(i);
                
                 var ch = lname.charAt(i);
                 if (!(num.indexOf(ch) == -1)) {
                     alert('your last name cannot conntain numbers')
                     return false
                 }
                 var ch = ffname.charAt(i);
                 if (num.indexOf(ch) == -1) {
                     alert('your phone number must only conntain numbers')
                     return false
                 }
             }
     </script>
</asp:Content>
