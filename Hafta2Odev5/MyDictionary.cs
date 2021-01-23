using System;
using System.Collections.Generic;
using System.Text;

namespace Hafta2Odev5
{
    class MyDictionary<key,value>
    {
        key[] Ids;
        value[] Names;

        public MyDictionary()
        {
            Ids = new key[0];
            Names = new value[0];

        }
        public void Add(key Id,value Name)
        {
            key[] tempArray = Ids;
            Ids = new key[Ids.Length + 1];
            value[] tempArrayV = Names;
            Names = new value[Names.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                Ids[i] = tempArray[i];
            }
            Ids[Ids.Length - 1] = Id;
            for (int i = 0; i < tempArrayV.Length; i++)
            {
                Names[i] = tempArrayV[i];
            }
            Names[Names.Length - 1] = Name;
            Console.WriteLine(Id + " " + Name + " :Başarıyla Eklendi!");
        }
    
        
    }

}
