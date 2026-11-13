using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Utils;
using Debug = UnityEngine.Debug;

namespace Environment.Tasks {
    [CreateAssetMenu(fileName = "TreeSearchTask", menuName = "Tasks/TreeSearchTask")]
    public class TreeSearchTask : Task {
        [SerializeField]
        private string startTimeString = "2234-08-09T22:00:00";

        [SerializeField]
        private string endTimeString = "2234-08-09T23:00:00";

        public override void Execute() {
            BinarySearchTree tree = Computer.Instance.employeeTree;

            DateTime startTime = DateTime.Parse(startTimeString);
            DateTime endTime = DateTime.Parse(endTimeString);

            // Benchmark the DFS search on the BST
            Stopwatch stopwatch = Stopwatch.StartNew();
            List<Employee> suspects = tree.DFS(startTime, endTime);
            stopwatch.Stop();

            Computer.Instance.suspects = suspects;

            Debug.Log($"BST DFS Search found {suspects.Count} suspects in {stopwatch.Elapsed.TotalMilliseconds} ms ({stopwatch.ElapsedTicks} ticks):");

            foreach(Employee suspect in suspects) {
                Debug.Log($"SUSPECT (BST) -> Name: {suspect.name}, ID: {suspect.employeeId}, " +
                          $"Last Entrance: {suspect.lastEntranceInEngineRoom}, " +
                          $"Last Exit: {suspect.lastExitFromEngineRoom}");
            }
        }
    }
}
