using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YK.Platform.Core;
using 设计模式;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Injection();

            属性注入 service = ServiceContainer.InitService<属性注入>();
            service.Save();

            Console.Read();
        }

        /// <summary>
        /// 注入
        /// </summary>
        static void Injection()
        {
            ServiceContainer.Register<AttributeIocAppService, IAttributeIocPublicService>();
        }
    }
}
