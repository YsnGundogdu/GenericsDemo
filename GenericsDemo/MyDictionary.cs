using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDemo
{
    class MyDictionary<K,V>
    {
        K[]  studentNumber;
        V[]  studentName;

        public MyDictionary()
        {
            studentNumber = new K[0];
            studentName = new V[0];

        }

        public void Add(K item1,V item2)
        {
            K[] tempKeyArray = studentNumber;
            V[] tempValueArrat = studentName;

            studentNumber = new K[studentNumber.Length + 1];
            studentName = new V[studentName.Length + 1];

            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                studentNumber[i] = tempKeyArray[i];
                studentName[i] = tempValueArrat[i];

            }

            studentNumber[studentNumber.Length - 1] = item1;
            studentName[studentName.Length - 1] = item2;

        }

        public void List()
        {
            for (int i = 0; i < studentName.Length; i++)
            {
                Console.WriteLine(studentNumber[i] + " no'lu öğrencimiz: " + studentName[i]);

            }
        }
    }
}
