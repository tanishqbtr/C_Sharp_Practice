using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice
{
    class GenericChef
    {
     
        //making this function virtual to change the vlaues in Inherited Class
        public virtual void IndianFood()
        {
            Console.WriteLine("Chef made Butter Chicken!");
        }
        public void ThaiFood()
        {
            Console.WriteLine("Chef made Ramen Noodles!");
        }
        public void ItalianFood()
        {
            Console.WriteLine("Chef made Pasta!");
        }
    }
}
