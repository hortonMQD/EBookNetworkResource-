﻿<%@ Page Title="" Language="C#" MasterPageFile="~/asp/Reception/BackHomepage.master" AutoEventWireup="true" CodeBehind="UserUploadEbook.aspx.cs" Inherits="ENR_UI.asp.Reception.UserUploadEbook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/FormTableCss.css" rel="stylesheet" />
    <script>
			
			function imgflush(g){	
				var f = new FileReader();
				f.readAsDataURL(g.files[0]);
				f.onload = function(){
					var img = document.getElementById("img-id");
					img.src = f.result;
				}
			};
		</script>
    <script type="text/javascript" src="../js/Check.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form method="post" enctype="multipart/form-data" action="../../ashx/UserUploadEBook.ashx">
    <div id="form">
        <table class="FormTable">
                <tr>
                    <td class="TableButton" colspan="2"><img src="../img/暂无封面.jpg" id="img-id" style="width: 200px;height: 200px;"/></td>
                </tr>
                <tr>
                    <td><label>电子书封面：</label></td>
                    <td><input type="file" name="bookImage" id="bookImage" accept="image/jpg,image/png,image/JPG,image/PNG,image/JPEG" onchange="imgflush(this)"></td>
                </tr>
                <tr>
                    <td><label>图书名称：</label></td>
                    <td><input type="text" class="bookName" name="bookName" onblur="checkBookName()" onkeyup="this.value=this.value.replace(/[, ]/g,'')">
                        <label class="error-message bookName_error">*名称不为空</label></td>
                </tr>
                 <tr>
                    <td><label>图书作者：</label></td>
                    <td><input type="text" class="bookAuthor" name="bookAuthor" onblur="checkBookAuthor()" onkeyup="this.value=this.value.replace(/[, ]/g,'')">
                        <label class="error-message bookAuthor_error">*作者不为空</label></td>
                </tr>
                <tr>
                    <td><label>连载状态：</label></td>
                    <td>
                        <select name="bookState">
						    <option value="已完结">已完结</option>
						    <option value="连载中">连载中</option>
					    </select>
                    </td>
                </tr>
                <tr>
                    <td><label>图书类型：</label></td>
                    <td>
                        <select name="bookType">
                            <%for(int i = 0;i<departmentInfos.ToArray().Length;i++){  if (departmentInfos[i].Name.Equals("董事长办公室")) { continue; }%>
                            <option value="<%=departmentInfos[i].Id%>"><%=departmentInfos[i].Name%></option>
                            <% } %>
						</select>
                    </td>
                </tr>
                <tr>
                    <td><label>书籍简介：</label></td>
                    <td><textarea class="bookText" name="bookText" cols="80" rows="10" placeholder="请输入书籍简介" onblur="checkBookText()" onkeyup="this.value=this.value.replace(/[, ]/g,'')"></textarea>
                        <label class="error-message bookText_error">*简介不为空</label>
                    </td>
                </tr>
                <tr>
                    <td><label>电子书文件：</label></td>
                    <td><input type="file" name="bookFile"></td>
                </tr>
                <tr>
                    <td class="TableButton" colspan="2">
                        <input type="submit" name="Submit" value="提交">
                        <input type="reset" name="Cancel" value="取消">
                    </td>
                </tr>
        </table>
    </div>
    </form>
			
</asp:Content>
