using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee("Monika Patil", 20000, 060);
            Employee e1 = new Employee("Monika Patil", 20000);
            Employee e2 = new Employee("Monika Patil");
            Employee e3 = new Employee();


            Console.WriteLine(e.PEMPNO);
            Console.WriteLine(e1.PEMPNO);
            Console.WriteLine(e2.PEMPNO);
            Console.WriteLine(e3.PEMPNO);
            Console.ReadLine();

        }
    }

    public class Employee
    {
        private string ename;
        public string ENAME
        {
            set
            {
                if (value != "")
                {
                    ename = value;
                }
                else
                {
                    Console.WriteLine("Invalid employee name");
                    Console.ReadLine();
                }
            }
            get
            {
                return ename;
            }


        }
        private static int count = 0;
        private int EmpNo = 0;
        public int PEMPNO
        {
            set
            {
                EmpNo = value;
            }
            get
            {
                return EmpNo;
            }
        }

        private decimal Basic;
        public decimal PBASIC
        {
            set
            {
                if (value > 10000 && value < 25000)
                {
                    Basic = value;
                }
                else
                {
                    Console.WriteLine("invalid Basic ");
                    Console.ReadLine();

                }
            }
            get
            {
                return Basic;
            }
        }
        private int deptNo;
        public int PDEPTNO
        {
            set
            {
                if (value > 0)
                {
                    deptNo = value;
                }
                else
                {
                    Console.WriteLine("Invalid Dept Number");
                    Console.ReadLine();
                }
            }
            get
            {
                return deptNo;
            }
        }

        public Employee(string name = null, decimal basic = 0, short deptId = 0)
        {
            Employee.count++;
            EmpNo = Employee.count;
            ENAME = name;
            PBASIC = basic;
            PDEPTNO = deptId; using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace Day2_Assignments
    {
        class Program
        {
            static void Main(string[] args)
            {
                Employee e = new Employee("Monika Patil", 20000, 060);
                Employee e1 = new Employee("Monika Patil", 20000);
                Employee e2 = new Employee("Monika Patil");
                Employee e3 = new Employee();


                Console.WriteLine(e.PEMPNO);
                Console.WriteLine(e1.PEMPNO);
                Console.WriteLine(e2.PEMPNO);
                Console.WriteLine(e3.PEMPNO);
                Console.ReadLine();

            }
        }

        public class Employee
        {
            private string ename;
            public string ENAME
            {
                set
                {
                    if (value != "")
                    {
                        ename = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid employee name");
                        Console.ReadLine();
                    }
                }
                get
                {
                    return ename;
                }


            }
            private static int count = 0;
            private int EmpNo = 0;
            public int PEMPNO
            {
                set
                {
                    EmpNo = value;
                }
                get
                {
                    return EmpNo;
                }
            }

            private decimal Basic;
            public decimal PBASIC
            {
                set
                {
                    if (value > 10000 && value < 25000)
                    {
                        Basic = value;
                    }
                    else
                    {
                        Console.WriteLine("invalid Basic ");
                        Console.ReadLine();

                    }
                }
                get
                {
                    return Basic;
                }
            }
            private int deptNo;
            public int PDEPTNO
            {
                set
                {
                    if (value > 0)
                    {
                        deptNo = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Dept Number");
                        Console.ReadLine();
                    }
                }
                get
                {
                    return deptNo;
                }
            }

            public Employee(string name = null, decimal basic = 0, short deptId = 0)
            {
                Employee.count++;
                EmpNo = Employee.count;
                ENAME = name;
                PBASIC = basic;
                PDEPTNO = deptId;
            }

        }
    }
}

    }
}