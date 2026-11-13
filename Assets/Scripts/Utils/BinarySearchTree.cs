using System;
using System.Collections.Generic;
using Environment;

namespace Utils {
    // BSTNode class adapted from int to Employee
    public class BSTNode {
        public Employee data;
        public BSTNode leftChild = null;
        public BSTNode rightChild = null;

        public BSTNode(Employee data) {
            this.data = data;
        }
    }

    public class BinarySearchTree {
        private BSTNode root;

        // Constructor sets the first employee as the root node
        public BinarySearchTree(Employee rootData) {
            root = new BSTNode(rootData);
        }

        // Iterative Insert method using 'current' and 'lastParent'
        public void Insert(Employee data) {
            BSTNode newNode = new BSTNode(data);
            BSTNode current = root;
            BSTNode lastParent = null;

            DateTime dataTime = DateTime.Parse(data.lastEntranceInEngineRoom);

            // Walk down the tree until 'current' reaches null (an empty spot)
            while(current != null) {
                lastParent = current;
                DateTime currentTime = DateTime.Parse(current.data.lastEntranceInEngineRoom);

                if(dataTime < currentTime) {
                    current = current.leftChild;
                }
                else {
                    current = current.rightChild;
                }
            }

            // Attach the newNode to the left or right of 'lastParent'
            DateTime lastParentTime = DateTime.Parse(lastParent.data.lastEntranceInEngineRoom);
            if(dataTime < lastParentTime) {
                lastParent.leftChild = newNode;
            }
            else {
                lastParent.rightChild = newNode;
            }
        }

        // DFS (In-Order Traversal) using a Stack
        public List<Employee> DFS(DateTime startTime, DateTime endTime) {
            List<Employee> suspects = new List<Employee>();
            Stack<BSTNode> stack = new Stack<BSTNode>();
            BSTNode current = root;

            while(current != null || stack.Count > 0) {
                // Push all left children onto the stack
                while(current != null) {
                    stack.Push(current);
                    current = current.leftChild;
                }

                // Pop the top node and "visit" it (check if it matches our time range)
                current = stack.Pop();

                DateTime currentTime = DateTime.Parse(current.data.lastEntranceInEngineRoom);
                if(currentTime >= startTime && currentTime <= endTime) {
                    suspects.Add(current.data);
                }

                // Move to the right child
                current = current.rightChild;
            }

            return suspects;
        }
    }
}
