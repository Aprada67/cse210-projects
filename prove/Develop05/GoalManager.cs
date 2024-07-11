using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.IO; 

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    // Constructor
    public GoalManager(List<Goal> goals, int score)
    {
        _goals = goals ?? new List<Goal>();
        _score = score;
    }

    public GoalManager() : this(new List<Goal>(), 0)
    {

    }

    // Functionality
    public void Start()
    {
        List<string> menu = new List<string>
        {
            "Menu Options:",
            "  1. Create New Goal",
            "  2. List Goals",
            "  3. Save Goals",
            "  4. Load Goals",
            "  5. Record Event",
            "  6. Quit"
        };

        Console.Clear();

        int selection = 0;

        while (selection != 6)
        {
            DisplayPlayerInfo();

            foreach (string m in menu)
            {
                Console.WriteLine(m);
            }
            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();

            try 
            {
                selection = int.Parse(input);

                if (selection < 1 || selection > 6)
                {
                    Console.WriteLine("Invalid selection. Please enter a number between 1 and 4.");
                    Console.WriteLine("Press any key to try again...");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                switch(selection)
                {
                    case 1:
                    ListGoalNames();
                    break;

                    case 2:
                    ListGoalDetails();
                    break;

                    case 3:
                    SaveGoals();
                    break;

                    case 4:
                    LoadGoals();
                    break;

                    case 5:
                    RecordEvent();
                    break;

                    case 6:
                    Console.WriteLine("Good bye!!\n");
                    break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.WriteLine("Press any key to try again...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.\n");
    }

    public void ListGoalNames()
    {
        int selection = 0;

        List<string> subMenu = new List<string>
        {
            "The type of goals are:",
            "  1. Simple Goal",
            "  2. Eternal Goal",
            "  3. Checklist Goal"
        };

        while (selection < 1 || selection > 3)
        {
            foreach (string sM in subMenu)
            {
                Console.WriteLine(sM);
            }
            Console.WriteLine("What kind of Goal would you like to create?: ");
            string input = Console.ReadLine();

            try
            {
                selection = int.Parse(input);

                if (selection < 1 || selection > 3)
                {
                    Console.WriteLine("Invalid selection. Please enter a number between 1 and 4.");
                    Console.WriteLine("Press any key to try again...");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                CreateGoal(selection);    
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.WriteLine("Press any key to try again...");
                Console.ReadKey();
            }
        }
        Console.WriteLine();
    }

    public void ListGoalDetails()
    {
        if (_goals == null || _goals.Count == 0)
        {
            Console.WriteLine("No goals available");
        }
        else
        {
            foreach (Goal element in _goals)
            {
                Console.WriteLine(element.GetDetailString());
            }
        }
    }

    public void CreateGoal(int goalType)
    {
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();

        Console.Write("What is the ammount of points associed with this goal? ");
        string goalPoints = Console.ReadLine();

        Goal newGoal = null;

        switch (goalType)
        {
            case 1:
                newGoal = new SimpleGoal(goalName, goalDescription, goalPoints, false);
                break;
            case 2:
                newGoal = new EternalGoal(goalName, goalDescription, goalPoints);
                break;
            case 3:
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());

                newGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, 0, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid goal type selected.");
                return;
        }

        _goals.Add(newGoal);
    }

    public void RecordEvent()
    {
        for (int i = 0; i < _goals.Count(); i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }

        Console.WriteLine("What goal did you accomplish? ");
        string input = Console.ReadLine();

        try
        {
            int selection = int.Parse(input);
            _goals[selection -1].RecordEvent(this);
            Console.WriteLine("Event recorded successfully.");

            CheckAllGoalsCompelte();
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    public void SaveGoals()
    {
        Console.WriteLine("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        try
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                // Escribe el puntaje en la primera línea del archivo
                outputFile.WriteLine(_score);

                // Escribe los detalles de cada objetivo en el archivo
                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.GetStringRepresentation());
                }

                Console.WriteLine($"Goals and score saved to {filename}.");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred while writing to the file: {e.Message}");
        }
    }

    public void LoadGoals()
    {
        Console.WriteLine("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        try
        {
            string[] lines = System.IO.File.ReadAllLines(filename);

            if (lines.Length > 0)
            {
                _score = int.Parse(lines[0]);
            }

            // Clear the objects list before load new objects
            _goals.Clear();

            for (int i = 1; i < lines.Length; ++i)
            {
                string line = lines[i].Trim();
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] parts = line.Split(",");

                string type = parts[0].Trim();
                string shortName = parts[1].Trim();
                string description = parts[2].Trim();
                string points = parts[3].Trim();

                // Create the object depending the type of
                // goal and add to the list of objects
                switch (type)
                {
                    case "Simple Goal:":
                        bool isComplete = bool.Parse(parts[4].Trim());
                        _goals.Add(new SimpleGoal(shortName, description, points, isComplete));
                        break;

                    case "Eternal Goal:":
                        _goals.Add(new EternalGoal(shortName, description, points));
                        break;

                    case "Checklist Goal:":
                        int ammountCompleted = int.Parse(parts[4].Trim());
                        int target = int.Parse(parts[5].Trim());
                        int bonus = int.Parse(parts[6].Trim());
                        _goals.Add(new ChecklistGoal(shortName, description, points, ammountCompleted, target, bonus));
                        break;

                    default:
                        Console.WriteLine($"Unknown goal type: {type}");
                        break;
                }
            }
            Console.WriteLine("Goals loaded successfully.");
            CheckAllGoalsCompelte();
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred while loading the file: {e.Message}");
        }
    }

    public void UpdateScore(int points)
    {
        _score += points;
    }

    public void CheckAllGoalsCompelte()
    {
        bool allComplete = _goals
            .Where(goal => !(goal is EternalGoal))
            .All(goal => goal.IsComplete());

        if (allComplete)
        {
            Console.WriteLine("\nCongratulations! All goals are complete!");
            Console.WriteLine("Continue working on your Eternal Goals...\n");
        }
    }
}