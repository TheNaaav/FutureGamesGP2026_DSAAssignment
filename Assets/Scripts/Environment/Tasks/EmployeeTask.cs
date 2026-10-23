using UnityEngine;

namespace Environment.Tasks {
    [CreateAssetMenu(fileName = "Employee Task", menuName = "Employee Task")]
    public class EmployeeTask : Task {
        [SerializeField]
        private TextAsset employeesJson;
        public override void Execute() {
            Computer.Instance.allEmployees = Employee.PrintEmployees(employeesJson);
        }
    }
}
