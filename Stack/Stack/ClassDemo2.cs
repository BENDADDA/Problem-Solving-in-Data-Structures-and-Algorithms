//المكنبات النضام
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;                   /* البرنامج بالواجه الأوامر إضغط على التشغيل */

namespace Stack//المكان الإسم
{
    //القسم 
    class ClassDemo2
    {
        static int Main4(string[] args)//الدلة الاساسية 
        {

            HashTableArray<string> hashtable = new HashTableArray<string>(5);//تيئة الكائن 
            hashtable.Put(2,"bendadda");
            hashtable.Put(7, "jack");
            hashtable.Put(4,"benaouda");
            hashtable.Put(12, "Mohemad");
            hashtable.Put(56, "Khtla");
            hashtable.Put(10, "dexter");
            hashtable.Put(13, "TheNewBaghdada");
            hashtable.Put(13," بن دادة بن عودة");
            string str = hashtable.Out(13);
            Console.WriteLine("name:"+str );
            Console.ReadKey();
            return 0;
        }
    }
}
