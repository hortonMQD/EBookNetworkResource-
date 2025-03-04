﻿using ENR_Bll;
using ENR_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ENR_UI.asp.Backstage
{
    public partial class BookList : System.Web.UI.Page
    {
        protected List<BookInfo> bookInfos = new List<BookInfo>();

        protected int pageTotal = 0;    //总页数
        protected int total = 0;        //数据总量
        protected int pageIndex = 1;    //页码
        protected int contentIndex = 0;    //内容索引
        protected int Count = 0; //循环次数

        protected void Page_Load(object sender, EventArgs e)
        {
            BookInfo info = new BookInfo();
            info.Id = null;
            info.IsDelete = "0";
            info.IsTrue = "1";
            bookInfos = new BookService().SelectBookWithParameter(info);

            if (Request["pageIndex"] != null)
            {
                pageIndex = Convert.ToInt16(Request["pageIndex"]);
                contentIndex = (pageIndex-1) * 15;
                if (Request["pageIndex"].Equals("1")) { contentIndex = 0; }
            }
            total = bookInfos.ToArray().Length;
            pageTotal = (total / 15) + 1;
        }
    }
}