using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TevinHamilton_Final
{
    class Application
    {
        Dictionary<string, List<Movie>> _movieCollection = new Dictionary<string, List<Movie>>();
        Menu _menu;
        decimal _total;
        private Movie _currentMovie;
        private string _directory = @"..\..\output\";
        private string _fileName = @"Movies.txt";

        public Application()
        {
            _menu = new Menu("Add Movie","Remove Movie","Display movie","Save to JSON","Exit");
            _menu.Title = "FINAL";
            Directory.CreateDirectory(_directory);
            if (!File.Exists(_directory + _fileName))
            {
                File.Create(_directory + _fileName);
                Console.WriteLine("txt file Movies created");
            }
            else
            {
                Console.WriteLine("File exist");
                FileIoLoad();
            }
            
            Display();
        }
        private void Display()
        {
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
            Console.Clear();
            _menu.Display();
            SelectOption();
        }
        private void SelectOption()
        {
            switch (Utility.IntValidate("\nPlease make a selection"))
            {
                case 1:
                    AddMovie();
                    break;
                case 2:
                    RemoveMovie();
                    break;
                case 3:
                    DisplayMovie();
                    break;
                case 4:
                    SaveJson();
                    break;
                case 5:
                    Exit();
                    break;
                default:
                    SelectOption();
                    break;
            }
        }
        private void AddMovie()
        {
            Console.Clear();
            int counter = 1;
            foreach (KeyValuePair<string , List<Movie>> item in _movieCollection)
            {
                Console.WriteLine($"[{counter}] {item.Key}");
            }
            string movieChoice = Utility.StringValidate("Please enter the movie genre you will like to add to type the name in below");
            if (_movieCollection.ContainsKey(movieChoice))
            {
                string titel = Utility.StringValidate("please enter the titel of the movie");
                string director = Utility.StringValidate("please enter the director name");
                decimal cost = Utility.DecimalValidate("please enter the cost of the movie");
                Movie movie = new Movie(titel,director,cost);
                _movieCollection[movieChoice].Add(movie);
                Display();
            }
            else
            {
                Console.WriteLine("Movie genre does not exist Try again\r\nMAKE SURE YOU ENTER THE CORRECT FORMAT");
                Display();
            }
        }
        private void RemoveMovie()
        {
            Console.Clear();
            int counter = 1;
            foreach (KeyValuePair<string , List<Movie>> item in _movieCollection)
            {
                Console.WriteLine($"{counter} {item.Key}");
                counter++;
            }
            string movieChoice = Utility.StringValidate("Please enter the movie genre you will like to add to type the name in below");
            
            if (_movieCollection.ContainsKey(movieChoice))
            {
                counter = 1;
                foreach (var item in _movieCollection[movieChoice])
                {
                    Console.WriteLine($"[{counter}]{item.Titel}");
                    counter++;
                }
                int removeTitel = Utility.IntValidate("please enter the number of the movie you like to remove");
                if (removeTitel > _movieCollection[movieChoice].Count || removeTitel < 1)
                {
                    Console.WriteLine("thats incorrect");
                    Display();
                }
                else
                {
                    _movieCollection[movieChoice].RemoveAt(removeTitel-1);
                    Display();
                }
                Console.WriteLine("remember to enter the title in the same format above");
            }
            else
            {
                Console.WriteLine("Movie genre does not exist Try again\r\nMAKE SURE YOU ENTER THE CORRECT FORMAT");
                Display();
            }

        }
        private void DisplayMovie()
        {
            
            foreach (KeyValuePair<string , List<Movie>> item in _movieCollection)
            {
                Console.WriteLine(item.Key);
                foreach (Movie val in _movieCollection[item.Key])
                {
                    Console.WriteLine(val.ToString());
                    decimal _total =+ val.Cost;
                    
                }
            }
            Console.WriteLine(_total);
            Display();
        }
        private void SaveJson()
        {
            Console.Clear();
            Console.WriteLine("saving Employees to Json");
            using (StreamWriter sw = new StreamWriter(_directory + "Employees.json"))
            {
                sw.WriteLine("[");
                int index = 0;
                int count = _movieCollection["Action"].Count() + _movieCollection["Fanstasy"].Count();
                foreach (KeyValuePair<string , List<Movie>> item in _movieCollection)
                {
                    foreach (var val in _movieCollection[item.Key])
                    {
                        sw.WriteLine("{");
                        sw.WriteLine($"\"titel\": \"{val.Titel}\",");
                        sw.WriteLine($"\"director\": \"{val.Director}\",");
                        sw.WriteLine($"\"Cost\": \"{val.Cost}\",");
                        sw.WriteLine($"\"genre\": \"{item.Key}\"");
                        if (index == count-1)
                        {
                            sw.WriteLine("}");
                        }
                        else
                        {
                            sw.WriteLine("},");
                        }
                        index++;
                       
                    }
                }
                sw.WriteLine("]");
                
            }
        }
        private void Exit()
        {

        }
        private void FileIoLoad()
        {
            using(StreamReader inputStream = new StreamReader(_directory + _fileName))
            {
                string movieTitel = inputStream.ReadLine();
                inputStream.ReadLine();
                string fan= inputStream.ReadLine();
                
                _movieCollection.Add("Fanstasy", new List<Movie>());
                string line;
                string[] textInfo;
                while ((line = inputStream.ReadLine()) != "")
                {
                    textInfo = line.Split(',');
                    decimal cost;
                    decimal.TryParse(textInfo[2], out cost);
                    Movie movie = new Movie(textInfo[0], textInfo[1], cost);
                    _movieCollection["Fanstasy"].Add(movie);
                }
                string act = inputStream.ReadLine();
                _movieCollection.Add("Action", new List<Movie>());              
                while ((line = inputStream.ReadLine()) != null)
                {
                    textInfo = line.Split(',');
                    decimal cost;
                    decimal.TryParse(textInfo[2], out cost);
                    Movie movie = new Movie(textInfo[0], textInfo[1], cost);
                    _movieCollection["Action"].Add(movie);
                }
            }
        }
        private void FileIoSave()
        {

        }
        
    }
}
