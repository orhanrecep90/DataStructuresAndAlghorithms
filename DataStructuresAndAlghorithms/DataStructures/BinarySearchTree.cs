
using System.Reflection;

namespace DataStructuresAndAlghorithms.DataStructures;

public class BinarySearchTree
{
    //              9
    //      4               20
    //  1       6       15      170
    public BNode Root { get; set; }
    public int Count { get; set; }

    public void Insert(int value)
    {
        var node = new BNode(value);
        if (Root==null)
        {
            Root= node;
        }
        else
        {
            var pointer = Root;
            while (true)
            {
                if (value < pointer.Value)
                {
                    //left
                    if (pointer.Left==null)
                    {
                        pointer.Left=node;
                        break;
                    }
                    else
                    {
                        pointer=pointer.Left;
                    }
                }
                else
                {
                    //right
                    if (pointer.Right==null)
                    {
                        pointer.Right=node;
                        break;
                    }
                    else
                    {
                        pointer=pointer.Right;
                    }
                }
            }
          
        }
    }

    public bool Lookup(int value)
    {
        if (Root is null)
        {
            return false;
        }
        var pointer = Root;
        while (pointer!=null)
        {
            if (value<pointer.Value)
            {
                pointer=pointer.Left;
            }
            else
            {
                if (pointer.Value == value)
                {
                    return true;
                }
                pointer = pointer.Right;
            }
        }
        return false;
    }

    public List<int> BreadthFirstSearch()
    {
        var current=Root;
        var list = new List<int>();
        var queue = new Queue<BNode>();
        queue.Enqueue(current);
        while (queue.Count > 0)
        {
            current = queue.Dequeue();
            list.Add(current.Value);
            if (current.Left!=null)
                queue.Enqueue(current.Left);

            if (current.Right!=null)
                queue.Enqueue(current.Right);
        }

        return list;
    }

    public List<int> BreadthFirstSearchRecursive()
    {
        var queue = new Queue<BNode>();
        queue.Enqueue(Root);
        return TraverseFirstSearch(queue, new List<int>());
    }
    private List<int> TraverseFirstSearch(Queue<BNode> queue,List<int> list)
    {
        if (queue.Count==0)
        {
            return list;
        }
        var current = queue.Dequeue();
        list.Add(current.Value);
        
        if (current.Left!=null)
            queue.Enqueue(current.Left);

        if (current.Right!=null)
            queue.Enqueue(current.Right);

        return TraverseFirstSearch(queue, list);
    }

    public List<int> DFSInOrder()
    {
        return TraverseInOrder(Root,new List<int>());
    }
    public List<int> DFSPostOrder()
    {
        return TraversePostOrder(Root,new List<int>());
    }

    public List<int> DFSPreOrder()
    {
        return TraversePreOrder(Root,new List<int>());
    } 
    
    private List<int> TraversePreOrder(BNode node,List<int> list)
    {
        list.Add(node.Value);
        if (node.Left != null)
            TraversePreOrder(node.Left, list);
        if (node.Right != null)
            TraversePreOrder(node.Right, list);
        
        return list;
    }
    private List<int> TraversePostOrder(BNode node,List<int> list)
    {
        if (node.Left != null)
            TraversePostOrder(node.Left, list);
        if (node.Right != null)
            TraversePostOrder(node.Right, list);
        
        list.Add(node.Value);
        return list;
    }

    private List<int> TraverseInOrder(BNode node,List<int> list)
    {
        if(node.Left!=null)
            TraverseInOrder(node.Left,list);
        list.Add(node.Value);
        if(node.Right!=null)
            TraverseInOrder(node.Right,list);
        return list;
    }
    
}

public class BNode 
{
    public BNode(int val)
    {
        Value = val;
    }
    public int Value { get; set; }
    public BNode Right { get; set; }
    public BNode Left { get; set; }
}