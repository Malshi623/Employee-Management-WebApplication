using EmployeeManagement.Models;

namespace EmployeeManagent.API.Models
{
	public interface IEmployeeRepository
	{
		Task<IEnumerable<Employee>> GetEmployees();
		Task<Employee> GetEmployee(int employeeId);
		Task<Employee> AddEmployee(Employee employee);
		Task<Employee> UpdateEmployee(Employee employee);
		void DeleteEmployee(int employeeId);
	}
}
