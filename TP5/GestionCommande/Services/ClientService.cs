using Repos;

namespace Services;

public class ClientService
{

    public string Create(Client dto)
    {
        ClientRepos _serviceClient = new ClientRepos();

        //US :1  Auto increment ID
        dto.Id =  _serviceClient.LastId() + 1;

        //US : 2 Ajouter pas deux client 
        if (_serviceClient.verifierClient(dto.Nom))
        {
            return "Impossible ajouter ce client";
        }

        //US : 3 Ajouter un client
        _serviceClient.Create(dto);

        return "";
    }

}
