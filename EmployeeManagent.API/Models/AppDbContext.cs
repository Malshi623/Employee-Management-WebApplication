using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace EmployeeManagement.Api.Models
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options)
		: base(options)
		{
		}

		public DbSet<Employee> Employees { get; set; }
		public DbSet<Department> Departments { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			//Seed Departments Table
			modelBuilder.Entity<Department>().HasData(
				new Department { DepartmentID = 1, DepartmentName = "IT" });
			modelBuilder.Entity<Department>().HasData(
				new Department { DepartmentID = 2, DepartmentName = "HR" });
			modelBuilder.Entity<Department>().HasData(
				new Department { DepartmentID = 3, DepartmentName = "Payroll" });
			modelBuilder.Entity<Department>().HasData(
				new Department { DepartmentID = 4, DepartmentName = "Admin" });

			// Seed Employee Table
			modelBuilder.Entity<Employee>().HasData(new Employee
			{
				EmployeeId = 1,
				FirstName = "John",
				LastName = "Hastings",
				Email = "David@pragimtech.com",
				DateOfBrith = new DateTime(1980, 10, 5),
				Gender = Gender.Male,
				DepartmentID = 1,
				PhotoPath = "images/e1.jpg"
			});

			modelBuilder.Entity<Employee>().HasData(new Employee
			{
				EmployeeId = 2,
				FirstName = "Sam",
				LastName = "Galloway",
				Email = "Sam@pragimtech.com",
				DateOfBrith = new DateTime(1981, 12, 22),
				Gender = Gender.Male,
				DepartmentID = 2,
				PhotoPath = "images/e2.jpg"
			});

			modelBuilder.Entity<Employee>().HasData(new Employee
			{
				EmployeeId = 3,
				FirstName = "Mary",
				LastName = "Smith",
				Email = "mary@pragimtech.com",
				DateOfBrith = new DateTime(1979, 11, 11),
				Gender = Gender.Female,
				DepartmentID = 1,
				PhotoPath = "images/e3.jpg"
			});

			modelBuilder.Entity<Employee>().HasData(new Employee
			{
				EmployeeId = 4,
				FirstName = "Sara",
				LastName = "Longway",
				Email = "sara@pragimtech.com",
				DateOfBrith = new DateTime(1982, 9, 23),
				Gender = Gender.Female,
				DepartmentID = 3,
				PhotoPath = "images/e4.jpg"
			});
		}
	}
}