using Empresa;
Worker worker = new Worker();

string[,] workers = new string[2, 3];
string[,] workersID = new string[2, 3];
int[,] workersSalary = new int[2, 3];

workers[0, 0] = "Fernando - TI";
workers[0, 1] = "Jefferson - RH";
workers[0, 2] = "Matheus - Manager";
workers[1, 0] = "Amanda - Analystics";
workers[1, 1] = "Julia - Dev";
Console.WriteLine("Hasys EnterPrise LTDA");
workersSalary[0, 0] = 5536;
workersSalary[0, 1] = 8300;
workersSalary[0, 2] = 7780;
workersSalary[1, 0] = 7550;
workersSalary[1, 1] = 9645;
workersID[0, 0] = "0,0";
workersID[0, 1] = "0,1";
workersID[0, 2] = "0,2";
workersID[1, 0] = "1,0";
workersID[1, 1] = "1,1";

bool working = true;

while (working)
{
    Console.WriteLine("\n1 - Ver funcionários\n2 - Demitir Funcionário\n3 - Atribuir Serviço\n4 - Encerrar");
    string userFirstInput = IsEmpty.EmptyST(Console.ReadLine());
    if (userFirstInput == "1")
    {
        Console.Clear();
        worker.ShowWorkers(workers, workersSalary, workersID);
    }
    if (userFirstInput == "2")
    {
        Console.Clear();
        worker.FireWorker(workers);
    }
    if (userFirstInput == "3")
    {
        Console.Clear();
        worker.SetService(workers, workersID);
    }
    if (userFirstInput == "4")
    {
        Thread.Sleep(250);
        Console.WriteLine("Encerrando...");
        working = false;
    }
}