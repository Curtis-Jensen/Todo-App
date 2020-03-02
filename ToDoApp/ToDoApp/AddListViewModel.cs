using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ToDoApp
{
    class AddListViewModel
    {
        public ICommand AddEmployeeCommand => new Command(AddEmployee);
        public ICommand DeleteEmployeeCommand => new Command(DeleteEmployee);

        public ICommand UpDateCommand => new Command(UpDateEmployee);
        public ObservableCollection<string> Employees { get; set; }
        public string EmployeeName { get; set; }
        public string SelectedEmployeeName { get; set; }
        public AddListViewModel()
        {
            Employees = new ObservableCollection<string>();
            Employees.Add("Study Xamarin Forms");
            Employees.Add("Read the scriptures");
            Employees.Add("Kiss your wife ");
            Employees.Add("Time to workout");
        }

        public void AddEmployee()
        {
            Employees.Add(EmployeeName);
        }
        public void DeleteEmployee()
        {
            Employees.Remove(SelectedEmployeeName);
        }
        public void UpDateEmployee()
        {
            int newIndex = Employees.IndexOf(SelectedEmployeeName);
            Employees.Remove(SelectedEmployeeName);

            Employees.Add(EmployeeName);
            int oldIndex = Employees.IndexOf(EmployeeName);

            Employees.Move(oldIndex, newIndex);
        }
    }
}
