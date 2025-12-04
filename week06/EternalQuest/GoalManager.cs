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
             Console.WriteLine("You chose option 2");
            
            }
          else if (optionChosen == "3")
            {
             Console.WriteLine("You chose option 3");
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
        
    }

    public void CreateGoal()
    {
         while(true)
          {
            Console.WriteLine("");
            Console.WriteLine("Select a choice from the menu: ");
            Console.WriteLine("The types of Goals are:  ");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal ");
            Console.WriteLine("3. Checklist Goal ");
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
                      
                        
                      


                    break; 
                    case 2:
                    Console.WriteLine("option 2");
                    break;
                    case 3:
                    Console.WriteLine("Option 3");
                    break;

                    default:
                    
                    Console.WriteLine("Please enter a valid value");
                    break;


                }

          
      
        }
        
    }

    public void SaveGoals()
    {
        
    }
    
    public void LoadGoals()
    {
        
        
    }
}