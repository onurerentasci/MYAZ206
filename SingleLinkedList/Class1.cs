namespace SingleLinkedList
{
    public class SingleLinkedListNode<T>
    {
        public T value;
        public SingleLinkedListNode<T> Next;

        public SingleLinkedListNode(T Value)
        {
            value = value;
            Next = null;
        }
    }
    public class SingleLinkedList<T>
    {
        public SingleLinkedListNode<T> Head;
        public int Count = 0;

        public void AddFirst(T value)
        {
            SingleLinkedListNode<T> node = new SingleLinkedListNode<T> (value);
            node.value = value;
            node.Next = null;

            if(Head == null) { Head = node; Count++; }
            {
                node.Next = Head;
                Head = node;
                Count++;
            }
        }
        public void Show()
        {
            SingleLinkedListNode<T> node = Head;
            while(node != null)
            {
                Console.WriteLine(node.value);
                temp = temp.Next;
            }
        }
        public void AddLast(T value)
        {
            SingleLinkedListNode<T> node = new SingleLinkedListNode<T>(value);
            SingleLinkedListNode<T> temp = Head;
            node.value;
            node.Next = null;

            if (Head == null)
            {
                Head = node;
                Count++;
            }
            else if (Head != null)
            {
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
        }
    }
}