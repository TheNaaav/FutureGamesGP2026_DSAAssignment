using Environment.Tasks;
using UnityEngine;
using Utils;

namespace Environment {

    public class Computer : MonoBehaviour, IInteractable {
        public static Computer Instance;
        [SerializeField]
        private GenericQueue<Task> taskQueue = new GenericQueue<Task>();
        public Employee[] allEmployees;

        private void Awake() {
            Instance = this;
        }
        public void OnInteract() {
            if(taskQueue.Count > 0) {
                Task activeTask = taskQueue.Dequeue();
                activeTask.Execute();
            }
            else {
                Debug.Log("Queue is empty");
            }
        }
    }
}
