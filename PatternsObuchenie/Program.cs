using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsObuchenie
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Adapter adapter = new Adapter();
            adapter.EbatBottasa();
            adapter.Loshara();
            Serialize_PIVO_tandem serialize_PIVO = new Serialize_PIVO_tandem();
            Adapter_kotoryi_Singleton adap_Sing = Adapter_kotoryi_Singleton.GetInstance2();
            adap_Sing.XMLReturn(serialize_PIVO);
            adap_Sing.JsonVozvrat(serialize_PIVO);
            RealLeader realOne = new RealLeader();
            ProxyCoLeader proxy = new ProxyCoLeader();
            Client client = new Client();
            client.zapros_piva(proxy);
            Console.WriteLine("\n");
            Console.WriteLine("Now it's leader time");
            client.zapros_piva(realOne);
            Console.ReadKey();*/
            /*List<User> users = new List<User>();

            users.Add(new User() { UserName = "DrLivesey", RoleName = "Teacher" });
            users.Add(new User() { UserName = "JimGokins", RoleName = "Student" });

            while (true)
            {
                Person person = null;
                Console.WriteLine("to authorizate - press 1, otherwise 0");
                int choose = Convert.ToInt32(Console.ReadLine());

                if (choose == 1)
                {
                    Console.WriteLine("Your username");
                    string login = Console.ReadLine();

                    foreach (User user in users)
                    {
                        if (user.UserName == login)
                        {
                            Console.WriteLine("Choose your course: 1 - Math, 2 - Math Zimin");
                            int courseChoice = Convert.ToInt32(Console.ReadLine());

                            if (user.RoleName == "Teacher" && courseChoice == 1)
                            {
                                person = new Instructor(new LowLevelClassMenu());
                            }
                            if (user.RoleName == "Teacher" && courseChoice == 2)
                            {
                                person = new Instructor(new HighLevelClassMenu());
                            }
                            if (user.RoleName == "Student" && courseChoice == 1)
                            {
                                person = new Student(new LowLevelClassMenu());
                            }
                            if (user.RoleName == "Student" && courseChoice == 2)
                            {
                                person = new Student(new HighLevelClassMenu());
                            }
                            Console.WriteLine(person.GetInterface());
                        }
                    }
                }
                else
                {
                    break;
                }
            }*/

        }
    }
}