using Dto;
using Services;




ClientService serviceClient = new ClientService();
Client cl = new Client();
Console.WriteLine ("Gestion commercial");




bool validationAjouter = true;

while (validationAjouter)
{

    Console.Write("Nom client : ");
    cl.Nom = Console.ReadLine();
    string m = serviceClient.Create(cl);
    if(m != "")
    {
        Console.WriteLine(m);
    }else
        validationAjouter = false;

}