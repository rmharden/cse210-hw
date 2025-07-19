using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        int currentPoints = 0;
        string response = "";
        while (response != "6")
        {

            Console.WriteLine($"You have {currentPoints} points.\n");

            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Reocrd Even");
            Console.WriteLine(" 6. Quit");
            Console.WriteLine("What Would you like to do?");

            response = Console.ReadLine();


            if (response == "1")
            {

            }
            else if (response == "2")
            {

            }
            else if (response == "3")
            {

            }
            else if (response == "4")
            {

            }
            else if (response == "5")
            {

            }
            else if (response == "6")
            {

            }
            else
            {
                Console.WriteLine("\nInvalid number.");
            }

        }

    }
}

/*

This is what the program looks like when you first run it:

You have 0 points.

Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: // User input is on the same line here.

*/


/*

This is what the program looks like when you chose 1:
...
Select a choice from the menu: 1
The types of Goals are:
    1. Simple Goal
    2. Eternal Goal
    3. Checklist Goal
Which type of goal would you like to create? // User input is on the same line here.

*/

/*

This is if you chose 1 from the Goal menu:
...
Which type of goal would you like to create?  1
What is the name of the goal? Give a talk.  // The second sentance is what the user wrote.
What is a short description? Speak in Sacrament Meeting when asked.  // The second sentance is a user input.
What is the amount of points associated with this goal? 100 // The second sentance is a user input. 

*/

// Goes back to the Main Menu here.

/*

This is choosing 2:

You have 0 points.

Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: 2
The goals are:
1. [ ] Give a talk (Speak in Sacrament meeting when asked) // This is from a list.

*/

// Goes back to the Main Menu here.

/*

This is choosing 1, again:

You have 0 points.

Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: 1
The types of Goals are:
    1. Simple Goal
    2. Eternal Goal
    3. Checklist Goal
Which type of goal would you like to create? 2
What is the name of your goal? Study the scriptures
What is a short description of it? Study for at least 10 minutes
What is the amount of points associated with this goal? 50

You have 0 points.

Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: 2
The goals are:
1. [ ] Give a talk (Speak in Sacrament meeting when asked)
2. [ ] Study the scriptures (Study for at least 10 minutes)

You have 0 points.

Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: 1
The types of Goals are:
    1. Simple Goal
    2. Eternal Goal
    3. Checklist Goal
Which type of goal would you like to create? 3
What is the name of your goal? Attend the temple
What is a short description of it? Attend and perform and perform any ordiance
What is the amount of points associated with this goal? 50
How many times does this goal need to be accomplished for a bonus? 3
What is the bonus for accomplishing it that many times? 500

You have 0 points.

Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: 2
The goals are:
1. [ ] Give a talk (Speak in Sacrament meeting when asked)
2. [ ] Study the scriptures (Study for at least 10 minutes)
3. [ ] Attend the temple (Attend and perform and perform any ordiance) -- Currently completed: 0/3

You have 0 points.

Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: 3
What is the filename for the goal file? goals.txt


You have 0 points.

Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: 
*/

/*

This is what the txt file looks like:

goals.txt

0
SimpleGoalLGive a talk,Speak in Sacrament Meeting when aksed,100,False
EternalGoal:Study the scriptures,Study for at least 10 minutes,50
ChecklistGoal:Attend the temple,Attend and perform any ordinance,50,500,3,0

*/

// This won't work perfectly if someone put a comma in their response.

/*

This is choosing 6:

You have 0 points.

Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: 6

// Just ends. Back to the console.
*/

/*

Running it again:


You have 0 points.

Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: 2
The goals are:  // no goals if you choose 2 right away

You have 0 points.

Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: 4
What is the filename of the goal file? goals.txt

You have 0 points.

Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: 2
The goals are:
1. [ ] Give a talk (Speak in Sacrament meeting when asked)
2. [ ] Study the scriptures (Study for at least 10 minutes)
3. [ ] Attend the temple (Attend and perform and perform any ordiance) -- Currently completed: 0/3

You have 0 points.

Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: 5
The goals are:
1. Give a talk
2. Study the scriptures
3. Attend the temple.
Which goal did you accomplish? 2
Congratulations! You have earned 50 points!
You now have 50 points.

You have 50 points.

Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: 2
The goals are:
1. [ ] Give a talk (Speak in Sacrament meeting when asked)
2. [ ] Study the scriptures (Study for at least 10 minutes)  // This is an eternal goal, it's never really completed.
3. [ ] Attend the temple (Attend and perform and perform any ordiance) -- Currently completed: 0/3

You have 50 points.

Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: 5
The goals are:
1. Give a talk
2. Study the scriptures
3. Attend the temple.
Which goal did you accomplish? 1
Congratulations! You have earned 100 points!
You now have 150 points.

You have 150 points.

Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: 2
The goals are:
1. [X] Give a talk (Speak in Sacrament meeting when asked)
2. [ ] Study the scriptures (Study for at least 10 minutes)  // This is an eternal goal, it's never really completed.
3. [ ] Attend the temple (Attend and perform and perform any ordiance) -- Currently completed: 0/3

You have 150 points.

Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: 5
The goals are:
1. Give a talk
2. Study the scriptures
3. Attend the temple.  
Which goal did you accomplish? 2
Congratulations! You have earned 50 points!
You now have 200 points.

You have 200 points.

Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: 5
The goals are:
1. Give a talk
2. Study the scriptures
3. Attend the temple.  
Which goal did you accomplish? 3
Congratulations! You have earned 50 points!
You now have 250 points.

You have 250 points.

Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: 2
The goals are:
1. [X] Give a talk (Speak in Sacrament meeting when asked)
2. [ ] Study the scriptures (Study for at least 10 minutes)  // This is an eternal goal, it's never really completed.
3. [ ] Attend the temple (Attend and perform and perform any ordiance) -- Currently completed: 1/3

You have 250 points.

Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: 3
What is the filename for the goal file? goals.txt

You have 250 points.

Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: 

*/

/*
goals.txt
250
SimpleGoalLGive a talk,Speak in Sacrament Meeting when aksed,100,False
EternalGoal:Study the scriptures,Study for at least 10 minutes,50
ChecklistGoal:Attend the temple,Attend and perform any ordinance,50,500,3,1

// the points changed and the CheckListGoal has one of 3 complete.
*/

/*
Quiting and starting again:


You have 250 points.

Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: 6



You have 0 points.

Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: 4
What is the filename for the goal file? goals.txt

You have 250 points.

Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: 2
The goals are:
1. [X] Give a talk (Speak in Sacrament meeting when asked)
2. [ ] Study the scriptures (Study for at least 10 minutes)  // This is an eternal goal, it's never really completed.
3. [ ] Attend the temple (Attend and perform and perform any ordiance) -- Currently completed: 1/3

You have 250 points.

Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: 5
The goals are:
1. Give a talk
2. Study the scriptures
3. Attend the temple.  
Which goal did you accomplish? 3
Congratulations! You have earned 50 points!
You now have 300 points.

You have 300 points.

Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: 3
The goals are:
1. Give a talk
2. Study the scriptures
3. Attend the temple.  
Which goal did you accomplish? 3
Congratulations! You have earned 550 points! // This completes the goal and gives the user points plus the bonus.
You now have 850 points.

You have 850 points.

Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: 2
The goals are:
1. [X] Give a talk (Speak in Sacrament meeting when asked)
2. [ ] Study the scriptures (Study for at least 10 minutes)  // This is an eternal goal, it's never really completed.
3. [X] Attend the temple (Attend and perform and perform any ordiance) -- Currently completed: 3/3

You have 850 points.

Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: 1
The types of Goals are:
    1. Simple Goal
    2. Eternal Goal
    3. Checklist Goal
Which type of goal would you like to create? 3
What is the name of your goal? Wake up early
What is a short description of it? Wake up by at least 6:00am
How many times does this goal need to be accomplished for a bonus? 10
What is the bonus for accomplishig it that many times? 1000

You have 850 points.

Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: 2
The goals are:
1. [X] Give a talk (Speak in Sacrament meeting when asked)
2. [ ] Study the scriptures (Study for at least 10 minutes)  // This is an eternal goal, it's never really completed.
3. [X] Attend the temple (Attend and perform and perform any ordiance) -- Currently completed: 3/3
4. [ ] Wake up early (Wake up by at least 6:00am) -- Currently completed: 
/10

You have 850 points.

Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: 3
What is the filename for the goal file? goals.txt

You have 850 points.

Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: 
*/

/*
This is waht the ext file looks like now:

goals.txt

850
SimpleGoalLGive a talk,Speak in Sacrament Meeting when aksed,100,True
EternalGoal:Study the scriptures,Study for at least 10 minutes,50
ChecklistGoal:Attend the temple,Attend and perform any ordinance,50,500,3,3
ChecklistGoal:Wake up early,Wake up by at least 6:00am,10,1000,10,0
*/

/*

You have 850 points.

Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: 6
// ends program
*/


