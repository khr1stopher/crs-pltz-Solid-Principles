﻿using OpenClose;

ShowSalaryMonthly(new List<Employee>() {
    new EmployeeFullTime("Tanjiro Kamado", 160),
    new EmployeePartTime("Manuel Lopera", 180),
    new EmployeeContractor("Kisvi Loroks", 180)
});


void ShowSalaryMonthly(List<Employee> employees) 
{
    foreach (var employee in employees)
    {
        Console.WriteLine($"Empleado: {employee.Fullname}, Pago: {employee.CalculateSalaryMonthly():C1} ");
    }

}