using System;

namespace OOPIntro_
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person x = new Person();
            p1.Firstname = "Ameli";
            p1.Lastname = "Davtyan";    
            Console.WriteLine(p1.Fullname());
           Console.WriteLine("You are talkative true or false?");           
                    
           x.talkative = Convert.ToBoolean(Console.ReadLine());
           Console.WriteLine(x.talkative);

        




        }
    }
}
class Person
{
    public string Firstname {get; set;}
    public string Lastname { get; set; }
          public string Fullname()
          {
              return $"{this.Firstname} {this.Lastname}";
           } 
    public bool talkative
        
    {
        set
        {
            if (value == true)
            {
                for(int i = 0; i < 3; i++)
                {
                  Console.Beep();
                }
                
            }
            else
            {
                for (int i = 0; i < 1; i++)
                Console.Beep();}

            }
            get 
            {
                return talkative;
            }
        }
    }
     