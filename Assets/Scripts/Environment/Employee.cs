using System;
using UnityEngine;

namespace Environment {
    [Serializable]
    public class Employee {
        public string name;
        public int employeeId;
        public bool hasEngineRoomClearance;
        public string lastEntranceInEngineRoom;
        public string lastExitFromEngineRoom;

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
    }
    [Serializable]
    public class EmployeeArray {
        public Employee[] employees;
    }
}
