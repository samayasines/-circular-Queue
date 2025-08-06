using System;

namespace QUEUE
{
    internal class Program
    {
        class Node
        {
            public string data;
            public Node next;
            // public int priority;
            public Node(string value/*, int priority*/)
            {
                data = value;
                next = null;
                //   this.priority = priority;
            }

        }
        public class Queue
        {
            Node front;
            Node rear;
            public Queue()
            {
                front = null;
                rear = null;
            }
            public bool isempty()
            {
                if (front == null)
                {
                    return true;
                }
                else
                    return false;

            }

            public void Enqueue(string data)
            {

                Node newnode = new Node(data);

                if (isempty())
                {
                    front = rear = newnode;
                    rear.next = front;
                    Console.WriteLine(data + " IS ADDED");
                }
                else
                {
                    rear.next = newnode;
                    rear = newnode;
                    rear.next = front;



                }
            }







            public void dequeue()
            {
                if (isempty())
                {
                    Console.WriteLine("queue is empty");
                }
                else if (front == rear)
                {
                    front = rear = null;
                }
                else
                {
                    front = front.next;
                    rear.next = front;
                }

                Console.WriteLine("done");
            }

            public void peek()
            {
                if (isempty())
                {
                    Console.WriteLine("queue is empty");
                }
                else
                {
                    Console.WriteLine("front element is " + front.data);
                }
            }
            public void display()
            {
                if (isempty())
                {
                    Console.WriteLine("queue is empty");
                }
                else
                {
                    Node current = front;
                    do
                    {
                        Console.Write(current.data + " ");
                        current = current.next;
                    } while (current != front);


                }
            }
        }


        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue("sama");
            queue.Enqueue("nada");
            queue.Enqueue("sara");
            queue.display();


        }
    }
}