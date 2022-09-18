namespace Empresa
{
    public class Worker
    {
        public void ShowWorkers(string[,] workers, int[,] salary, string[,] workersID)
        {
            Console.Clear();
            for (int i = 0; i < workers.GetLength(0); i++) // MOSTRAR
            {
                for (int j = 0; j < workers.GetLength(1); j++)
                {
                    if (workers[i, j] == null && workers[i, j] == null)
                    {

                    }
                    else
                    {
                        Console.WriteLine($"ID: {workersID[i, j]} - {workers[i, j]} | Salario: R${salary[i, j]}");
                    }
                }
            }
        }
        public void FireWorker(string[,] workers)
        {
            int vertical = 0; int horizontal = 0;
            Console.Clear();
            Console.WriteLine("Digite o funcionário que deseja demitir");
            for (int i = 0; i < 1; i++)  // ESCOLHER
            {
                for (int j = 0; j < 1; j++)
                {
                    Console.WriteLine("Digite sua opção na vertical");
                    vertical = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite sua opção na horizontal");
                    horizontal = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine($"Escolhido: {workers[vertical, horizontal]}");
                Console.WriteLine("Clique ENTER para demitir");
                Console.ReadKey();
                workers[vertical, horizontal] = null;
            }
        }

        public void FirePattern(string[,] workers, int index1, int index2)
        {
            Console.WriteLine($"Clique ENTER para demitir:{workers[index1, index2]}");
            Console.ReadKey();
            workers[index1, index2] = null;
        }
        public void SetService(string[,] workers, string[,] workersID)
        {
            Console.WriteLine("Digite a ID do funcionário: ");
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Console.WriteLine("Digite sua opção na vertical");
                    i = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite sua opção na horizontal");
                    j = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Digite o serviço para atribuiar á {workers[i, j]}: ");
                    string userInputService = IsEmpty.EmptyST(Console.ReadLine());
                    Console.WriteLine($"{userInputService} atribuído á {workers[i, j]}");
                }
            }
        }
    }
}