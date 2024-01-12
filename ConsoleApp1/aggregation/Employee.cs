using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.aggregation
{
    class Employee
    {
        private int empId;
        private String empFirstName;
        private String empLastName;
        private float salary;
        // Employee has an address
        private Address address;

        public Employee()
        {
            this.empId = 1000;
            this.empFirstName = "Guest";
            this.empLastName = "Employee";
            this.salary = 0.0f;
           // this.address = new Address(); 
        }

        public Employee(int empId, string empFirstName, string empLastName, float salary)
        {
            this.empId = empId;
            this.empFirstName = empFirstName;
            this.empLastName = empLastName;
            this.salary = salary;
           // this.address = new Address();
        }

        public int Id { get => empId; set => empId = value; }
        public string FirstName { get => empFirstName; set => empFirstName = value; }
        public string LastName { get => empLastName; set => empLastName = value; }
        public float Salary { get => salary; set => salary = value; }

        public void setAddress(Address address)
        {
            this.address = address;
        }
        public void dispatchSalarySlip()
        {
            Console.WriteLine("Dispatcing Salary Slip Of: " + this.empFirstName + " on Address" + address.GetStringAddress());
          // address.Print();
        }

        public void printEmployeeDetails()
        {
            Console.WriteLine("Employee Id: "+this.empId);
            Console.WriteLine("Employee First Name: " + this.empFirstName);
            Console.WriteLine("Employee Last Name: " + this.empLastName);
            Console.WriteLine("Employee Salary: " + this.salary);
            Console.WriteLine("Employee Address: " + this.address.GetStringAddress());
        }


        //static void Main(string[] args)
        //{
        //    Employee employeeOne = new Employee(12, "Arif", "Ali", 30000.0f);
        //    Address addressEmployee = new Address("House No: 391, Block J, Street No:3 ", "Bahawalpur", "Punjab", "Pakistan");
        //    employeeOne.setAddress(addressEmployee);
        //    // employeeOne.printEmployeeDetails();
        //    employeeOne.dispatchSalarySlip();

        //    Employee employeeTwo = new Employee(553, "Salman", "Yasir", 30000.0f);
        //    employeeTwo.setAddress(addressEmployee);
        //    employeeTwo.dispatchSalarySlip();

        //    Console.ReadKey();


        //}
    }


}
