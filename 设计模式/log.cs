using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pay
{
    public interface ILogIocPublicService
    {
        void Log();
    }

    public class LogIocAppService : ILogIocPublicService
    {
        public void Log()
        {
            Console.Write("Save");
        }
    }
}
