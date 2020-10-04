using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Tasks2
{
    class Team
    {
        string name;
        int points;

        public void SetName()
        {
            Console.WriteLine("Enter team name: ");
            name = Console.ReadLine();
        }
        public void SetPoints()
        {
            Console.WriteLine("Enter team points: ");
            points = Convert.ToInt32(Console.ReadLine());
        }
        public string GetName()
        {
            return name;
        }
        public int GetPoints()
        {
            return points;
        }
    }

    class Task7
    {
        public static void Start()
        {
            string path = @"..\..\..\test.txt";
            bool key = true;
            while (key)
            {
                Console.WriteLine("Choose function:\n\tdefault - view list of teams\n\t1 - add new team\n\t2 - add points to \n\t3 - take points away\n\t4 - delete team\n\t5 - save\n\t6 - exit");
                switch (Console.Read())
                {
                    default:
                        ViewFile(path);
                        break;
                    case '1':
                        AddTeam(path);
                        break;
                    case '2':
                        PointsModyfication(path, 1);
                        break;
                    case '3':
                        PointsModyfication(path, 2);
                        break;
                    case '4':

                        break;
                    case '5':

                        break;
                    case '6':
                        key = false;
                        break;
                }
            }
        }

        static void AddTeam(string path)
        {
            Console.WriteLine("Adding new team.");
            Team team = new Team();
            team.SetName();
            team.SetPoints();
            var str = "Name: " + team.GetName() + "\tPoints: " + team.GetPoints();
            WriteToFile(path, str);
        }

        static async Task WriteToFile(string path, string info)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    await sw.WriteLineAsync(info);
                }

                using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
                {
                    await sw.WriteLineAsync(info);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static async Task ViewFile(string path)
        {
            using StreamReader sr = new StreamReader(path, System.Text.Encoding.Default);
            string line;
            while ((line = await sr.ReadLineAsync()) != null)
            {
                Console.WriteLine(line);
            }
        }

        static async Task PointsModyfication(string path, int key)
        {
            ViewFile(path);
            Console.WriteLine("Choose team to which you want to add points: ");
            string team = Console.ReadLine();
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = await sr.ReadLineAsync()) != null)
                {
                    if (line.IndexOf(team) > 0)
                    {
                        team = line;
                    }
                }
            }
            int ind = team.Length;
            for (; team[ind] >= '0' && team[ind] <= '9'; ind--) ;
            string pointsString = team.Substring(ind);
            int points = Convert.ToInt32(pointsString);
            if (key == 1)
            {
                pointsString = Convert.ToString(--points);
            }
            else if (key == 2)
            {
                pointsString = Convert.ToString(++points);
            }
            team.Insert(ind, pointsString);
            Console.WriteLine(team);
        }
    }
}
