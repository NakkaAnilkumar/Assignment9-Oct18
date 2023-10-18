using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9_Oct18
{
    class Employee
    {
        private int empno;
        private string ename;
        private double sal;
        private int deptno;

        public int EmpNo
        {
            get { return empno; }
            set
            {
                if (value == 0)
                    throw new ArgumentException("Employee number cannot be zero.");
                empno = value;
            }
        }

        public string EName
        {
            get { return ename; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Employee name cannot be null or empty.");
                ename = value;
            }
        }

        public double Salary
        {
            get { return sal; }
            set { sal = value; }
        }

        public int DeptNo
        {
            get { return deptno; }
            set
            {
                if (value == 0)
                    throw new ArgumentException("Department number cannot be zero.");
                deptno = value;
            }
        }
    }
}
