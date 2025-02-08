// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

class HelloWorld
{
    class Node{
        public int Data;
        public Node Next;
        public Node(int data){
            Data = data;
            Next = null;
        }
    }
    class LinkedList{
        private Node Head;
        public void Insert(int data){
            Node newNode = new Node(data);
            if(Head == null){
                Head = newNode;
                return;
            }
            Node temp = Head;
            while(temp.Next != null){
                temp = temp.Next;
            }
            temp.Next = newNode;
        }
        public void Display(){
            Node temp = Head;
            while(temp != null){
                Console.Write(temp.Data + " -> ");
                temp=temp.Next;
            }
            Console.WriteLine("null");
        }
        public void Delete(int key){
            Node temp = Head;
            Node prev = null;
            if(temp != null && temp.Data == key){
                Head = temp.Next;
                return;
            }
            while(temp != null && temp.Data != key){
                prev = temp;
                temp = temp.Next;
            }
            if(temp == null) return;
            prev.Next = temp.Next;
        }
    }
    public static void Main(string[] args)
    {
        LinkedList list = new LinkedList();

        list.Insert(10);
        list.Insert(20);
        list.Insert(30);
        list.Insert(40);

        Console.WriteLine("Linked List before deletion:");
        list.Display();

        list.Delete(20);

        Console.WriteLine("Linked List after deleting 20:");
        list.Display();
        
    }
}
