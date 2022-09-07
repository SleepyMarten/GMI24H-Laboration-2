using LaborationInterfaces;
using Lastname_Firstname;
using System;

namespace ConsoleApp
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override bool Equals(object obj)
        {
            Person other = obj as Person; 
            return Name == other?.Name && Age == other?.Age;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Age.GetHashCode();
        }

        public override string ToString()
        {
            return Name + ", " + Age + " år";
        }
    }

    /// <summary>
    /// I klassen Program kan du prova de metoder som du implementerar. Om du vill så sätt gärna upp en ett separat projekt för en testmiljö.
    /// Om du får problem under arbetet så besök gärna handledningstillfällena och diskutera de svårigheter som du har stött på.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Implementera först klassen Laboration_2_LinkedList och kontrollera att den fungerar tillsammans med gränssnittet ILab2List,
            ILaboration_2_ListInt<Person> list = new Laboration_2_LinkedList<Person>();

            // När du är klar MyLinkedList, så ta itu med klassen Laboration_2_ArrayList och implementera den på liknande sätt som du gjorde med MyLinkedList.
            //ILab2List<Person> list = new Laboration_2_ArrayList<Person>();

            Person kalle = new Person() { Name = "Kalle", Age = 34 };

            // Se till att metoden AddFirst i gränssnittet ILab2List hamnar utanför den kommentar som omsluter alla metoderna.
            // Ta bort kommentaren för följande sats och implemntera AddFirst i klassen MyLinkedList. Felsök med hjälp av debuggern.
            //list.AddFirst(kalle);

            // Fortsätt med att ta bort kommentaren för Iterate i gränssnittet
            // Ta bort kommentaren följande sats och implementera metoden i MyLinkedList, felsök och provkör.
            //list.Iterate(Console.WriteLine);

            // Fortsätt därefter att på samma sätt, att implementera en metod i taget, till dess att alla metoder i listans gränsssnitt fungerar.

            // Utöka även detta testprogram genom fler anrop, inklusive anrop som ska kasta fel.
            // Ett bra alternativ är att lägga till ett testprojekt och skriva enhetstester med hjälp av
            // MSTest (v2) eller NUnit. (Kursen fördjupar sig dock inte i dessa tekniker.)

            Console.WriteLine("\nTryck på Enter för att avsluta.");
            Console.ReadLine();
        }
    }
}
