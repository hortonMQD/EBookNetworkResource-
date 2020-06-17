<%@ Page Title="" Language="C#" MasterPageFile="~/asp/Reception/BackHomepage.master" AutoEventWireup="true" CodeBehind="UserPersonalCenter.aspx.cs" Inherits="ENR_UI.asp.Reception.UserPersonalCenter" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/FormTableCss.css" rel="stylesheet" />
    <script type="text/javascript" src="../js/Check.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form method="post" action="../../ashx/UserPersonalCenter.ashx" name="UserPersonalCenter" onsubmit="">
    <table class="FormTable">
                <tr>
                    <td><label>用户名：</label></td>
                    <td><input type="text" class="userName" name="userName" value="<%=info.UName %>" onkeyup="this.value=this.value.replace(/[, ]/g,'')" onchange="checkUserName()">
                        <label class="error-message name_error">*不能为空</label></td>
                </tr>
                <tr>
                    <td><label>电子邮箱：</label></td>
                    <td><input type="text" class="userEmail" name="userEmail" value="<%=info.Email %>" onkeyup="this.value=this.value.replace(/[, ]/g,'')" onchange="checkEmail()"><label class="error-message email_error">*邮箱格式不正确</label></td>
                </tr>
                <tr>
                    <td class="TableButton" colspan="2">
                        <input type="submit" name="Submit" value="提交">
                    </td>
                </tr>
        </table>
        </form>
</asp:Content>
