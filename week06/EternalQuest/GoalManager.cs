using System.IO; 

public  class GoalManager
{
    private List<Goal>_goals = new ();

    private int _score = 0 ;

    public GoalManager()
    {
        
    }

    public void Start()
    {
        Console.WriteLine("******GOAL TRACKER*****");
        while(true)
        {
          Console.WriteLine("");
          Console.WriteLine($"You have {_score} points");
          Console.WriteLine("Menu Options:");
          Console.WriteLine("   1.Create a New Goal");
          Console.WriteLine("   2.List Goals");
          Console.WriteLine("   3.Save Goals");
          Console.WriteLine("   4.Load Goals");
          Console.WriteLine("   5.Save Goals");  
          Console.WriteLine("   6.Quit");


          Console.WriteLine("Select a Choice from the menu: ");

          string optionChosen = Console.ReadLine();  
         
          
          if (optionChosen == "1")
            {
                CreateGoal();

            }
         
                
            
          else if (optionChosen == "2")
            {
               ListGoalNames();
            
            }
          else if (optionChosen == "3")
            {
              SaveGoals();
            }

             else if (optionChosen == "4")
            {
             Console.WriteLine("You chose option 4");
            }

             else if (optionChosen == "5")
            {
             Console.WriteLine("You chose option 5");
            }


        
           else if (optionChosen == "6")
            {
            Console.WriteLine("Thanks for coming!");    
            break;
            }
          

        }
    }

    public void DisplayPlayerInfo()
    {
        
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are: ");
        int goalNumber = 1;
        foreach (Goal goal in _goals)
        {
            
            string goalDetails = goal.GetDetailsString();
            Console.WriteLine($"{goalNumber}{goalDetails}");
            goalNumber++; 
        }
  

    }

    public void CreateGoal()
    {
        bool keepOnMenu = true;
        while(keepOnMenu) {
            Console.WriteLine("");
            Console.WriteLine("Select a choice from the menu: ");
            Console.WriteLine("The types of Goals are:  ");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal ");
            Console.WriteLine("3. Checklist Goal ");

            try
        {
                    
            Console.Write("Which type of goal would you like to create? ");

            string submenuOption = Console.ReadLine();
            int optionInt = int.Parse(submenuOption);

            switch (optionInt)
                {
                    case 1:
                      Console.Write("What is the name of your Goal? ");
                      string simpleGoalName = Console.ReadLine();
                      Console.Write("What is a short description of it? ");
                      string simpleGoalDescription = Console.ReadLine();
                      Console.Write("What is the amount of points associated with this Goal? ");
                      string simpleGoalPointsString = Console.ReadLine();
                      int simpleGoalPoints = int.Parse(simpleGoalPointsString);
                      SimpleGoal simpleGoal = new(simpleGoalName,simpleGoalDescription,simpleGoalPoints);
                      _goals.Add(simpleGoal);
                      keepOnMenu = false;  

                      


                    break; 
                    case 2:
                    Console.Write("What is the name of your Goal? ");
                    string eternalGoalName = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string  eternalGoalDescription = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this Goal? ");
                    string eternalGoalPointsString = Console.ReadLine();
                    int eternalGoalPoints = int.Parse(eternalGoalPointsString);
                    EternalGoal eternalGoal = new(eternalGoalName,eternalGoalDescription,eternalGoalPoints);
                    _goals.Add(eternalGoal);
                    keepOnMenu = false;  

                    break;
                    case 3:
                    Console.Write("What is the name of your Goal? ");
                    string checkListGoalName = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string  checkListGoalDescription = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this Goal? ");
                    string checkListGoalPointsString = Console.ReadLine();
                    int checkListGoalPoints = int.Parse(checkListGoalPointsString);
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    string targetGoalString = Console.ReadLine();
                    int targetGoal = int.Parse(targetGoalString);
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    string bonusGoalString = Console.ReadLine();
                    int bonusGoal = int.Parse(bonusGoalString);
    

                    CheckListGoal checkListGoal = new(checkListGoalName,checkListGoalDescription,checkListGoalPoints,0,targetGoal,bonusGoal);
                    _goals.Add(checkListGoal);
                    
                    keepOnMenu = false;  
                    break;

                    default:
                    
                    Console.WriteLine("Please enter a valid value");
                    break;


              

          
      
               }
        }  
               catch (FormatException)
        {
            Console.WriteLine("Please enter a valid value");
        }
        }
    }

    public void SaveGoals()
    {
        Console.WriteLine("What is the name of the file? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
             foreach (Goal goal in _goals)
            {
               string goalDetails =  goal.GetStringRepresentation() ;
               outputFile.WriteLine($"****{goalDetails}****");

            }
             
          

    
        }
    }
    
    public void LoadGoals()
    {
        
        
    }
}