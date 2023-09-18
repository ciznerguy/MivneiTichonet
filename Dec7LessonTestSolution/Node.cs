using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec7LessonTestSolution
{
    public class Node<T>
    {
        private T value;
        private Node<T> next;

        //-----------------------------------
        //null פעולה המקבלת ערך ובונה חוליה עם הצבעה לחוליה הבאה בערך 
        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
        // פעולה המקבלת ערך ומצביע לחוליה הבאה
        //ובונה חוליה עם הצבעה לחוליה הבאה  

        public Node(T value, Node<T> next)
        {
            this.value = value;
            this.next = next;
        }
        //-----------------------------------
        //פעולה המחזירה את ערך החוליה
        public T GetValue()
        {
            return this.value;
        }
        //פעולה המחזירה מצביע לחוליה הבאה

        public Node<T> GetNext()
        {
            return this.next;
        }
        //-----------------------------------
        //פעולה קובעת את ערך החוליה
        public void SetValue(T value)
        {
            this.value = value;
        }

        //פעולה המעדכנת את המצביע לחוליה הבאה
        public void SetNext(Node<T> next)
        {
            this.next = next;
        }
        //-----------------------------------
        //פעולה הבודקת אם ישנו מצביע לחוליה הבאה
        public bool HasNext()
        {
            return (this.next != null);
        }

        public override string ToString()
        {

            return this.value + ">>" + next;
        }
    }
}
