using System;

class Program
{
    static void Main(string[] args)
    {
        //instantiate objects
        List<Activity> myActivities = new List<Activity> ();

        myActivities.Add( new Listing());
        myActivities.Add( new Breathing());
        myActivities.Add( new Reflection());
        myActivities.Add( new BodyScan());
        Menu menu = new Menu(myActivities);
        menu.Run();

    }
}