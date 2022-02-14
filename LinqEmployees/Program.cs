using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEmployees
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>() {
                new Employee(01,"Nguyen Van A",new DateTime(1995,4,28)),
                new Employee(12,"Chu Van C",new DateTime(1992,04,15)),
                new Employee(20,"Tran Thi B",new DateTime(1998,10,10)),
                new Employee(05,"Hoang Thi D",new DateTime(2000,11,03)),
                new Employee(25,"Ly Van E",new DateTime(1992,09,12))};
            // in ra danh sách employees
            Console.WriteLine("Danh sach nhan vien: ");
            var kq = from e in employees select e;
            foreach (var item in kq)
            {
                Console.WriteLine(item);
            }

            // in ra nhân viên có mã lớn hơn 10
            Console.WriteLine("=========================");
            Console.WriteLine("Nhan vien co ID lon hon 10:");
            var kqua = employees.Where(e => e.id > 10);
            foreach (var item in kqua)
            {
                Console.WriteLine(item);
            }

            // in ra nhân viên có mã lớn hơn 10 và bắt đầu bằng chứ C
            Console.WriteLine("=========================");
            Console.WriteLine("Nhan vien co ID lon hon 10 va ten bat dau bang chu C:");
            var rs = employees.Where(x => x.id > 10 && x.name.StartsWith("C"));
            foreach (var item in rs)
            {
                Console.WriteLine(item);
            }

            // in ra nhân viên có năm sinh 1992
            Console.WriteLine("=========================");
            Console.WriteLine("Nhan vien co nam sinh 1992:");
            var year = employees.Where(x => x.birthDay.Year.Equals(1992));
            foreach (var item in year)
            {
                Console.WriteLine(item);
            }
        }
    
    }
}
