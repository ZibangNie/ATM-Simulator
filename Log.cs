using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    // File2.cs  
    public class ClassInFile2
    {
         
        private static ClassInFile2 _sharedInstance;
        public string a;
        
        private ClassInFile2()
        {
            
        }

        // 公共静态属性来访问单例实例  
        public static ClassInFile2 SharedInstance
        {
            get
            {
                // 如果实例不存在，则创建它  
                if (_sharedInstance == null)
                {
                    _sharedInstance = new ClassInFile2();
                }
                // 返回已存在的实例  
                return _sharedInstance;
            }
        }

        // 类的其他成员...  
    }

    // 在其他文件中访问  
    //var instance = ClassInFile2.SharedInstance;
}
