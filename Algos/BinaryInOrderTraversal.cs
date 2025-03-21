using System.Collections.Generic;

namespace LearningAlgos;

public class BinaryInOrderTraversal {
    public IList<int> InorderTraversal(TreeNode root) {
        var list = new List<int> ();
        Walk(root, list);
        return list;
    }

    public static void Walk (TreeNode root, IList<int> list) {
        // Base case: if node is is null, return
        if (root == null) return;

        // Recursion stages:
        // 1. If possible go to the left:
        if (root.left != null) {
            Walk(root.left, list);
        }

        // 2. We get here if is no longer possible to go to the left
        list.Add(root.val);

        // 3. Recurse to the right subtree
        if (root.right != null) {
            Walk(root.right, list);
        }
    }
}
