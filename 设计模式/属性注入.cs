using pay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 设计模式
{
    public interface IAttributeIocPublicService
    {
        void Save();
    }

    public class AttributeIocAppService : IAttributeIocPublicService
    {
        public void Save()
        {
            Console.Write("Save");
        }
    }

    public class 属性注入
    {
        /// <summary>
        /// 接口服务
        /// </summary>
        public IAttributeIocPublicService iAttributeIocPublicService { get; set; }

        /// <summary>
        /// 接口服务
        /// </summary>
        public IPayIocPublicService iPayIocPublicService { get; set; }

        /// <summary>
        /// 接口服务
        /// </summary>
        public ILogIocPublicService iLogIocPublicService { get; set; }

        /// <summary>
        /// 保存
        /// </summary>
        public void Save()
        {
            iAttributeIocPublicService.Save();
            iPayIocPublicService.Pay();
            iLogIocPublicService.Log();
        }
    }
}
