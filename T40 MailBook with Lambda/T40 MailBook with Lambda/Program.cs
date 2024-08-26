using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T40_MailBook_with_Lambda
{
    class Friend
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }

    class MailBook
    {
        private readonly List<Friend> _friends;

        public IReadOnlyList<Friend> Friends => _friends;

        public MailBook()
        {
            _friends = new List<Friend>();
            LoadFriendsFromFile("friends.csv");
        }

        private void LoadFriendsFromFile(string fileName)
        {
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 2)
                        {
                            _friends.Add(new Friend { Name = parts[0], Email = parts[1] });
                        }
                    }
                }
                Console.WriteLine("Friends loaded successfully. Total friends: " + _friends.Count);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found: " + fileName);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error reading file: " + ex.Message);
            }
        }

        public void ShowAllFriends()
        {
            Console.WriteLine("All Friends:");
            foreach (var friend in _friends)
            {
                Console.WriteLine($"Name: {friend.Name}, Email: {friend.Email}");
            }
        }

        public List<Friend> SearchFriends(string searchTerm)
        {
            return _friends.Where(friend => friend.Name.Contains(searchTerm)).ToList();
        }

        public void AddFriend(string name, string email)
        {
            _friends.Add(new Friend { Name = name, Email = email });
            try
            {
                using (StreamWriter sw = new StreamWriter("friends.csv", true))
                {
                    sw.WriteLine($"{name},{email}");
                }
                Console.WriteLine("Friend added successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error writing to file: " + ex.Message);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MailBook mailBook = new MailBook();

            Console.WriteLine("1. Show all friends");
            Console.WriteLine("2. Search friends");
            Console.WriteLine("3. Add new friend");
            Console.WriteLine("4. Exit");

            while (true)
            {
                Console.Write("Choose an option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        mailBook.ShowAllFriends();
                        break;
                    case "2":
                        Console.Write("Enter search term: ");
                        string searchTerm = Console.ReadLine();
                        List<Friend> searchResults = mailBook.SearchFriends(searchTerm);
                        if (searchResults.Count == 0)
                        {
                            Console.WriteLine("No matching friends found.");
                        }
                        else
                        {
                            Console.WriteLine("Matching Friends:");
                            foreach (var friend in searchResults)
                            {
                                Console.WriteLine($"Name: {friend.Name}, Email: {friend.Email}");
                            }
                        }
                        break;
                    case "3":
                        Console.Write("Enter friend's name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter friend's email: ");
                        string email = Console.ReadLine();
                        mailBook.AddFriend(name, email);
                        break;
                    case "4":
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please choose again.");
                        break;
                }
            }
        }
    }
}
