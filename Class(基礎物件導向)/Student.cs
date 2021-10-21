using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_基礎物件導向_
{
    internal class Student
    {
        //Property
        public int StudentID;
        public string Name;
        public int Grade;

        //Method
        //public output型別 method名稱(input型別與名稱)
        public string Say()
        {
            return "我叫" + Name + ",我是" + Grade + "年級的學生";
        }
    }
}
