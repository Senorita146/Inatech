﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Question6b
    {
        public int EmpId { get; set; }
        public string? EmpName { get; set; }
        public string? Empgender { get; set; }
        public int Empage { get; set; }

        public void readfEmp()
        {
            FileStream emp = new FileStream("D:\\Training\\Emp.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(emp);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadToEnd();
            Console.WriteLine(str);
        }
        public static void Main(string[] args)
        {
            Question6b emp = new Question6b();
            Console.WriteLine("Enter employee name:");
            emp.EmpName = Console.ReadLine();
            Console.WriteLine("Enter employee gender:");
            emp.Empgender = Console.ReadLine();
            Console.WriteLine("Enter employee ID:");
            emp.EmpId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee age:");
            emp.Empage = Convert.ToInt32(Console.ReadLine());

            FileStream Emp = new FileStream(@"D:\Training\Emp.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(Emp);
            sw.Write(emp.EmpName);
            sw.Write(emp.Empgender);
            sw.Write(emp.Empage);
            sw.Write(emp.EmpId);
            sw.Flush();
            sw.Close();
            Emp.Close();
            emp.readfEmp();
        }
    }


}
