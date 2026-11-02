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

            Dictionary<int,string> leaderboard = new Dictionary<int,string>();
            leaderboard.Add(500, "Ahmed");
            leaderboard.Add(200, "Sara");
            leaderboard.Add(800, "Ali");
            leaderboard.Add(350, "Mona");
            // Sort by score (Key) and print
            foreach (var player in leaderboard.OrderBy(p => p.Key))
            {
                Console.WriteLine($"Score: {player.Key}, Player: {player.Value}");
            }
            Console.WriteLine($"First player: {leaderboard.First().Value} , Score: {leaderboard.First().Key}");//Accessing the first player and score
            foreach (var player in leaderboard)
            {
                if(player.Key==500)
                    Console.WriteLine($"Player with score 500: {player.Value} Exists");//Accessing the player with score 500
            }
            leaderboard.TryGetValue(900, out string playerWithScore900);
            if (playerWithScore900 != null)
            {
                Console.WriteLine($"Player with score 900: {playerWithScore900} Exists");
            }
            else
            {
                Console.WriteLine($"Player with score 900 Does not Exist");
            }
            leaderboard.Remove(200);//Removing the player with score 200
            foreach (var player in leaderboard.OrderBy(p => p.Key))
            {
                Console.WriteLine($"Score: {player.Key}, Player: {player.Value}");
            }

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
