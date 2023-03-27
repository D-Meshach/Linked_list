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
