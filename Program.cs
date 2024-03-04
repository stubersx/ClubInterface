using System.Runtime.InteropServices;

namespace ClubInterface
{
    interface IClub
    {
        //Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Methods
        public string Fullname();
    }

    internal class Program
    {
        class BrassBand : IClub
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Instrument {  get; set; }
            public int Grade { get; set; }
            public int Experience {  get; set; }

            public BrassBand()
            {
                Id = 0;
                FirstName = string.Empty;
                LastName = string.Empty;
                Instrument = string.Empty;
                Grade = 0;
                Experience = 0;
            }
            public BrassBand(int id, string firstName, string lastName, string instrument, int garde, int experience)
            {
                Id = id;
                FirstName = firstName;
                LastName = lastName;
                Instrument = instrument;
                Grade = garde;
                Experience = experience;
            }

            public string Fullname()
            {
                return $"{FirstName} {LastName}";
            }
            public string Information()
            {
                return $"{Instrument} Player\n{Grade}th Grade\n{FirstName} has {Experience} years of experience.";
            }
        }

        static void Main(string[] args)
        {
            BrassBand bMember = new BrassBand();
            bMember.Id = 1;
            bMember.FirstName = "Ellie";
            bMember.LastName = "Brown";
            bMember.Instrument = "French Horn";
            bMember.Grade = 9;
            bMember.Experience = 3;

            Console.WriteLine($"{bMember.Fullname()}");
            Console.WriteLine($"{bMember.Information()}");
        }
    }
}
