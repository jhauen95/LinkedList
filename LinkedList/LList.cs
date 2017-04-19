using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * LinkedList is a singly linked list (only links to the "next" node). 
 * It is useful because it can store any type of data and is dynamically sized
 * (as nodes are added, the list grows). Add and Remove methods are fairly simple
 * and quick.
 * 
 * LinkedList structure is depicted here:
 *              root --> [ content  | next--]--> [ content | next--]--> null
 */

namespace LinkedList
{
    class LList
    {
        //the list will have a root (or "start") node.
        public Node root { get; set; }


        /*---------METHODS BELOW-------------*/

        public bool add(Object obj)
        {
            Node n = new Node(obj); //create a Node instance

            if (root == null) //check to see if the root is null
            {
                root = n; //set the root node (first in the list)
                return true;
            }
            
            else
            {
                Node temp = root; //get a "stepper" node
                //get to the end of the list
                while (temp.next != null)
                {
                    temp = temp.next; //step through the list
                }
                temp.next = n; //found the end, put it here
                return true;
            }
        }


        //remove a node from the list
        public bool remove(Object obj)
        {
            Node toRemove = findNode(obj); //find it first
            if(toRemove == null) //make sure it isn't null
            {
                Console.WriteLine("No such node exists to delete");
            }
            else
            {
                Node temp = root;
                if(temp.Equals(toRemove)) //if we are removing the root node
                {
                    root = root.next; //if we are deleting root, reset the root node
                    return true;
                }
                else
                {//wee need to find the node before the node we are removing
                    while(!temp.next.Equals(toRemove))
                    {
                        temp = temp.next;//step through the list
                    }
                    //re-assign the reference to the (next)next node
                    temp.next = toRemove.next; 
                    return true;
                }
            }
            return false;
        }

        //check whether or not the node exists in the list
        public Node findNode(Object obj)
        {
            Node temp = root;
            while(temp != null)
            {//go through the list looking for the object
                if (temp.contents.Equals(obj)) //check it for equivalence
                {
                    return temp; //return it if found
                }
                temp = temp.next; //step to the next node
            }
            Console.WriteLine("No such node exists.");
            return null; //It doesn't exist
        }

        //print the Linkedlist to the console
        public void printList()
        {
            //check for an empty list
            if(root == null)
            {
                Console.WriteLine("[ EMPTY ]");
            }
            //If it is not an empty list
            else
            {
                Node temp = root; //temporary storage node for stepping through the list
                while (temp.next != null)//check for the end of the list
                {
                    Console.Write("[ " + temp.contents.ToString() + " ] --> ");
                    temp = temp.next;//step to the next node
                }
                //print the final node
                Console.Write("[ " + temp.contents.ToString() + " ] --> null");
                Console.WriteLine();
            }
          
        }

        /*-------END OF METHODS-----------*/


        static void Main(string[] args)
        {
            //Make an instance of a LinkedList called "myList" 
            LList myList = new LList();

            //Add things to the list
            myList.add("Car");
            myList.add("Train");
            myList.add("Bus");
            myList.add("Motorcycle");
            myList.add("Sloth");
            myList.add("Bike");
            myList.add("Scooter");
            
            //print the list
            myList.printList();

            Console.WriteLine("Remove \"Sloth\" from the list");
            myList.remove("Sloth");

            //print the list
            myList.printList();


        }
    }
}
