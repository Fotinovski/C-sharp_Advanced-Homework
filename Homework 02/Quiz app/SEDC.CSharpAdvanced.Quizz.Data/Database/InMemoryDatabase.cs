using SEDC.CSharpAdvanced.Quizz.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdvanced.Quizz.Data.Database
{
   public class InMemoryDatabase
    {
        public List<User> Users { get; set; }

        public InMemoryDatabase()
        {
            InitDatabase();
        }
        public void InitDatabase()
        {

          
            Users = new List<User>
            {
                new User("Pero Perovski","pero","123",false),
                new User("Darko Fotinovski","fote","123",false),
                new User("Stojan Stojkovski","stoj4e","123",false),
                new User("Karanfil Kokovski","kara","123",false),
                new User("Dragan Drazhan","dra6ko","123",false),
                new User("Zoran BratMuNa","goran","123",true),
                new User("Goran BratMuNa","zoran","123",true)

            };

        }



    }
}
