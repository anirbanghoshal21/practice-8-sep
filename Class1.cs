using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    public class department
    {
        private int _deptno;

        public int Deptno
        {
            get { return _deptno; }
            set { _deptno = value; }
        }
        private string _dname;

        public string Dname
        {
            get { return _dname; }
            set { _dname = value; }
        }

        private string _loc;

        public string Location
        {
            get { return _loc; }
            set { _loc = value; }
        }
    }
}
