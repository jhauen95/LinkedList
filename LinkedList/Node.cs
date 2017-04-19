using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * This is a node class which contains an object (the content of the node) 
 * and a reference (or "pointer") to the next Node.
 *  
 *      Node:    [ content  | next--> ] 
 */

/* Node shares the same namespace as LinkedList*/
namespace LinkedList 
{
    /*Name your class. This is the blueprint of your object*/
    class Node
    {
        /*Here is where we add what we want to make up our our class*/
        public Object contents { get; set; }
        public Node next;

        /*this is an example of a constructor*/
        public Node()
        {
            contents = null;
            next = null;
            /*when someone makes a 
             * Node newNode = new Node(); 
             * the code in the constructor is executed
             */
        }

        /*this is an example of an overloaded constructor*/
        public Node(Object obj)
        {
            contents = obj;
            next = null; 
            /*when someone makes a 
             * Node newNode = new Node(object); 
             * contents is set to "object
             */
        }


    }
}
