using System;
using System.Collections;


namespace HashtableProjectTrainining
{
    class Program
    {
        private Hashtable ht = new Hashtable();
        enum Options { AddData = 1, RemoveData, UpdateData, AccessData, CountData, ClearData, CloneData, MiscellaneousData, ContainsKey, ContainsValue};
        
        static void Main(string[] args)
        {
            
            Program program = new Program();
            program.InitializeHash();

            
           
            int choice;
            do
            {

                Console.WriteLine("");
                Console.WriteLine("Hashtable operations");
               
                Console.WriteLine();
                Console.WriteLine("Enter Opertion choice : ");
                Console.WriteLine("1 for Addition of data ");
                Console.WriteLine("2 for Removal of data ");
                Console.WriteLine("3 for Updation of data ");
                Console.WriteLine("4 for Accessing data ");
                Console.WriteLine("5 for counting data");
                Console.WriteLine("6 for clearing data");
                Console.WriteLine("7 for cloaning data");               
                Console.WriteLine("8 for getting miscellaneous information about hashtable");
                Console.WriteLine("9 for checking existance of key");
                Console.WriteLine("10 for checking existance of value");
                
                Console.WriteLine("0 to exit");
              
                Console.WriteLine();
                string choiceText = Console.ReadLine();
                if (int.TryParse(choiceText, out choice))
                {
                    Program.Options options = (Program.Options)choice;
                    Console.WriteLine();
                    Console.WriteLine("You have Selected " + options.ToString());
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    choice = 9;
                }

                switch(choice)
                {
                    case 1:

                        Console.WriteLine("Enter Key : ");
                        var key = Console.ReadLine();
                        Console.WriteLine("Enter Value : ");
                        var value = Console.ReadLine();
                        program.AdditionToHashtable(key, value);
                        Console.WriteLine("Element added to the table");
                        break;

                    case 2:
                        program.RemoveByKey();
                        break;

                    case 3:
                        program.UpdateToHashTable();
                        break;

                    case 4:
                        program.AccessData();
                        break;

                    case 5:
                        program.CountData();
                        break;

                    case 6:
                        program.ClearData();
                        break;

                    case 7:
                        program.CloneData();
                        break;

                    case 8:
                        program.MiscellaneousData();
                        break;

                    case 9:
                        program.ContainsKey();
                        break;

                    case 10:
                        program.ContainsValue();
                        break;
                }

            } while (choice !=0);


        }

        private void ContainsValue()
        {
            Console.WriteLine("Enter Value : ");
            var valC = Console.ReadLine();
            if (ht.ContainsValue(valC))
                Console.WriteLine("Table is having specified value");
            else
                Console.WriteLine("Table is not having specified value");
        }

        private void ContainsKey()
        {
            Console.WriteLine("Enter Key : ");
            var keyC = Console.ReadLine();
            if (ht.ContainsKey(keyC))
                Console.WriteLine("Table is having specified key");
            else
                Console.WriteLine("Table is not having specified key");

        }

        private void MiscellaneousData()
        {
            Console.WriteLine("Is hashtable readonly? " + ht.IsReadOnly);
            Console.WriteLine("Is hashtable of fixed size? " + ht.IsFixedSize);
            Console.WriteLine("Is hashtable synchronized? " + ht.IsSynchronized);
            
        }

        private void CloneData()
        {
            Hashtable clonedHashtable = new Hashtable();
            clonedHashtable = (Hashtable)ht.Clone();
            //ht.Clone();
            Console.WriteLine("Clone is created");
            Console.WriteLine("Cloned data is :\n ");
            foreach (object keyA in clonedHashtable.Keys)
                Console.WriteLine(keyA + "       " + clonedHashtable[keyA] + "         Key HashCode: " + keyA.GetHashCode() + "         Value HashCode : " + clonedHashtable[keyA].GetHashCode() + " Datatype of key : " + clonedHashtable[keyA].GetType());

        }

        private void ClearData()
        {
            ht.Clear();
            Console.WriteLine("All data cleared");
        }

        private void CountData()
        {
            Console.WriteLine("Total count is : " + ht.Count);
        }

        private void UpdateToHashTable()
        {
            Console.WriteLine("Enter the key whose data you want to update : ");
            var keyU = Console.ReadLine();
            Console.WriteLine("Enter the value which you want to update : ");
            var valU = Console.ReadLine();
            // Hashtable[keyU] = valU;
            //ht.Remove(keyU);
            //ht.Add(keyU, valU);
            ht[keyU] = valU;
            Console.WriteLine("Value got updated");
        }

        private void RemoveByKey()
        {
            Console.WriteLine("Enter Key : ");
            var keyR = Console.ReadLine();
            ht.Remove(keyR);
            Console.WriteLine("Element removed from the table");
        }

        private void AdditionToHashtable(string key, string value)
        {
            
            ht.Add(key, value);
           // AccessData();
           
        }

        private void AccessData()
        {
            foreach (object keyA in ht.Keys)
                Console.WriteLine(keyA + "       " + ht[keyA] + "         Key HashCode: " + keyA.GetHashCode() + "         Value HashCode : " + ht[keyA].GetHashCode() + " Datatype of key : " + ht[keyA].GetType());
            
        }

        private void InitializeHash()
        {
            //Initializing Hashtable
            ht.Add("Name", "Tejas");
            ht.Add("EID", 1001);
            ht.Add("JD", "TSE");
            ht.Add("Mob", 8007952659);
            ht.Add("Company", "Company");
            ht.Add("Comp", "Company");
            ht.Add("GotDesk?", true);
            ht.Add("Email", "tejas.kulkarni@euromonitor.com");
        }
    }
}
