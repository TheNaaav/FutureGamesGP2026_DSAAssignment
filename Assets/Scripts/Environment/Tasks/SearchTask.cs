using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Utils;
using Debug = UnityEngine.Debug;

namespace Environment.Tasks {
    [CreateAssetMenu(fileName = "SearchTask", menuName = "Tasks/SearchTask")]
    public class SearchTask : Task {
        [SerializeField]
        private string startTimeString = "2234-08-09T22:00:00";

        [SerializeField]
        private string endTimeString = "2234-08-09T23:00:00";

        public override void Execute() {
            Employee[] employees = Computer.Instance.allEmployees;

            DateTime startTime = DateTime.Parse(startTimeString);
            DateTime endTime = DateTime.Parse(endTimeString);

            // Starta tidtagning (Benchmark)
            Stopwatch stopwatch = Stopwatch.StartNew();

            // Kör Binary Search
            List<Employee> suspects = SearchUtils.BinarySearchRange(employees, startTime, endTime);

            // Stoppa tidtagning
            stopwatch.Stop();

            Debug.Log($"Binary Search found...{suspects.Count} \"SUSPECT ->\" {stopwatch.Elapsed.TotalMilliseconds} ms ({stopwatch.ElapsedTicks} ticks):");

            foreach(Employee suspect in suspects) {
                Debug.Log($"SUSPECT -> Name: {suspect.name}, ID: {suspect.employeeId}, " +
                          $"Last Entrance: {suspect.lastEntranceInEngineRoom}, " +
                          $"Last Exit: {suspect.lastExitFromEngineRoom}");
            }
        }
    }
}
