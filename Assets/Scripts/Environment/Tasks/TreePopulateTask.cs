using System.Diagnostics;
using UnityEngine;
using Utils;
using Debug = UnityEngine.Debug;

namespace Environment.Tasks {
    [CreateAssetMenu(fileName = "TreePopulateTask", menuName = "Tasks/TreePopulateTask")]
    public class TreePopulateTask : Task {
        public override void Execute() {
            Employee[] employees = Computer.Instance.allEmployees;

            Stopwatch stopwatch = Stopwatch.StartNew();

            // Create the BST with the first employee (index 0) as the root
            BinarySearchTree tree = new BinarySearchTree(employees[0]);

            // Insert all remaining employees (index 1 to 799)
            for(int i = 1; i < employees.Length; i++) {
                tree.Insert(employees[i]);
            }

            stopwatch.Stop();

            // Store the tree in Computer
            Computer.Instance.employeeTree = tree;

            Debug.Log($"TreePopulateTask: Inserted {employees.Length} employees into BST in {stopwatch.Elapsed.TotalMilliseconds} ms ({stopwatch.ElapsedTicks} ticks).");
        }
    }
}
