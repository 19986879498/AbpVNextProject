using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbpVNextProject.Web
{
    public interface ITestToService
    {
        string Get();
    }
    public class TestToService: ITestToService
    {
        public string Get() {
            return "哈哈哈，我是艾斯";
        }
    }
}
