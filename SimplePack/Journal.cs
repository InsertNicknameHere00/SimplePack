using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SimplePack
{
    internal class Journal : MainHub
    {
      List<string> options = new List<string>(){
            "1. Add Entry",
            "2. View Entries",
            "3. Delete Entry",
            "4. Edit Entry",
            "5. Go back to the main menu",
            "6. Save Entries to a file",
            "0. Exit"
        };

        List<string> entries = new List<string>();

        public void JournalEnterCheck()
        {
            Console.Clear();
            Console.WriteLine("If you want to enter: \n -> Give Y as answer;");
            Console.WriteLine();
            Console.WriteLine("If you want to go back to the main menu: \n -> Give N as answer;");
            string decisionentercheck = Console.ReadLine();

            if (decisionentercheck == "Y")
            {
                JournalDecision();
            }
            if (decisionentercheck == "y")
            {
                JournalDecision();
            }
            if (decisionentercheck == "N")
            {
                Console.Clear();
                StartHub();
            }
            if (decisionentercheck == "n")
            {
                Console.Clear();
                StartHub();
            }
        }

        public void JournalDecision()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("\r\n       _                              _ \r\n      | |                            | |\r\n      | | ___  _   _ _ __ _ __   __ _| |\r\n  _   | |/ _ \\| | | | '__| '_ \\ / _` | |\r\n | |__| | (_) | |_| | |  | | | | (_| | |\r\n  \\____/ \\___/ \\__,_|_|  |_| |_|\\__,_|_|\r\n                                        \r\n                                        \r\n");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            foreach (string option in options) {
                Console.WriteLine(option);
            }
Console.WriteLine();
            Console.WriteLine("What do you want to do?");
            int decision = int.Parse(Console.ReadLine());

            switch (decision)
            {
                case 1:
                    AddEntry();
                    break;

                case 2:
                    ViewEntries();
                    break;

                case 3:
                    DeleteEntry();
                    break;

                case 4:
                    EditEntry();
                    break;

                case 5:
                    StartHub();
                    break;

                case 6:
                    SaveEntriesToFile();
                    break;

                case 0:
                    LeaveApp();
                    break;

                default:
                    Console.WriteLine("Error!");
                    break;
            }
        }

        public void AddEntry()
        {
            Console.Clear();
            Console.WriteLine("Add Entry");
            Console.WriteLine("--------");
            Console.WriteLine();
            Console.WriteLine("Enter the title of the entry: ");
            string title = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter the content of the entry: ");
            string content = Console.ReadLine();
            Console.WriteLine();
            string entrytemp = title + "\n" + content + "\n";

            if(entries.Count == 0) {
                entries.Add("1. " + entrytemp);
            } else {
                entries.Add((entries.Count + 1) + ". " + entrytemp);
            }

            Console.WriteLine("Entry added successfully!");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            JournalDecision();
        }

        public void ViewEntries()
        {
            Console.Clear();
            Console.WriteLine("View Entries");
            Console.WriteLine("--------");
            Console.WriteLine();
            Console.WriteLine("Entries:");
            Console.WriteLine("--------");
            foreach (string entry in entries) {
                Console.WriteLine(entry);
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            JournalDecision();
        }

        public void DeleteEntry()
        {
            Console.Clear();
            Console.WriteLine("Delete Entry");
            Console.WriteLine("--------");
            Console.WriteLine();
            Console.WriteLine("Enter the number of the entry you want to delete: ");
            int entryNumber = int.Parse(Console.ReadLine());
            entries.RemoveAt(entryNumber - 1);
            Console.WriteLine();
            Console.WriteLine("Entry deleted successfully!");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            JournalDecision();
        }

        public void EditEntry() {
            Console.Clear();
            Console.WriteLine("Edit Entry");
            Console.WriteLine("--------");
            Console.WriteLine();
            Console.WriteLine("Enter the number of the entry you want to edit: ");
            int entryNumber = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Entry you are gonna edit:");
            Console.WriteLine(entries[entryNumber-1].ToString());
            Console.WriteLine();
            Console.WriteLine("Enter the new title of the entry: ");
            string title = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter the new content of the entry: ");
            string content = Console.ReadLine();
            Console.WriteLine();
            string entrytemp = title + "\n" + content + "\n";
            Console.WriteLine();
            entries[entryNumber - 1] = entryNumber + ". " + entrytemp;
            Console.WriteLine();
            Console.WriteLine("Entry edited successfully!");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            JournalDecision();
        }

        public void SaveEntriesToFile() {
            Console.Clear();
            Console.WriteLine("Save Entries to a file");
            Console.WriteLine("--------");
            Console.WriteLine();
            Console.Write("Enter the name of the text file you want to save the entries to: ");
            string fileName = Console.ReadLine();
            File.WriteAllLines(fileName+ ".txt", entries);
            Console.WriteLine();
            Console.WriteLine("Entries saved successfully!");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            JournalDecision();
        }
    }
}
