using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec7LessonTestSolution
{
    internal class Program
    {
        public static int FindMaxInList(Node<int> myList) 
        
        {
            if (myList == null)
            {
                return 0;
            }
            
            int max = myList.GetValue();
            myList = myList.GetNext();
            while (myList != null) 
            {
               max =Math.Max(max, myList.GetValue());
                myList = myList.GetNext();
            }
            return max;
        }

        public static int FindMinInList(Node<int> myList)
        {
            if (myList == null)
            {
               
                return 0;
            }

            int min = myList.GetValue();
            myList = myList.GetNext();

            while (myList != null)
            {
                min = Math.Min(min, myList.GetValue());
                myList = myList.GetNext();
            }

            return min;
        }

        public static int CountLengthOfList(Node<int> myList)
        {
            int count = 0;

            while (myList != null)
            {
                count++;
                myList = myList.GetNext();
            }

            return count;
        }


        public static void printList(Node<int> head)
        {

            Node<int> current = head;
            while (current != null)
            {
                Console.Write($" {current.GetValue()}>>");
                current = current.GetNext();
            }
            Console.WriteLine("null");


        }

        public static Node<int> CreateLinkedList (int[] arr)
        {
            Node<int> head = null;
            Node<int> current = null;

            for (int i = 0; i < arr.Length; i++)
            {
                int value = arr[i];

                if (head == null)
                {
                    head = new Node<int>(value);
                    current = head;
                }
                else
                {
                    Node<int> newNode = new Node<int>(value);
                    current.SetNext(newNode);
                    current = newNode;
                }
            }

            return head;
        }
        public static bool IsArranged ( Node<int> myList)
        {

            

            int lengthOfHalf = CountLengthOfList(myList)/2;

            Node<int > head = myList;

            Node<int> secondHalf= myList;

            for (int i = 0;i < lengthOfHalf;i++) 
            {
                secondHalf = secondHalf.GetNext();
            }
            int maxOfFirstHalf = head.GetValue();
            for (int i = 0;i<lengthOfHalf;i++)
            {
                if (head.GetValue() > maxOfFirstHalf)
                {
                    maxOfFirstHalf= head.GetValue();
                }

            }
            printList(secondHalf);
            return CountLengthOfList(myList) % 2 == 0&& FindMinInList(secondHalf)>maxOfFirstHalf;
        }
        public static bool IsExist(Node<Rational> rationalList, Rational targetRational)
        {while (rationalList != null)
            {
                if (rationalList.GetValue().GetMechane() == targetRational.GetMechane())
                {
                    return true;
                }
            }
            return false;
        }

        public static Rational SumNum(Node<Rational> rationalList, int targetNumber)
        {
            int sum = 0;

            while (rationalList != null) 
            {
                if (rationalList.GetValue().GetMechane() == targetNumber)
                {
                    sum += rationalList.GetValue().GetMone();
                }
            }

            return (new Rational (sum,targetNumber));
        }



        public static bool IsArranged1(Node<int> lst)
        {
            int ln = CountLengthOfList(lst);

            if (ln % 2 != 0)
            {
                return false;
            }

            Node<int> tempLst = lst;
            int max = tempLst.GetValue();
            for (int i = 0; i < ln / 2; i++)
            {
                if (tempLst.GetValue() > max)
                { 
                    max = tempLst.GetValue();
                }
                tempLst = tempLst.GetNext();
            }
            int min = tempLst.GetValue();
            while (tempLst != null)
            {
                if (tempLst.GetValue() < min)
                {
                    min = tempLst.GetValue();
                }
                tempLst = tempLst.GetNext();
            }

            return max < min;
        }


        public static bool IsExist1(Node<Rational> lst, Rational toCheck)
        {
            while (lst != null)
            {
                if (lst.GetValue().GetMechane() == toCheck.GetMechane())
                {
                    return true;
                }
                lst = lst.GetNext();
            }
            return false;
        }
        public static Rational SumNum1(Node<Rational> lst, int mechaneToCheck)
        {
            int sum = 0;
            while (lst != null) 
            {
                if (lst.GetValue().GetMechane() == mechaneToCheck)
                {
                    sum += lst.GetValue().GetMone();
                }
                lst = lst.GetNext();
            }
            Rational res = new Rational(sum, mechaneToCheck);
            return res;
            //return new Rational(sum,mechaneToCheck);
        }

        public static bool IsArranged2(Node<int> lst)
        {
            int lengthOfList = CountLengthOfList(lst);
            if (lengthOfList % 2 != 0) 
            {
                return false;
            }

            Node<int> secondHalf = lst;
            int half = lengthOfList / 2;

            for (int i = 0; i < half; i++)
            {
                secondHalf = secondHalf.GetNext();
            }

            int max = lst.GetValue();
            int min = secondHalf.GetValue();
            for (int i = 0; i < half; i++)
            {
                if (lst.GetValue() > max)
                {
                    max = lst.GetValue();
                }
                if (secondHalf.GetValue() < min)
                {
                    min = secondHalf.GetValue();
                }

                secondHalf = secondHalf.GetNext();
                lst = lst.GetNext();
            }

            return max < min;
        }

        public static bool IsExist2(Node<Rational> lst, Rational rt)
        {
            while (lst != null)
            {
                if (rt.GetMechane() == lst.GetValue().GetMechane())
                {
                    return true;
                }
                lst = lst.GetNext();
            }
            return false;
        }

        public static Rational SumNum2(Node<Rational> lst, int MechaneToCheck)
        {
            int sum = 0;
            while (lst != null)
            {
                if (lst.GetValue().GetMechane() ==  MechaneToCheck)
                {
                    sum += lst.GetValue().GetMone();
                }
                lst = lst.GetNext();
            }
            //return new Rational(sum, MechaneToCheck);
            Rational res = new Rational(sum, MechaneToCheck);
            return res;
        }

        static void Main(string[] args)
        {
            int[] array = { 3, -4,4, 7, 15, 95,1,2};

            Node<int> listOnMain = CreateLinkedList(array);

            printList(listOnMain);
        }

        
    }
}
