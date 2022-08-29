namespace StackUsingLL
{
    public class Node<T>//FUNDAMANTAL UNIT OF LINKEDLIST
    {
        internal T data;
        internal Node<T> next;
        public Node(T data)
        {
            this.data = data;
        }

    }
}