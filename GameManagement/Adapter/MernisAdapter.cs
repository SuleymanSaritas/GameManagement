using GameManagement.Entities;
using GameManagement.Abstract;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Adapter
{
    class MernisAdapter : IGamerCheckService
    {
        public bool CheckIfItsReal(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync
                (new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(
                    
                    gamer.NationalityId,
                    gamer.Firstname.ToUpper(),
                    gamer.Lastname.ToUpper(),
                    gamer.DateOfBirth.Year)))
                .Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
