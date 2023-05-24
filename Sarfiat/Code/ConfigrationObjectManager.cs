using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarfiat.Code
{
    public static class ConfigrationObjectManager
    {
        private static Dictionary<string, object> ObjectList = new Dictionary<string, object>();
        public static void Register(string ObjectName, object ObjectValue)
        {
            ObjectList.Add(ObjectName, ObjectValue);
        }
        public static object GetObject(string ObjectName) {
            return ObjectList[ObjectName];
        }
    }
}
