using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




/// <summary>
/// 代理模式：通过代理类来中转，代理类可以调用实现类，同时做特定的业务处理，如记录日志等
/// </summary>
namespace 设计模式
{
    /// <summary>
    /// 消息接口
    /// </summary>
    public interface IMessage {
        /// <summary>
        /// 发送
        /// </summary>
        /// <returns></returns>
        bool Send();
    }

    /// <summary>
    /// 微信消息
    /// </summary>
    public class WxMessage : IMessage
    {
        /// <summary>
        /// 发送
        /// </summary>
        /// <returns></returns>
        public bool Send() {
            //实际发送消息逻辑
            return true;
        }
    }

    /// <summary>
    /// 代理消息
    /// </summary>
    public class ProxyMessage : IMessage {
        /// <summary>
        /// 发送
        /// </summary>
        /// <returns></returns>
        public bool Send() {
            StartLog();

            WxMessage wx = new WxMessage();
            bool b = wx.Send();

            EndLog();
            return b;
        }

        /// <summary>
        /// 
        /// </summary>
        public void StartLog() {
            Console.WriteLine("消息发送前日志");
        }

        /// <summary>
        /// 
        /// </summary>
        public void EndLog()
        {
            Console.WriteLine("消息发送后日志");
        }
    }
}
