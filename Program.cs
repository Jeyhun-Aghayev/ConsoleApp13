namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("ceyhun", "agayev");
            Human human1 = new Human("narmin", "sivexanova");
            Human human2 = new Human("asad", "asadov");
            try
            {
                human.Age = 0;            
            }
            catch (AgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                human1.Age = 80;
            }
            catch (AgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                human2.Age = 60;
            }
            catch (AgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Human[] humans = {human,human1,human2};
            foreach (var item in humans)
            {
                Console.WriteLine($"Name: {item.Name}  Surname:{item.Surname}  Age:{item.Age}");
            }

                
            bool check = true;
            while (check)
            {
                Console.WriteLine("Please enter name:");
                string Name = Console.ReadLine();

                try
                {

                    foreach (Human item in humans)
                    {
                        if (item.Name == Name)
                        {
                            check = false;
                            Console.WriteLine($"Name: {item.Name}  Surname:{item.Surname}  Age:{item.Age}");
                        }
                    }
                    if (check)
                    {
                        throw new DataNotFoundException("Not found");
                    }


                }
                catch (DataNotFoundException EX)
                {

                    Console.WriteLine(EX.Message);
                    
                }
            }
        
            
        }
    }
}