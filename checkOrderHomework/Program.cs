using System;
using System.Collections;
namespace checkOrderHomework
{
    class Program
    {
        static bool checkOrder(string value)
        {
            Stack st = new Stack();
            foreach (var character in value)
            {
                if (st.Count != 0)
                {
                    if (st.Peek().Equals(character))
                    {
                        st.Pop();
                    } else
                    {
                        st.Push(character);
                    }
                } else
                {
                    st.Push(character);
                }
            }
            if (st.Count == 0)
                return true;
            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(checkOrder("112112333223322344")); //True
            Console.WriteLine(checkOrder("121255")); //False
        }
    }
}
