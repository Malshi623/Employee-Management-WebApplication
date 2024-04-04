using EmployeeManagement.Models;

namespace EmployeeManagent.API.Models
{
	public interface IDepartmentRepository
	{
		IEnumerable<Department> GetDepartments();
		Department GetDepartment(int departmentId);
	}
}
