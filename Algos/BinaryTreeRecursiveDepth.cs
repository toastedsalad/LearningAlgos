using System.Collections.Generic;

namespace LearningAlgos;

public class BinaryTreeRecursiveDepth {
    public int MaxDepth(TreeNode root) {
        var currentDepth = 0;
        var newDepth = 0;
        var currentNode = root;
        var stack = new Stack<int>();

        while (stack.Count > 0) {
            currentDepth += 1;
            if (currentNode.left == null && currentNode.right == null) {
                newDepth = currentDepth;
                currentNode = null; // We need to somehow go back.
            }
            else if (currentNode.left != null) {
                currentNode = currentNode.left;
            }
            else {
                currentNode = currentNode.right;
            }
        }
        return newDepth;
    }
}
