using Environment.Tasks;
using System;
using UnityEngine;
using Utils;

namespace Environment {
    [Serializable]
    public class Employee {

        public string name;
        public int employeeId;
        public bool hasEngineRoomClearance;
        public string lastEntranceInEngineRoom;
        public string lastExitFromEngineRoom;
    }
    public class Computer : MonoBehaviour, IInteractable {
        [SerializeField]
        private TextAsset jsonFile;
        [Serializable]
        public class EmployeeArray {
            public Employee[] employees;
        }

        [SerializeField]
        private GenericQueue<Task> taskQueue = new GenericQueue<Task>();
        public Employee[] allEmployees;
        private void Start() {
        }
        public void OnInteract() {
            if(taskQueue.Count > 0) {
                Task activeTask = taskQueue.Dequeue();
                activeTask.Execute();
            }
            else {
                Debug.Log("Queue is empty");
            }
            Employee[] employees = JsonUtility.FromJson<EmployeeArray>(jsonFile.text)?.employees;
            foreach(Employee employee in employees) {
                Debug.Log(
                $"Name: {employee.name}, " +
                $"ID: {employee.employeeId}, " +
                $"Clearance: {employee.hasEngineRoomClearance}, " +
                $"Last Entrance: {employee.lastEntranceInEngineRoom}, " +
                $"Last Exit: {employee.lastExitFromEngineRoom}");
            }
        }
    }
}
