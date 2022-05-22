//Created by Rodrigo Martinez

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_10_Debug
{
    class Program
    {
        static void Main(string[] args)
        {
            //make some set
            Set A = new Set();
            Set B = new Set();

            //put some stuff in the sets
            Random r = new Random(); 
            for(int i = 0; i < 10; i++)
            {
                A.addElement(r.Next(4));
                B.addElement(r.Next(12));
            }

            //display each set and the union
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            Console.WriteLine("A Union B: " + A.union(B));

            //display original set (should be changed)
            Console.WriteLine("After union operation");
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);

        } 
    }
}

//SET
class Set
{
    private List<int> elements;
    public Set()
    {
        elements = new List<int>();
    }

    public bool addElement(int val)
    {
        if (containsElement(val)) return false;

        else
        {
            elements.Add(val);
            return true;
        }
    }

    private bool containsElement(int val)
    {
        for (int i = 0; i < elements.Count; i++)
        {
            if (val == elements[i])
                return true;
        }
        return false;
    }

    public override string ToString()
    {
        string str = "";
        foreach (int i in elements)
        {
            str += i + " ";
        }
        return str; 
    }
    public void clearSet()
    {
        elements.Clear();
    }

    public Set union(Set rhs)
    {
        Set val = new Set();
        for (int i = 0; i < rhs.elements.Count; i++)
        {
            this.addElement(rhs.elements[i]);
        }

        for(int i= 0; i < this.elements.Count; i++)
        {
            val.addElement(this.elements[i]);
        }
        return val;
    }
}
