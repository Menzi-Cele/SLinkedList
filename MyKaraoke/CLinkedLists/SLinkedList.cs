using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MyKaraoke.CLinkedLists
{
    class SLinkedList
    {
        CustomNode head;
        CustomNode current;
        String data;
        int nodeCount;

        public void appendNode(string data)
        {
            if (head == null)
            {
                head = new CustomNode(data);
                nodeCount++;
                return;
            }

            current = head;

            while(true)
            {
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = new CustomNode(data);
            }
        }

        public void prepend(String data)
        {
            if (head == null)
            {
                head = new CustomNode(data);

            }
            else
            {
                CustomNode newHead = new CustomNode(data);
                nodeCount++;

                newHead.Next = head;

                head = newHead;
            }
        }

        public void deleteWithData(String data)
        {
            if (head != null)
            {
                MessageBox.Show("cannot a value from an empty list");
                return;
            }


            if (head.data.Equals(data))
            {
                head = head.Next;
            }

            current = head;

            while (current.Next != null)
            {
                if (current.Next.data.Equals(data))
                {
                    current = current.Next;
                }

                current = current.Next;

                MessageBox.Show("could not delete the data, data not present in list");
            }
        }

        public void applyProfanityFilter(string data)
        {
            if(head ==null)
            {
                MessageBox.Show("No list to clean");
            }
            if (head.data.Contains(data))
            {
                string replaceString = head.data.Replace(data, "******");
                head.data = replaceString;
                MessageBox.Show(head.data);
                return;
            }

            current = head;

            while(current.Next != null)
            {
                current = current.Next;
                if (current.data.Contains(data))
                {
                    string replaceString = current.data.Replace(data, "*****");
                    current.data = replaceString;
                    MessageBox.Show(current.data);
                    return;
                }
            }
        }

        public void insertAfter(string nodeData, string searchData)
        {
            if(head == null)
            {
                MessageBox.Show("Test");
            }

            if (head.data.Contains(searchData))
            {
                CustomNode insertNode = new CustomNode(nodeData);
                insertNode.Next = head.Next;
                head.Next = insertNode;
            }

            current = head;

            while(current.Next != null)
            {
                current = current.Next;
                if (current.data.Contains(searchData))
                {
                    CustomNode insertNode = new CustomNode(nodeData);
                    insertNode.Next = head.Next;
                    head.Next = insertNode;
                }
            }
        }

        public void insertBefore(string nodeData, string searchData)
        {

        }


    }
}
