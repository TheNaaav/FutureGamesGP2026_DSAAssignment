using UnityEngine;
using Utils;

namespace Environment.Tasks {
    [CreateAssetMenu(fileName = "SortingTask", menuName = "Tasks/SortingTask")]
    public class SortingTask : Task {
        public override void Execute() {
            Employee[] employees = Computer.Instance.allEmployees;

            SortingUtils.QuickSort(employees, 0, employees.Length - 1);

            Computer.Instance.allEmployees = employees;

            foreach(Employee employee in Computer.Instance.allEmployees) {
                Debug.Log($"Name: {employee.name}, Last Entrance: {employee.lastEntranceInEngineRoom}");
            }
        }
    }
}
