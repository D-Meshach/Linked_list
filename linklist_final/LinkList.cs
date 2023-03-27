using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace linklist_final
{
    public class LinkList
    {
        public LinkList() 
        {
            LinkListProcess processing = new LinkListProcess();
            //UC1,UC2 Sequence 56->30->70
            Console.WriteLine("Reverse--");
            processing.AddReverse(70);
            processing.AddReverse(30);
            processing.AddReverse(56);
           
            processing.Displayreverse();
            //UC3 Sequence 70->30->56
            Console.WriteLine("Forward--");
            LinkListProcess processForward = new LinkListProcess();
            processForward.AddForward(70);
            processForward.AddForward(30);
            processForward.AddForward(56);
            processForward.DisplayForward();
            //UC4 Inserting between numbers
            LinkListProcess processInsert = new LinkListProcess();

            Console.WriteLine("Insert Element sequence 56->30->70 --");
            processInsert.AddReverse(70);
            processInsert.AddReverse(30);
            processInsert.AddReverse(56);
            processInsert.insertdata(23, 3);
            processInsert.Displayreverse();




        }
       
    }
    public class LinkListProcess
    {

        public Node head,start;

        public LinkListProcess()
        {
            this.head = null;
            
        }
        public void AddReverse(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
                this.start = node;

            }
            else
            {
               
                node.next = head;
                head = node;
            }


        }
        
       
        public void Displayreverse()
        {
            Node tmp=head;
            while (tmp != null)
            {
                Console.WriteLine("Values are=" + tmp.data);
                tmp = tmp.next;
            }
        }

        public void AddForward(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
                this.start = node;

            }
            else
            {
                head.next = node;
                node = head;
                head = node.next;

            }
        }
        public void insertdata(int data, int position)
        {
           // Console.WriteLine("Total Countpresent=" + countelement());
            Node node = new Node(data);
            Console.WriteLine("Insert position=" + position);
            if (position == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node newnode = head, oldnode;
                int count = 1;
                while (newnode != null)
                {

                    oldnode = newnode;

                   // Console.WriteLine("\nDatas =" + newnode.data);
                    newnode = newnode.next;

                    if (position > countelement() + 1)
                    {
                        Console.WriteLine("Index Out of Range");
                        break;
                    }
                    else if (count == position - 1)
                    {

                        node.next = newnode;
                        oldnode.next = node;
                        newnode = head;
                       // Console.WriteLine("oldnode=" + oldnode.data + " New node=" + newnode.data);
                        break;
                    }

                    count++;

                }
               // Console.WriteLine("Total nodes=" + count);

            }

        }
        public int countelement()
        {
            int count = 0;
            Node node = head;
            while (node != null)
            {
                count++;
                node = node.next;

            }
            return count;
        }


        public void DisplayForward()
        {
            Node tmp = start;
            while (tmp != null)
            {
                Console.WriteLine("Values are=" + tmp.data);
                tmp = tmp.next;
            }
        }

    }
}
