using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    //Klasse mit array T steht für platzhalter
    internal class Mylist<T>
    {
        //Tlist erstellen
        T[] items;
        //Konstruktor erstellen wert zuweisen
        public Mylist()
        {
            items= new T[0];
        }
        //ADD methode
        public void Add(T item)
        {
            //temparray erstellen welches die items sichert
            T[] tempArray = items;
            //items lsite neu erstellt mit +1
            items = new T[items.Length + 1];
            //for schleife um die länge von temparray
            for (int i = 0; i < tempArray.Length; i++)
            {
                //schreibt temparray[i] zu items[i] hinzu
                items[i] = tempArray[i];
            }
            //items wird zu item hinzugefügt
            items[items.Length - 1] = item;
        }
        public void Show()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
           
        }
        
        
            

        public int Count
        {
            get { return items.Length; }
            
        }

     

    }
}
 