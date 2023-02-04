using Dto;
using Services;

ClientService serviceClient = new ClientService();
Client cl = new Client();

bool validationAjouter = false;

while (validationAjouter)
{

    Console.Write("Nom client : ");
    cl.Nom = Console.ReadLine();
    string m = serviceClient.Create(cl);
    if(m != "")
    {
        Console.WriteLine(m);
    }else
        validationAjouter = true;

}