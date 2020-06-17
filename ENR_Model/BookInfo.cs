using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENR_Model
{
    public class BookInfo
    {
        private String id;          //自动编号
        private String oldID;       //修改信息前编号
        private String imageUrl;    //封面文件路径
        private String imageName;   //封面文件文件名
        private String name;        //图书名称
        private String author;      //作者
        private String text;        //书籍简介
        private String serialState; //连载状态
        private String bookTypeID;  //书籍类型编号
        private String bookTypeName;    //书籍类型名称
        private String bookTypeIsTrue;  //书籍类型是否启用
        private String fileUrl;         //书籍文件路径
        private String fileSize;        //书籍文件大小
        private String fileName;        //书籍文件名称
        private String uploadUserID;    //上传用户自动编号
        private String uploadUserText;  //上传用户名称
        private String uploadTime;      //上传时间
        private String downloadCount;   //书籍下载次数
        private String isTrue;          //是否显示
        private String isDelete;        //是否删除
        private String auditOpinion;    //审核意见
        private String isPass;          //是否审核通过
        private String opinion;         //审核意见
        private String personalID;      //审核人自动编号
        private String personalName;    //审核人名称
        private String personalEmail;   //审核人邮箱


        public BookInfo()
        {
            Id = IDUtils.GetGuid16String();
            AuditOpinion = Id;
        }

        public string Id { get => id; set => id = value; }
        public string ImageUrl { get => imageUrl; set => imageUrl = value; }
        public string Name { get => name; set => name = value; }
        public string Author { get => author; set => author = value; }
        public string Text { get => text; set => text = value; }
        public string SerialState { get => serialState; set => serialState = value; }
        public string BookTypeID { get => bookTypeID; set => bookTypeID = value; }
        public string BookTypeName { get => bookTypeName; set => bookTypeName = value; }
        public string BookTypeIsTrue { get => bookTypeIsTrue; set => bookTypeIsTrue = value; }
        public string FileUrl { get => fileUrl; set => fileUrl = value; }
        public string FileSize { get => fileSize; set => fileSize = value; }
        public string UploadUserID { get => uploadUserID; set => uploadUserID = value; }
        public string UploadUserText { get => uploadUserText; set => uploadUserText = value; }
        public string UploadTime { get => uploadTime; set => uploadTime = value; }
        public string DownloadCount { get => downloadCount; set => downloadCount = value; }
        public string IsTrue { get => isTrue; set => isTrue = value; }
        public string AuditOpinion { get => auditOpinion; set => auditOpinion = value; }
        public string IsPass { get => isPass; set => isPass = value; }
        public string Opinion { get => opinion; set => opinion = value; }
        public string ImageName { get => imageName; set => imageName = value; }
        public string FileName { get => fileName; set => fileName = value; }
        public string OldID { get => oldID; set => oldID = value; }
        public string IsDelete { get => isDelete; set => isDelete = value; }
        public string PersonalName { get => personalName; set => personalName = value; }
        public string PersonalID { get => personalID; set => personalID = value; }
        public string PersonalEmail { get => personalEmail; set => personalEmail = value; }
    }
}
