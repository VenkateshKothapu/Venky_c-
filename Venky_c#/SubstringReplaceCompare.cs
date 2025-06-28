using System;
 class SubstringReplaceCompare
 {
    static void Main(String[] args) 
    {
        //Substring()
        string Name = "VENKATESH REDDY";
        string firstname = Name.Substring(0, 9);
        string lastname = Name.Substring(10, 5) ;
        Console.WriteLine(firstname);
        Console.WriteLine(lastname);

        //Replace()


        string sentence = "i like javascript";
        string updatedsentence = sentence.Replace("javascript", "c#");
        Console.WriteLine(updatedsentence);

        string car = "i like BMW and now it is MARUTHI";
        string updated = car.Replace("MARUTHI", "LANDROVER");
        Console.WriteLine(updated);

        //Comapre()

        int result = string.Compare("banana", "apple");
        Console.WriteLine(result);//1---->greater
        int checking = string.Compare("apple", "Banana");
        Console.WriteLine(checking);//-1--->less
        int equal = string.Compare("dog","dog");
        Console.WriteLine(equal);//0--->eqaul



    }
 }

