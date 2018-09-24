using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree {
    class Node {
        private int value;

        public Node leftNode;
        public Node rightNode;

        public Node(int value) {
            this.value = value;
        }

        public int GetValue() {
            return value;
        }
    }
}
