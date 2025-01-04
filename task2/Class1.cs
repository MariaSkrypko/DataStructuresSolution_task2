namespace Library
{
    public class Class1
    {
        public class TreeNode
        {
            public int Data;
            public TreeNode Left;
            public TreeNode Right;

            public TreeNode(int data)
            {
                Data = data;
                Left = null;
                Right = null;
            } 
        }
        public class BinarySearchTree
        {
            public TreeNode Root { get; private set; }
            public int Count { get; set; }

            public BinarySearchTree()
            {
                Root = null;
                Count = 0;
            }
           public void Add(int value)
            {
                Root = AddRecursive(Root, value);
                Count++;
            }
            private TreeNode AddRecursive(TreeNode node, int value)
            {
                if(node == null)
                {
                    return new TreeNode(value);
                }
                if(node.Data > value)
                {
                    node.Left = AddRecursive(node.Left, value);
                }
                else if (node.Data < value)
                {
                    node.Right = AddRecursive(node.Right, value);
                }
                return node;
            }
            public bool Contains(int value)
            {
                return ContainsRecursive(Root, value);
            }
            private bool ContainsRecursive(TreeNode node, int value)
            {
                if(node == null)
                {
                    return false;
                }
                if (node.Data == value)
                {
                    return true;
                }
                else if(node.Data > value)
                {
                    return ContainsRecursive(node.Left, value);
                }
                else
                {
                    return ContainsRecursive(node.Right, value);
                }
            }
            public void Clear()
            {
                Root = null;
                Count = 0;
            }
            public object[] ToArray()
            {
                List<object> list = new List<object>();
                ToArrayRecursive(Root, list);
                return list.ToArray();
            }
            private void ToArrayRecursive(TreeNode node, List<object> list)
            {
                if (node == null) return;

                ToArrayRecursive(node.Left, list);
                list.Add(node.Data);
                ToArrayRecursive(node.Right, list);
            }
         }
    }
}
