﻿using ENR_Bll;
using ENR_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ENR_UI.asp.Reception
{
    public partial class ClassificationOfBooks : System.Web.UI.Page
    {
        protected DepartmentInfo departmentInfo = new DepartmentInfo();
        protected List<BookInfo> bookInfos = new List<BookInfo>();

        protected int pageTotal = 0;    //总页数
        protected int total = 0;        //数据总量
        protected int pageIndex = 1;    //页码
        protected int contentIndex = 0;    //内容索引
        protected int Count = 0; //循环次数


        protected void Page_Load(object sender, EventArgs e)
        {
            departmentInfo.Id = Request["departID"];
            BookInfo info = new BookInfo();
            info.Id = null;
            info.IsPass = "通过";
            info.IsTrue = "1";
            info.IsDelete = "0";
            if (departmentInfo.Id.Equals("20"))
            {
                bookInfos = new BookService().SelectNewBookWithParameter(info);
            }
            else if (departmentInfo.Id.Equals("21"))
            {
                bookInfos = new BookService().SelectFireBookWithParameter(info);
            }
            else if (departmentInfo.Id.Equals("22"))
            {
                info.Name = Request["bookName"];
                bookInfos = new BookService().SelectBookWithParameter(info);
            }
            else
            {
                departmentInfo = new DepartmentService().SelectDepartmentWithParameter(departmentInfo)[0];
                info.BookTypeID = Request["departID"];
                bookInfos = new BookService().SelectNewBookWithParameter(info);
            }
            if (Request["pageIndex"] != null)
            {
                pageIndex = Convert.ToInt16(Request["pageIndex"]);
                contentIndex = (pageIndex - 1) * 15;
                if (Request["pageIndex"].Equals("1")) { contentIndex = 0; }
            }
            total = bookInfos.ToArray().Length;
            pageTotal = (total / 15) + 1;
        }
    }
}