using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber18GC
{
    class TheMostAwesomeList
    {
        public Node Head { set; get; }
        public Node Tail { set; get; }
        public int Count { set; get; }
        public void Add(string userInput)
        {
            if (Count == 0) //very first node
            {
                //1.Make a new node
                Node newNode = new Node { Next = null, Data = userInput };

                Head = newNode; //step 2
                Tail = newNode; //step 3
                Count++; //step 4
            }
            else
            {
                //1.
                Node newNode = new Node { Next = null, Data = userInput };

                //2. Change the tail reference
                Tail.Next = newNode;
                Tail = newNode;

                //3. increment the count
                Count++;

            }
        }
        public Node Get(int index)
        {
            int start = 0;
            Node temp = Head; //mark the start of the search
            while (start != index)
            {
                start++;
                temp = temp.Next;
            }
            return temp; //once found, return the node
        }
        public void Clear()
        {
            Count = 0;
            Head = null;
            Tail = null;
        }
        public void RemoveAll(string o)
        {
            //Node prev = Head;
            //Node current = Head.Next;
            //while(current!=null)
            //{if (

            Node node = Head;

            while (node.Data == o)
            {
                Head = Head.Next;
                node = node.Next;
                Count--;
            }
            while (node != null)
            {
                while (node.Next != null && node.Next.Data == o)
                {
                    node.Next = node.Next.Next;
                    Count--;
                }

                node = node.Next;
            }
        }
        public void PrintINfo()
        {
            Node node = Head;
            while (node != null)
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }
        }



    }

}

