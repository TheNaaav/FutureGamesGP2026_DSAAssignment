using Environment.Tasks;
using UnityEngine;
using Utils;

namespace Environment {
    public class Computer : MonoBehaviour, IInteractable {
        private GenericQueue<Task> taskQueue = new GenericQueue<Task>();
        [SerializeField]
        private Task[] starterTasks = null; // Put your stack/queue here :)
        private void Start() {
            if(starterTasks != null) {
                foreach(Task task in starterTasks) {
                    taskQueue.Enqueue(task);
                }
            }
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
