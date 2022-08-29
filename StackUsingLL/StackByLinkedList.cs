using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StackUsingLL
{
    public  class StackByLinkedList<T>
    {
         Node<T> head;
         int size;
        public StackByLinkedList()
        {
            head = null;
            size = 0;
        }
        public int Size()// FOR FINDING THE SIZE OF THE LINKED LIST
        {
            return size;
        }
        public bool isEmpty()// FOR FINDING WHETHER THE STACK IS EMPTY
        {
            return size == 0;   
        }
        public void  push(T elem)//FOR ADDING A NEW ELEMENT INTO THE STACK
        {

            Node<T> NewNode=new Node<T>(elem);
            NewNode.next= head;
            head= NewNode;
            size++;
        }
        public T top()// TO FIND THE TOP ELEMENT OF THE STACK BUT THE SIZE REMAINS SAME 
        {
            if(head == null)
            {
                throw new StackOverflowException();
            }
            return head.data;

        }
        public T pop()// TO RETURN THE TOP ELEMENT OF THE STACK AND SIZE OF THE STACK GETS REDUCED BY ONE EACH TIME
        {
            if (head == null)
            {
                throw new StackOverflowException();
            }
            T temp=head.data;
            head= head.next;
            size--;
            return temp;
        }
    }
}
