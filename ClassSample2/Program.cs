using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ClassSample2
{
    class Student
    {
        string name;
        string sname;
        public double gpa;

        public Student(string name, string sname, double gpa)
        {
            this.name = name;
            this.sname = sname;
            this.gpa = gpa;
        }

        public void ReadInfo()
        {
            name = Console.ReadLine();
            sname = Console.ReadLine();
            gpa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
        public void PrintInfo()
        {
            Console.WriteLine(sname + " " + name + " " + gpa);
            //Console.WriteLine(this.sname + " " + this.name + " " + this.gpa);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            List<Student> l = new List<Student>();
            Random r = new Random();

            int n = r.Next(5, 10);

            for (int i = 0; i < n; ++i)
            {
                double gpa = r.Next(1,4) + r.NextDouble();
                Student s = new Student("A" + i, "B" + i,gpa);
                l.Add(s);
            }
                                  
            for(int i = 0; i < n - 1; ++i)
            {
                for(int j = i + 1; j < n; ++j)
                {
                    if(l[i].gpa > l[j].gpa)
                    {
                        Student t = l[i];
                        l[i] = l[j];
                        l[j] = t;
                    }
                }
            }

            for (int i = 0; i < n; ++i)
            {
                l[i].PrintInfo();
            }
        }
    }
}

