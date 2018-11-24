using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 设计模式
{
    public class SingletonPattern
    {
        /// <summary>
        /// 私有实例
        /// </summary>
        private static SingletonPattern Install { get; set; }

        /// <summary>
        /// 锁对象
        /// </summary>
        private static readonly object LockObj = new object();

        /// <summary>
        /// 获取实例
        /// </summary>
        /// <returns></returns>
        public static SingletonPattern GetInstall() {
            if (Install != null) {
                return Install;
            }
            lock (LockObj) {
                if (Install == null)
                {
                    Install = new SingletonPattern();
                }             
            }
            return Install;
        }

        /// <summary>
        /// 添加文本
        /// </summary>
        public void AppendText(string text)
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, DateTime.Now.ToString("yyyyMMdd") + ".log");
            if (File.Exists(path) == false)
            {
                FileStream fs = File.Create(path);
                fs.Dispose();
                fs.Close();
            }

            File.AppendAllLines(path, new string[] { "0." + text });

            File.AppendAllLines(path, new string[] { "1." + text });
        }
    }
}
