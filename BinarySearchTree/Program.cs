using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree {
    class Program {

        /// <summary>
        /// Recursively inserts a node into the correct location in the binary search tree. Call this method with the root node of the tree
        /// </summary>
        /// <param name="rootNode">The current location in the tree. You should only ever call this with the root node</param>
        /// <param name="value">The value of the new node</param>
        /// <returns></returns>
        public Node InsertNode(Node rootNode, int value) {

            if (rootNode == null) { //we have reached the end of the tree, so insert the new node here
                Node newNode = new Node(value);
                rootNode = newNode;
            }
            else if (value > rootNode.GetValue()) { // The current node's value is smaller than the new node's value, so insert to the right
                rootNode.rightNode = InsertNode(rootNode.rightNode, value);
            }
            else {
                rootNode.leftNode = InsertNode(rootNode.leftNode, value); // The current node's value is greater than the new node's value, so insert to the left
            }

            return rootNode;
        }

        /// <summary>
        /// Returns a Node object with the specified value, or null if no node exists in the tree with the
        /// value specified. This is a recursive method. You should only call this method using the root node.
        /// </summary>
        /// <param name="rootNode">The current location in the tree. You should only call this method with the root node</param>
        /// <param name="searchValue">The value we are searching for</param>
        /// <returns></returns>
        public Node FindNode(Node rootNode, int searchValue) {

            if (rootNode == null) { //we have reached the end of the tree, and the search value was never found
                return null;
            }
            else if (searchValue == rootNode.GetValue()) { //we have found the node we were looking for, so return it
                return rootNode;
            }
            else if (searchValue < rootNode.GetValue()) { // The current node's value is greater than the search value, so look to the left
                return FindNode(rootNode.leftNode, searchValue);
            }
            else {
                return FindNode(rootNode.rightNode, searchValue); // The current node's value is less than the search value, so look to the right
            }
        }

        static void Main(string[] args) {

            Program binaryTree = new Program();

            Node rootNode = binaryTree.InsertNode(null, 2);
            binaryTree.InsertNode(rootNode, 5);
            binaryTree.InsertNode(rootNode, 34);
            binaryTree.InsertNode(rootNode, 22);
            binaryTree.InsertNode(rootNode, 6);
            binaryTree.InsertNode(rootNode, 45);
            binaryTree.InsertNode(rootNode, 3);
            binaryTree.InsertNode(rootNode, 3);
            binaryTree.InsertNode(rootNode, 76);
            binaryTree.InsertNode(rootNode, 5);
            binaryTree.InsertNode(rootNode, 4);
            binaryTree.InsertNode(rootNode, 8);

            int searchValue = 45;
            Node foundNode = binaryTree.FindNode(rootNode, searchValue);

            if (foundNode != null) {
                Console.WriteLine("Found Node {0} with value {1}", foundNode, foundNode.GetValue());
            }
            else {
                Console.WriteLine("No node found with value {0}", searchValue);
            }
        }
    }
}
