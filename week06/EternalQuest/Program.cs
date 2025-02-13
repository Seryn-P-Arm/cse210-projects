// Added visual designing to make it look nicer
// Added automatic loading at the start of the program
// Added automatic saving of goals when selecting "Exit"

using System;

class Program
{
    static void Main(string[] args)
    {
        // Run start and the rest of the program in GoalManager
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}