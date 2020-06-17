using ENR_Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Web.Script.Serialization;

namespace ENR_Bll
{
    public class DBTool
    {

        /// <summary>
        /// 获得socket连接
        /// </summary>
        /// <returns>socket连接</returns>
        public static Socket GetConnect()
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("127.0.0.1", 8998);
            return socket;
        }


        public static project JSONStringToObject(String JSON)
        {
            project data = JsonConvert.DeserializeObject<project>(JSON);
            return data;
        }

        /// <summary>
        /// 与服务端通过socket通信的方法
        /// </summary>
        /// <param name="message">json字符串</param>
        /// <returns>服务端返回json字符串</returns>
        public static String Send(String message)
        {
            Socket socket = GetConnect();
            byte[] by = Encoding.Default.GetBytes(message);
            socket.Send(by);//Send发送 Receive接收
            byte[] Is = new byte[1024*1024];
            int len = socket.Receive(Is);
            message = Encoding.UTF8.GetString(Is, 0, len);
            socket.Close();
            return message;
        }



        /// <summary>
        /// 根据传入参数返回bool值
        /// </summary>
        /// <param name="result">String参数</param>
        /// <returns>返回true或false</returns>
        public static bool isTrue(String result)
        {
            if (result.Equals("true") || result.Equals("TRUE"))
            {
                return true;
            }
            return false;
        }




 


    }
}
