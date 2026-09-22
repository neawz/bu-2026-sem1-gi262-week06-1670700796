using System.Collections.Generic;
using UnityEngine;

namespace MidtermExam.Prob02
{
    public class LinkedListSorter
    {
        /// <summary>
        /// เรียงลำดับตัวเลขใน LinkedList จากน้อยไปมาก (Ascending Order)
        /// </summary>
        /// <param name="list">LinkedList ของตัวเลข integer</param>
        /// <returns>LinkedList ที่ได้รับการเรียงลำดับจากน้อยไปมากแล้ว</returns>
        public LinkedList<int> SortAscending(LinkedList<int> list)
        {
            // TODO: Implement sorting algorithm for LinkedList<int> (Ascending)
            if (list == null || list.Count <= 1)
            {
                return list;
            }

            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    var currentNode = list.First;
                    for (int k = 0; k < j; k++)
                    {
                        currentNode = currentNode.Next;
                    }

                    if (currentNode.Value > currentNode.Next.Value)
                    {
                        int temp = currentNode.Value;
                        currentNode.Value = currentNode.Next.Value;
                        currentNode.Next.Value = temp;
                    }
                }
            }
            
            return list;
        }

        /// <summary>
        /// เรียงลำดับตัวเลขใน LinkedList จากมากไปน้อย (Descending Order)
        /// </summary>
        /// <param name="list">LinkedList ของตัวเลข integer</param>
        /// <returns>LinkedList ที่ได้รับการเรียงลำดับจากมากไปน้อยแล้ว</returns>
        public LinkedList<int> SortDescending(LinkedList<int> list)
        {
            // TODO: Implement sorting algorithm for LinkedList<int> (Descending)
            if (list == null || list.Count <= 1)
            {
                return list;
            }

            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    var currentNode = list.First;
                    for (int k = 0; k < j; k++)
                    {
                        currentNode = currentNode.Next;
                    }

                    if (currentNode.Value < currentNode.Next.Value)
                    {
                        int temp = currentNode.Value;
                        currentNode.Value = currentNode.Next.Value;
                        currentNode.Next.Value = temp;
                    }
                }
            }

            return list;
        }
    }
}
