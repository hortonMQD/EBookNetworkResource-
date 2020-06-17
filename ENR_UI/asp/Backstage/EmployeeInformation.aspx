<%@ Page Title="" Language="C#" MasterPageFile="~/asp/Backstage/BackIndex.Master" AutoEventWireup="true" CodeBehind="EmployeeInformation.aspx.cs" Inherits="ENR_UI.asp.Backstage.EmployeeInformation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/FormTableCss.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="formBox">
        <form action="../../ashx/EmployeeInformation.ashx?personalID=<%=info.Id %>" method="post">
        <table class="FormTable">
            <tr>
                <td><label>姓名：</label></td>
                <td><input type="text" name="personalName" placeholder="请输入姓名" value="<%=info.Name %>"></td>
            </tr>
            <tr>
                <td><label>联系方式：</label></td>
                <td><input type="text" name="personalTelephone" placeholder="请输入联系电话" value="<%=info.Telephone %>"></td>
            </tr>
            <tr>
                <td><label>入职时间：</label></td>
                <td><%=info.CreateTime %></td>
            </tr>
            <tr>
                <td><label>部门：</label></td>
                <td>
                    <select name="departName">
                        <option value="<%=info.Department%>" selected="selected"><%=info.DepartmentName%></option>
                    <%for(int i = 0;i<departmentInfos.ToArray().Length;i++){%>
                            <option value="<%=departmentInfos[i].Id%>"><%=departmentInfos[i].Name%></option>
                    <% } %>
                    </select>
                </td>
            </tr>
            <tr>
                <td><label>权限：</label></td>
                <td>
                    <select name="limitName">
                        <option value="<%=info.Limit%>" selected="selected"><%=info.LimitName%></option>
                    <%for(int i = 0;i<limitInfos.ToArray().Length;i++){ %>
                            <option value="<%=limitInfos[i].Id%>"><%=limitInfos[i].Name%></option>
                    <% } %>
                    </select></td>
            </tr>
            <tr>

                <td>是否离职：</td>
                <td>
                    <select name="PersonalIsDimission">
                        <%if (info.IsDimission.Equals("0")){ %>
                            <option value="0" selected="selected">在职</option>
                            <option value="1">已离职</option>
                        <%} else { %>
                            <option value="0">在职</option>
                            <option value="1" selected="selected">已离职</option>
                        <%} %>
                    </select>
                </td>
            </tr>
            <tr>
                <td class="TableButton" colspan="2">
                    <input type="submit" name="Submit" value="提交">
                </td>
            </tr>
        </table>
        </form>
    </div>

    <div class="formBox" style="border:1px solid #ddd; margin-top:20px;margin-bottom:20px; text-align:center">
        <table class="FormTable">
            <tr class="table-td-color">
                <td>序号</td>
                <td>小说名称</td>
                <td>作者</td>
                <td>连载状态</td>
                <td>小说类型</td>
                <td>上传用户</td>
                <td>上传时间</td>
                <td>是否删除</td>
                <td>审核结果</td>
                <td>审核人</td>
                <td>查看详情</td>
            </tr>
            <%for (int i = 0; i < bookInfos.ToArray().Length; i++){ %>
                <tr>
                    <td class="table-td-border-color"><%=i+1 %></td>
                    <td><%=bookInfos[i].Name %></td>
                    <td><%=bookInfos[i].Author %></td>
                    <td><%=bookInfos[i].SerialState %></td>
                    <td><%=bookInfos[i].BookTypeName %></td>
                    <td><%=bookInfos[i].UploadUserText %></td>
                    <td><%=bookInfos[i].UploadTime %></td>
                    <%if (bookInfos[i].IsDelete.Equals("1")){  %>
                        <td>已删除</td>
                    <%}else{ %>
                        <td>未删除</td>
                    <%} %>
                    
                    <td><%=bookInfos[i].IsPass %></td>
                    <td><%=bookInfos[i].PersonalName %></td>
                    <td><a href="AuditBookInformation.aspx?bookID=<%=bookInfos[i].Id %>">查看详情</a></td>
                </tr>
            <%} %>
        </table>
    </div>
</asp:Content>
