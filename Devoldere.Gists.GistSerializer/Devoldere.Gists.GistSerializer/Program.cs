using System;
using System.Collections.Generic;
using MDevoldere.Tools.Serializer;
using MDevoldere.Tools.GenericModels;

namespace Devoldere.Gists.GistSerializer
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            
            List<Person> myList = new List<Person>();

            Person person1 = new Person(1, "Name1");
            Person person2 = new Person(2, "Name2");

            myList.Add(person1);
            myList.Add(person2);

            Console.WriteLine("MyList:");

            foreach (Person p in myList)
            {
                Console.WriteLine(p.Id + ": " + p.Name);
            }

            AppDataManager<Person> manager = new AppDataManager<Person>("person_list", myList);

            Console.WriteLine(manager.BinPath);
            Console.WriteLine(manager.XmlPath);


            Person person3 = new Person(3, "Name3");

            manager.Items.Add(person3);

            manager.Save();

            manager.SaveXml();

            List<Person> loadedList = manager.Load();

            List<Person> loadedListXML = manager.LoadXml();

            Console.WriteLine("LoadedList:");

            foreach (Person p in loadedList)
            {
                Console.WriteLine(p.Id + ": " + p.Name);
            }

            Console.WriteLine("LoadedListXML:");

            foreach (Person p in loadedListXML)
            {
                Console.WriteLine(p.Id + ": " + p.Name);
            }

            Console.ReadLine();

        }
    }
}