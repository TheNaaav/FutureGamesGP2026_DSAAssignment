using UnityEngine;

namespace Environment.Tasks {
    [CreateAssetMenu(fileName = "Employee Task", menuName = "Employee Task")]
    public class EmployeeTask : Task {
        [SerializeField]
        private TextAsset employeesJson;

        public static Employee[] PrintEmployees(TextAsset jsonFile) {
            Employee[] employees = JsonUtility.FromJson<EmployeeArray>(jsonFile.text)?.employees;
            foreach(Employee employee in employees) {
                Debug.Log(
                    $"Name: {employee.name}, " +
                    $"ID: {employee.employeeId}, " +
                    $"Clearance: {employee.hasEngineRoomClearance}, " +
                    $"Last Entrance: {employee.lastEntranceInEngineRoom}, " +
                    $"Last Exit: {employee.lastExitFromEngineRoom}");
            }
            return employees;
        }
        public override void Execute() {
            Computer.Instance.allEmployees = PrintEmployees(employeesJson);

        }
    }
}
