using ConsoleApp1.Interface;

namespace ConsoleApp1.Models
{
    internal class Student : ICodeAcademy
    {
        static int Count = 1;
        public int Id;
        string _name;
        string _surname;
        public string CodeEmail { get; set; }
        public string Name
        {
            get { return _name; } 
            set
            {
                if (CheckName(value)) 
                {
                    _name = value;
                }
                else { Console.WriteLine("ad uygun deyil"); }
               
            }
        }
        public string Surname 
        {
            get { return _surname; }
            set
            {
                if (CheckName(value))
                {
                    _surname = value;
                }
                else { Console.WriteLine("soy ad duzgun deyil"); }
            }
        }

        

        public Student(string name, string surname)
        {
            Name =Capitalize( name);
            Surname =Capitalize( surname);
            Id = Count++;
            GenerateEmail();
        }


        public static bool IsLetter(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (!char.IsLetter(name[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public static string Capitalize(string name)
        { return name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower(); }
        public static bool length(string name)
        {
            if (name.Length >= 3 && name.Length <= 10)
            {
                return true;
            }
            else return false;

        }
        public static bool CheckName(string name)
        {
            if (IsLetter(name) && length(name))
            { return true; }
            else
            { return false; }

        }

        public void GenerateEmail()
        {
            string email = $"{_name.ToLower()}.{_surname.ToLower()}{Id}@code.edu.az";
            CodeEmail = email;
        }
    }
}

