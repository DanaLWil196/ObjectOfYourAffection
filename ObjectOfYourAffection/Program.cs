using System;

namespace ObjectOfYourAffection
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile smokey = new Profile("Mountain Wood Smoke", 11, "yes", "he/him");
            smokey.SetHobbies(new string[]
            {
                "Napping on cold spots",
                "Dealing with my sisters",
                "Spending time with my family",
                "Trying to be active due to my old bones",
            });

            Console.WriteLine(smokey.ViewProfile());
        }

    }
}
