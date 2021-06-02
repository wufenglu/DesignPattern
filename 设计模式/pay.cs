using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pay
{
    public interface IPayIocPublicService
    {
        void Pay();
    }

    public class PayIocAppService : IPayIocPublicService
    {
        public void Pay()
        {
            Console.Write("Save");
        }
    }
}
