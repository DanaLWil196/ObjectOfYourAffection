using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOfYourAffection
{
    class Profile
    {
        string name;
        int age;
        string adopted;
        string pronouns;
        string[] hobbies;

        public Profile(string name, int age, string adopted, string pronouns = "they/them")
        {
            this.name = name;
            this.age = age;
            this.adopted = adopted;
            this.pronouns = pronouns;
            this.hobbies = new string[0];
        }

        public string ViewProfile()
        {
            string bio = $"Name: {name}\nAge: {age}\nAdopted: {adopted}\nPronouns: {pronouns}";

            if (this.hobbies.Length > 0)
            {
                bio += "\nHobbies:\n";
                foreach (string hobby in hobbies)
                {
                    bio += $"- {hobby}\n";
                }
            }
            return bio;
        }
        public void SetHobbies(string[]hobbies)
        {
            this.hobbies = hobbies;
        }
    }
}
