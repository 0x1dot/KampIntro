using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamingProject.Adapters
{
    public class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckIfRealPerson(Frisky frisky)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(frisky.IdentityID),frisky.FirstName.ToUpper(),frisky.LastName.ToUpper(),frisky.Date.Year))).Result.Body.TCKimlikNoDogrulaResult; 

        }
    }
}
