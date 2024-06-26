﻿using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Components.Pages
{
	public class EmployeeListBase:ComponentBase
	{
		public required IEnumerable<Employee> Employees { get; set; }

		protected override async Task OnInitializedAsync()
		{
			await Task.Run(LoadEmployees);
		}

		private void LoadEmployees()
		{
			System.Threading.Thread.Sleep(3000);

			Employee e1 = new Employee
			{
				EmployeeId = 1,
				FirstName = "John",
				LastName = "Hastings",
				Email = "David@pragimtech.com",
				DateOfBirth = new DateTime(1980, 10, 5),
				Gender = Gender.Male,
				DepartmentID = 1,
				PhotoPath = "images/e1.jpg"
			};

			Employee e2 = new Employee
			{
				EmployeeId = 2,
				FirstName = "Sam",
				LastName = "Galloway",
				Email = "Sam@pragimtech.com",
				DateOfBrith = new DateTime(1981, 12, 22),
				Gender = Gender.Male,
				DepartmentID = 2,
				PhotoPath = "images/e2.jpg"
			};

			Employee e3 = new Employee
			{
				EmployeeId = 3,
				FirstName = "Mary",
				LastName = "Smith",
				Email = "mary@pragimtech.com",
				DateOfBrith = new DateTime(1979, 11, 11),
				Gender = Gender.Female,
				DepartmentID = 1,
				PhotoPath = "images/e3.jpg"
			};

			Employee e4 = new Employee
			{
				EmployeeId = 3,
				FirstName = "Sara",
				LastName = "Longway",
				Email = "sara@pragimtech.com",
				DateOfBrith = new DateTime(1982, 9, 23),
				Gender = Gender.Female,
				DepartmentID = 3,
				PhotoPath = "images/e4.jpg"
			};

			Employees = new List<Employee> { e1, e2, e3, e4 };
			//Employees = [e1, e2, e3, e4 ];
		}
	}
}
