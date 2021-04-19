using DatagridBindingSample.Models;
using DatagridBindingSample.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DatagridBindingSample.ViewModels
{
	public class MainViewModel : ObservableObject
	{
		private ObservableCollection<Employees> _employees;
		public ObservableCollection<Employees> Employees
		{
			get { return _employees; }
			set { _employees = value; OnPropertyChanged(); }
		}

		private ObservableCollection<Department> _departments;
		public ObservableCollection<Department> Departments
		{
			get { return _departments; }
			set { _departments = value; OnPropertyChanged(); }
		}

		private string _departmentName;
		public string DepartmentName
		{
			get { return _departmentName; }
			set { _departmentName = value; OnPropertyChanged(); }
		}

		public MainViewModel()
		{
			Employees = GetEmployees();
			Departments = GetDepartments();
		}

		private ObservableCollection<Employees> GetEmployees()
		{
			ObservableCollection<Employees> employees = new ObservableCollection<Employees>
			{
				new Employees { Name = "James", Age = 30 },
				new Employees { Name = "Elena", Age = 26 },
				new Employees { Name = "Rookie", Age = 38 }
			};
			return employees;
		}

		private ObservableCollection<Department> GetDepartments()
		{
			ObservableCollection<Department> departments = new ObservableCollection<Department>
			{
				new Department { DepartmentCode = "0001", DepartmentName = "Develop" },
				new Department { DepartmentCode = "0002", DepartmentName = "Marketing" },
				new Department { DepartmentCode = "0003", DepartmentName = "HR" }
			}; 
			return departments;
		}
	}
}
