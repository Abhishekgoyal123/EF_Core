// See https://aka.ms/new-console-template for more information
using DbFirst.Models;
using DbFirst;

DataAccess da = new DataAccess();

var newEmployee = new Employee() { FirstName = "Abhishek", Age=22};

da.Update(1,newEmployee);