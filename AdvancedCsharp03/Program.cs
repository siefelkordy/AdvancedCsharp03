namespace AdvancedCsharp03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise1
            //List<int> Grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };
            //foreach (int grade in Grades)
            //{
            //    Console.Write($"{grade} ");
            //}
            //Console.WriteLine(Grades.Count);// Accessing the count of elements in the list
            //Console.WriteLine(Grades.Capacity);// Getting the capacity of the list
            //Console.WriteLine(Grades[0]);// Accessing the first element
            //Console.WriteLine(Grades[^1]);// Accessing the last element using index from end operator
            //Grades.Sort();// Sorting the list in ascending order
            //foreach (int grade in Grades)
            //{
            //    Console.Write($"{grade} ");// Displaying the sorted list
            //}
            //foreach (int grade in Grades)
            //{
            //    if (grade >= 90)
            //    {
            //        Console.WriteLine(grade);// Displaying first grade that are 90 or above
            //        break;
            //    }
            //    else
            //        continue;
            //}
            //foreach (int grade in Grades)
            //{
            //    if (grade <= 75)
            //     Console.WriteLine(grade);// Displaying first grade that are 75 or below
            //    else
            //        continue;
            //}
            //foreach (int grade in Grades)
            //{
            //    if (grade == 100)
            //        Console.WriteLine(grade);// Displaying first grade that are 100
            //    else
            //    {
            //        continue;
            //    }
            //}
            //List<string> grades = new List<string>(Grades.Capacity);
            //grades= Grades.ConvertAll<string>(x => x.ToString());// Converting the list of integers to a list of strings
            #endregion

            #region Exercise2

            //Dictionary<int,string> leaderboard = new Dictionary<int,string>();
            //leaderboard.Add(500, "Ahmed");
            //leaderboard.Add(200, "Sara");
            //leaderboard.Add(800, "Ali");
            //leaderboard.Add(350, "Mona");
            //// Sort by score (Key) and print
            //foreach (var player in leaderboard.OrderBy(p => p.Key))
            //{
            //    Console.WriteLine($"Score: {player.Key}, Player: {player.Value}");
            //}
            //Console.WriteLine($"First player: {leaderboard.First().Value} , Score: {leaderboard.First().Key}");//Accessing the first player and score
            //foreach (var player in leaderboard)
            //{
            //    if(player.Key==500)
            //        Console.WriteLine($"Player with score 500: {player.Value} Exists");//Accessing the player with score 500
            //}
            //leaderboard.TryGetValue(900, out string playerWithScore900);
            //if (playerWithScore900 != null)
            //{
            //    Console.WriteLine($"Player with score 900: {playerWithScore900} Exists");
            //}
            //else
            //{
            //    Console.WriteLine($"Player with score 900 Does not Exist");
            //}
            //leaderboard.Remove(200);//Removing the player with score 200
            //foreach (var player in leaderboard.OrderBy(p => p.Key))
            //{
            //    Console.WriteLine($"Score: {player.Key}, Player: {player.Value}");
            //}

            #endregion

            #region Exercise3
            // Dictionary<string, int> Contact = new Dictionary<string, int>();
            // Contact["Ahmed"] = 123456789;
            // Contact["Sara"] = 987654321;
            // Contact["Mohamed"] = 456789123;
            //// Contact.Add("Ahmed", 987654321);//This will throw an exception as the key already exists
            // Contact.TryAdd("Ahmed", 987654321);//This will not throw an exception and will return false as the key already exists
            // Console.WriteLine(Contact.TryGetValue("sara", out int phoneNumber));
            // if(phoneNumber != 0)
            // {
            //     Console.WriteLine($"Phone number of sara: {phoneNumber}");
            // }
            // else
            // {
            //     Console.WriteLine($"Not Found");
            // }
            // foreach(var contact in Contact)
            // {
            //     Console.Write($"Name: {contact.Key},");

            // }
            // foreach (var contact in Contact)
            // {
            //     Console.WriteLine($"Phone Number: {contact.Value}");
            // }

            #endregion

            #region Exercise 4

            //// 1. Unique Email Validator
            //HashSet<string> emails = new HashSet<string>(
            //    StringComparer.OrdinalIgnoreCase
            //);

            //emails.Add("ahmed@test.com");
            //emails.Add("AHMED@test.com");
            //emails.Add("sara@test.com");
            //emails.Add("Sara@Test.Com");

            //// 2. Print email count
            //Console.WriteLine("Email Count: " + emails.Count);

            //foreach (var email in emails)
            //{
            //    Console.WriteLine(email);
            //}

            //// 3. Create Set A and Set B
            //HashSet<int> SetA = new HashSet<int> { 1, 2, 3, 4, 5 };
            //HashSet<int> SetB = new HashSet<int> { 4, 5, 6, 7, 8 };

            //// 4. UnionWith
            //HashSet<int> UnionSet = new HashSet<int>(SetA);
            //UnionSet.UnionWith(SetB);

            //Console.WriteLine("\nUnion:");
            //foreach (var item in UnionSet)
            //{
            //    Console.Write(item + " ");
            //}

            //// 5. IntersectWith
            //HashSet<int> IntersectSet = new HashSet<int>(SetA);
            //IntersectSet.IntersectWith(SetB);

            //Console.WriteLine("\n\nIntersection:");
            //foreach (var item in IntersectSet)
            //{
            //    Console.Write(item + " ");
            //}

            //// 6. ExceptWith
            //HashSet<int> ExceptSet = new HashSet<int>(SetA);
            //ExceptSet.ExceptWith(SetB);

            //Console.WriteLine("\n\nExcept:");
            //foreach (var item in ExceptSet)
            //{
            //    Console.Write(item + " ");
            //}

            //// 7. IsSubsetOf
            //HashSet<int> SetC = new HashSet<int> { 1, 2 };

            //Console.WriteLine("\n\nIs {1, 2} a subset of SetA?");
            //Console.WriteLine(SetC.IsSubsetOf(SetA));




            #endregion

            #region Exercise5
            // 1. Create a Queue and enqueue 5 documents
            Queue<string> documents = new Queue<string>();

            documents.Enqueue("Report.pdf");
            documents.Enqueue("Invoice.pdf");
            documents.Enqueue("Letter.docx");
            documents.Enqueue("Resume.pdf");
            documents.Enqueue("Photo.jpg");

            // 2. Print queue contents and Count
            Console.WriteLine("Queue Contents:");

            foreach (var document in documents)
            {
                Console.WriteLine(document);
            }

            Console.WriteLine("Count: " + documents.Count);

            // 3. Peek at the next document
            Console.WriteLine("\nNext document: " + documents.Peek());

            // 4. Process the queue using Dequeue
            Console.WriteLine("\nProcessing Queue:");

            while (documents.Count > 0)
            {
                string document = documents.Dequeue();
                Console.WriteLine("Printing: " + document);
            }

            // 5. TryDequeue on an empty queue
            Console.WriteLine("\nTrying to dequeue from empty queue:");

            if (documents.TryDequeue(out string result))
            {
                Console.WriteLine("Printing: " + result);
            }
            else
            {
                Console.WriteLine("Queue is empty. No document to print.");
            }

            Console.WriteLine("Final Count: " + documents.Count);



            #endregion
            #region Exercise6
            //Stack<string> browserHistory = new Stack<string>();//Creating an empty stack with default initalizied capacity of zero
            ////Pushing 5 URLs into browser history
            //browserHistory.Push("google.com");
            //browserHistory.Push("github.com");
            //browserHistory.Push("stackoverflow.com");
            //browserHistory.Push("youtube.com");
            //browserHistory.Push("claude.ai");
            //Console.WriteLine(browserHistory.Peek());
            ////Pressing back 3 times using pop & printing the last page left
            //Console.WriteLine("Site left:" + browserHistory.Peek());
            //browserHistory.Pop();
            //Console.WriteLine("Site left:" + browserHistory.Peek());
            //browserHistory.Pop();
            //Console.WriteLine("Site left:" + browserHistory.Peek());
            //browserHistory.Pop();
            //Console.WriteLine("Current Page:" + browserHistory.Peek());
            //browserHistory.Pop();//popping github.com
            //browserHistory.Pop();//popping google.com
            //bool Ispopped = browserHistory.TryPop(out string poptry); ;
            //Console.WriteLine(poptry);//returns null as there is no top element when stack is empty
            //Console.WriteLine(Ispopped);//returns false as stack is empty
            #endregion
        }
    }
}

