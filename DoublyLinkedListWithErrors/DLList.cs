using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListWithErrors
{
   public class DLList
    {
        public DLLNode head; // pointer to the head of the list
        public DLLNode tail; // pointer to the tail of the list
       public DLList() { head = null;  tail = null; } // constructor
        /*-------------------------------------------------------------------
        * The methods below includes several errors. Your  task is to write
        * unit test to discover these errors. During delivery the tutor may
        * add or remove errors to adjust the scale of the effort required by
        */
        public void addToTail(DLLNode p)
        {
            //changed code
            if (head == null)
            {
                head = p;
                tail = p;
            }
            else
            {
                tail.next = p;
                p.previous = tail;
                p.next = null;
                tail = p;                
            }

            /*if (head == null)
            {
                head = p;
                tail = p;
            }
            else
            {
                tail.next = p;
                tail = p;
                p.previous = tail;
            }*/
        } // end of addToTail

        public void addToHead(DLLNode p)
        {
            if (head == null)
            {
                head = p;
                tail = p;
            }
            else
            {
                p.next = this.head;
                this.head.previous = p;
                head = p;
            }
        } // end of addToHead

        public void removHead()
        {
            //changed code
            if (this.head == null) return;
            if(this.head == this.tail)
            {
                this.head = null;
                this.tail = null;
                return;
            }
            this.head = this.head.next;
            this.head.previous = null;
            return;

            /* if (this.head == null) return;
             this.head = this.head.next;
             this.head.previous = null;*/
        } // removeHead

        public void removeTail()
        {
            //change code
            if (this.tail == null) return;
            if (this.head == this.tail)
            {
                this.head = null;
                this.tail = null;
                return;
            }
            this.tail = this.tail.previous;
            this.tail.next = null;
            return;
            /*if (this.tail == null) return;
            if (this.head == this.tail)
            {
                this.head = null;
                this.tail = null;
                return;
            }*/
        } // remove tail

        /*-------------------------------------------------
         * Return null if the string does not exist.
         * ----------------------------------------------*/
        public DLLNode search(int num)
        {
            //change code
            DLLNode p = head;
            while (p != null)
            {                
                if (p.num == num) break;
                p = p.next;
            }
            return (p);
            /*DLLNode p = head;
            while (p != null)
            {
                p = p.next;
                if (p.num == num) break;
            }
            return (p);*/
        } // end of search (return pionter to the node);

        public void removeNode(DLLNode p)
        { // removing the node p.

            //changed code
            if(p == null || this.head == null) //checking whether p is null or empty list
            {
                return;
            }

            if (this.head == p && this.tail == p) //when there is only one node in a list
            {
                this.head = null;
                this.tail = null;
                return;
            }      

            if (p.next == null) //when p is last node
            {
                this.tail = this.tail.previous;
                this.tail.next = null;
                p.previous = null;
                return;
            }

            if (p.previous == null) //when p is the first node
            {
                this.head = this.head.next;
                p.next = null;
                this.head.previous = null;
                return;
            }
            
            //when p is in middle position
            p.previous.next = p.next;
            p.next.previous = p.previous;
            p.next = null;
            p.previous = null;
            return;
            /*if (p.next == null)
            {
                this.tail = this.tail.previous;
                this.tail.next = null;
                p.previous = null;
                return;
            }

            if (p.previous == null)
            {
                this.head = this.head.next;
                p.next = null;
                this.head.previous = null;
                return;
            }
            p.next.previous = p.previous;
            p.previous.next = p.next;
            p.next = null;
            p.previous = null;
            return;*/
        } // end of remove a node

        public int total()
        {
            //changed code
            DLLNode p = head;
            int tot = 0;
            while (p != null)
            {
                tot += p.num;
                p = p.next;
            }
            return (tot);

            /*DLLNode p = head;
            int tot = 0;
            while (p != null)
            {
                tot += p.num;
                p = p.next.next;
            }
            return (tot);*/
        } // end of total
    } // end of DLList class
}
