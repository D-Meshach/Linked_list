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
            
            Console.WriteLine("Reverse--");
            processing.AddReverse(70);
            processing.AddReverse(30);
            processing.AddReverse(56);
            processing.Displayreverse();
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



    }
}
