﻿

    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ServiceModel.ServiceContractAttribute(Namespace = "http://ws.agiv.be/crabws", ConfigurationName = "WsCrabServiceReference.IWsCrab")]
    //public interface IWsCrab
    //{

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/FindGemeenten", ReplyAction = "http://ws.agiv.be/crabws/FindGemeentenResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.FindGemeentenResponse> FindGemeentenAsync(WsCrabServiceReference.FindGemeentenRequest request);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/FindHuisnummers", ReplyAction = "http://ws.agiv.be/crabws/FindHuisnummersResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.FindHuisnummersResponse> FindHuisnummersAsync(WsCrabServiceReference.FindHuisnummersRequest request);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/FindHuisnummersWithStatus", ReplyAction = "http://ws.agiv.be/crabws/FindHuisnummersWithStatusResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.FindHuisnummersWithStatusResponse> FindHuisnummersWithStatusAsync(WsCrabServiceReference.FindHuisnummersWithStatusRequest request);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/FindStraatnamen", ReplyAction = "http://ws.agiv.be/crabws/FindStraatnamenResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.FindStraatnamenResponse> FindStraatnamenAsync(WsCrabServiceReference.FindStraatnamenRequest request);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/FindStraatnamenWithStatus", ReplyAction = "http://ws.agiv.be/crabws/FindStraatnamenWithStatusResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.FindStraatnamenWithStatusResponse> FindStraatnamenWithStatusAsync(WsCrabServiceReference.FindStraatnamenWithStatusRequest request);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/FindSubadressen", ReplyAction = "http://ws.agiv.be/crabws/FindSubadressenResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.FindSubadressenResponse> FindSubadressenAsync(WsCrabServiceReference.FindSubadressenRequest request);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/FindSubadressenWithStatus", ReplyAction = "http://ws.agiv.be/crabws/FindSubadressenWithStatusResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.FindSubadressenWithStatusResponse> FindSubadressenWithStatusAsync(WsCrabServiceReference.FindSubadressenWithStatusRequest request);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/GetAdrespositieByAdrespositieId", ReplyAction = "http://ws.agiv.be/crabws/GetAdrespositieByAdrespositieIdResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.AdrespositieObject> GetAdrespositieByAdrespositieIdAsync(int AdrespositieId);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/GetGebouwByIdentificatorGebouw", ReplyAction = "http://ws.agiv.be/crabws/GetGebouwByIdentificatorGebouwResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.GetGebouwByIdentificatorGebouwResponse> GetGebouwByIdentificatorGebouwAsync(WsCrabServiceReference.GetGebouwByIdentificatorGebouwRequest request);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/GetGemeenteByGemeenteId", ReplyAction = "http://ws.agiv.be/crabws/GetGemeenteByGemeenteIdResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.GemeenteObject> GetGemeenteByGemeenteIdAsync(int GemeenteId);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/GetGemeenteByGemeenteNaam", ReplyAction = "http://ws.agiv.be/crabws/GetGemeenteByGemeenteNaamResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.GetGemeenteByGemeenteNaamResponse> GetGemeenteByGemeenteNaamAsync(WsCrabServiceReference.GetGemeenteByGemeenteNaamRequest request);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/GetGemeenteByNISGemeenteCode", ReplyAction = "http://ws.agiv.be/crabws/GetGemeenteByNISGemeenteCodeResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.GemeenteObject> GetGemeenteByNISGemeenteCodeAsync(int NISGemeenteCode);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/GetGewestByGewestIdAndTaalCode", ReplyAction = "http://ws.agiv.be/crabws/GetGewestByGewestIdAndTaalCodeResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.GetGewestByGewestIdAndTaalCodeResponse> GetGewestByGewestIdAndTaalCodeAsync(WsCrabServiceReference.GetGewestByGewestIdAndTaalCodeRequest request);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/GetHuisnummerByHuisnummer", ReplyAction = "http://ws.agiv.be/crabws/GetHuisnummerByHuisnummerResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.GetHuisnummerByHuisnummerResponse> GetHuisnummerByHuisnummerAsync(WsCrabServiceReference.GetHuisnummerByHuisnummerRequest request);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/GetHuisnummerByHuisnummerId", ReplyAction = "http://ws.agiv.be/crabws/GetHuisnummerByHuisnummerIdResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.HuisnummerObject> GetHuisnummerByHuisnummerIdAsync(int HuisnummerId);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/GetHuisnummerWithStatusByHuisnummer", ReplyAction = "http://ws.agiv.be/crabws/GetHuisnummerWithStatusByHuisnummerResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.GetHuisnummerWithStatusByHuisnummerResponse> GetHuisnummerWithStatusByHuisnummerAsync(WsCrabServiceReference.GetHuisnummerWithStatusByHuisnummerRequest request);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/GetHuisnummerWithStatusByHuisnummerId", ReplyAction = "http://ws.agiv.be/crabws/GetHuisnummerWithStatusByHuisnummerIdResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.HuisnummerWithStatusObject> GetHuisnummerWithStatusByHuisnummerIdAsync(int HuisnummerId);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/GetPerceelByIdentificatorPerceel", ReplyAction = "http://ws.agiv.be/crabws/GetPerceelByIdentificatorPerceelResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.GetPerceelByIdentificatorPerceelResponse> GetPerceelByIdentificatorPerceelAsync(WsCrabServiceReference.GetPerceelByIdentificatorPerceelRequest request);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/GetPostadresByHuisnummerId", ReplyAction = "http://ws.agiv.be/crabws/GetPostadresByHuisnummerIdResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.PostadresObject> GetPostadresByHuisnummerIdAsync(int HuisnummerId);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/GetPostadresBySubadresId", ReplyAction = "http://ws.agiv.be/crabws/GetPostadresBySubadresIdResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.PostadresObject> GetPostadresBySubadresIdAsync(int SubadresId);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/GetPostkantonByHuisnummerId", ReplyAction = "http://ws.agiv.be/crabws/GetPostkantonByHuisnummerIdResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.PostkantonObject> GetPostkantonByHuisnummerIdAsync(int HuisnummerId);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/GetRijksregisterStraatByRijksregisterStraatCode", ReplyAction = "http://ws.agiv.be/crabws/GetRijksregisterStraatByRijksregisterStraatCodeResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.RijksregisterstraatObject> GetRijksregisterStraatByRijksregisterStraatCodeAsync(int StraatCode, int SubkantonCode);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/GetStraatnaamByRijksregisterStraatCode", ReplyAction = "http://ws.agiv.be/crabws/GetStraatnaamByRijksregisterStraatCodeResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.StraatnaamObject> GetStraatnaamByRijksregisterStraatCodeAsync(int StraatCode, int SubkantonCode);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/GetStraatnaamByStraatnaam", ReplyAction = "http://ws.agiv.be/crabws/GetStraatnaamByStraatnaamResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.GetStraatnaamByStraatnaamResponse> GetStraatnaamByStraatnaamAsync(WsCrabServiceReference.GetStraatnaamByStraatnaamRequest request);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/GetStraatnaamByStraatnaamId", ReplyAction = "http://ws.agiv.be/crabws/GetStraatnaamByStraatnaamIdResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.StraatnaamObject> GetStraatnaamByStraatnaamIdAsync(int StraatnaamId);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/GetStraatnaamWithStatusByRijksregisterStraatCode", ReplyAction = "http://ws.agiv.be/crabws/GetStraatnaamWithStatusByRijksregisterStraatCodeResponse" +
    //        "")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.StraatnaamWithStatusObject> GetStraatnaamWithStatusByRijksregisterStraatCodeAsync(int StraatCode, int SubkantonCode);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/GetStraatnaamWithStatusByStraatnaam", ReplyAction = "http://ws.agiv.be/crabws/GetStraatnaamWithStatusByStraatnaamResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.GetStraatnaamWithStatusByStraatnaamResponse> GetStraatnaamWithStatusByStraatnaamAsync(WsCrabServiceReference.GetStraatnaamWithStatusByStraatnaamRequest request);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/GetStraatnaamWithStatusByStraatnaamId", ReplyAction = "http://ws.agiv.be/crabws/GetStraatnaamWithStatusByStraatnaamIdResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.StraatnaamWithStatusObject> GetStraatnaamWithStatusByStraatnaamIdAsync(int StraatnaamId);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/GetSubadresBySubadresId", ReplyAction = "http://ws.agiv.be/crabws/GetSubadresBySubadresIdResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.SubadresObject> GetSubadresBySubadresIdAsync(int SubadresId);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/GetSubadresWithStatusBySubadresId", ReplyAction = "http://ws.agiv.be/crabws/GetSubadresWithStatusBySubadresIdResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.SubadresWithStatusObject> GetSubadresWithStatusBySubadresIdAsync(int SubadresId);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/GetTerreinobjectByIdentificatorTerreinobject", ReplyAction = "http://ws.agiv.be/crabws/GetTerreinobjectByIdentificatorTerreinobjectResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.GetTerreinobjectByIdentificatorTerreinobjectResponse> GetTerreinobjectByIdentificatorTerreinobjectAsync(WsCrabServiceReference.GetTerreinobjectByIdentificatorTerreinobjectRequest request);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/GetWegobjectByIdentificatorWegobject", ReplyAction = "http://ws.agiv.be/crabws/GetWegobjectByIdentificatorWegobjectResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.GetWegobjectByIdentificatorWegobjectResponse> GetWegobjectByIdentificatorWegobjectAsync(WsCrabServiceReference.GetWegobjectByIdentificatorWegobjectRequest request);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/GetWegsegmentByIdentificatorWegsegment", ReplyAction = "http://ws.agiv.be/crabws/GetWegsegmentByIdentificatorWegsegmentResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.GetWegsegmentByIdentificatorWegsegmentResponse> GetWegsegmentByIdentificatorWegsegmentAsync(WsCrabServiceReference.GetWegsegmentByIdentificatorWegsegmentRequest request);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListAardAdressen", ReplyAction = "http://ws.agiv.be/crabws/ListAardAdressenResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.CodeItem[]> ListAardAdressenAsync(int SorteerVeld);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListAardGebouwen", ReplyAction = "http://ws.agiv.be/crabws/ListAardGebouwenResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.CodeItem[]> ListAardGebouwenAsync(int SorteerVeld);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListAardSubadressen", ReplyAction = "http://ws.agiv.be/crabws/ListAardSubadressenResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.CodeItem[]> ListAardSubadressenAsync(int SorteerVeld);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListAardTerreinobjecten", ReplyAction = "http://ws.agiv.be/crabws/ListAardTerreinobjectenResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.CodeItem[]> ListAardTerreinobjectenAsync(int SorteerVeld);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListAardWegobjecten", ReplyAction = "http://ws.agiv.be/crabws/ListAardWegobjectenResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.CodeItem[]> ListAardWegobjectenAsync(int SorteerVeld);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListAdrespositiesByHuisnummer", ReplyAction = "http://ws.agiv.be/crabws/ListAdrespositiesByHuisnummerResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.ListAdrespositiesByHuisnummerResponse> ListAdrespositiesByHuisnummerAsync(WsCrabServiceReference.ListAdrespositiesByHuisnummerRequest request);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListAdrespositiesByHuisnummerId", ReplyAction = "http://ws.agiv.be/crabws/ListAdrespositiesByHuisnummerIdResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.AdrespositieItem[]> ListAdrespositiesByHuisnummerIdAsync(int HuisnummerId, int SorteerVeld);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListAdrespositiesBySubadres", ReplyAction = "http://ws.agiv.be/crabws/ListAdrespositiesBySubadresResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.ListAdrespositiesBySubadresResponse> ListAdrespositiesBySubadresAsync(WsCrabServiceReference.ListAdrespositiesBySubadresRequest request);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListAdrespositiesBySubadresId", ReplyAction = "http://ws.agiv.be/crabws/ListAdrespositiesBySubadresIdResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.AdrespositieItem[]> ListAdrespositiesBySubadresIdAsync(int SubadresId, int SorteerVeld);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListBewerkingen", ReplyAction = "http://ws.agiv.be/crabws/ListBewerkingenResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.CodeItem[]> ListBewerkingenAsync(int SorteerVeld);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListGebouwenByHuisnummer", ReplyAction = "http://ws.agiv.be/crabws/ListGebouwenByHuisnummerResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.ListGebouwenByHuisnummerResponse> ListGebouwenByHuisnummerAsync(WsCrabServiceReference.ListGebouwenByHuisnummerRequest request);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListGebouwenByHuisnummerId", ReplyAction = "http://ws.agiv.be/crabws/ListGebouwenByHuisnummerIdResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.GebouwItem[]> ListGebouwenByHuisnummerIdAsync(int HuisnummerId, int SorteerVeld);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListGemeentenByGewestId", ReplyAction = "http://ws.agiv.be/crabws/ListGemeentenByGewestIdResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.GemeenteItem[]> ListGemeentenByGewestIdAsync(int GewestId, int SorteerVeld);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListGeometriemethodeGebouwen", ReplyAction = "http://ws.agiv.be/crabws/ListGeometriemethodeGebouwenResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.CodeItem[]> ListGeometriemethodeGebouwenAsync(int SorteerVeld);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListGeometriemethodeWegsegmenten", ReplyAction = "http://ws.agiv.be/crabws/ListGeometriemethodeWegsegmentenResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.CodeItem[]> ListGeometriemethodeWegsegmentenAsync(int SorteerVeld);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListGewesten", ReplyAction = "http://ws.agiv.be/crabws/ListGewestenResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.GewestItem[]> ListGewestenAsync(int SorteerVeld);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListHerkomstAdresposities", ReplyAction = "http://ws.agiv.be/crabws/ListHerkomstAdrespositiesResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.CodeItem[]> ListHerkomstAdrespositiesAsync(int SorteerVeld);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListHuisnummersByIdentificatorTerreinobject", ReplyAction = "http://ws.agiv.be/crabws/ListHuisnummersByIdentificatorTerreinobjectResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.ListHuisnummersByIdentificatorTerreinobjectResponse> ListHuisnummersByIdentificatorTerreinobjectAsync(WsCrabServiceReference.ListHuisnummersByIdentificatorTerreinobjectRequest request);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListHuisnummersByStraatnaamId", ReplyAction = "http://ws.agiv.be/crabws/ListHuisnummersByStraatnaamIdResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.HuisnummerItem[]> ListHuisnummersByStraatnaamIdAsync(int StraatnaamId, int SorteerVeld);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListHuisnummersWithStatusByIdentificatorGebouw", ReplyAction = "http://ws.agiv.be/crabws/ListHuisnummersWithStatusByIdentificatorGebouwResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.ListHuisnummersWithStatusByIdentificatorGebouwResponse> ListHuisnummersWithStatusByIdentificatorGebouwAsync(WsCrabServiceReference.ListHuisnummersWithStatusByIdentificatorGebouwRequest request);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListHuisnummersWithStatusByIdentificatorPerceel", ReplyAction = "http://ws.agiv.be/crabws/ListHuisnummersWithStatusByIdentificatorPerceelResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.ListHuisnummersWithStatusByIdentificatorPerceelResponse> ListHuisnummersWithStatusByIdentificatorPerceelAsync(WsCrabServiceReference.ListHuisnummersWithStatusByIdentificatorPerceelRequest request);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListHuisnummersWithStatusByIdentificatorTerreinobject", ReplyAction = "http://ws.agiv.be/crabws/ListHuisnummersWithStatusByIdentificatorTerreinobjectRes" +
    //        "ponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.ListHuisnummersWithStatusByIdentificatorTerreinobjectResponse> ListHuisnummersWithStatusByIdentificatorTerreinobjectAsync(WsCrabServiceReference.ListHuisnummersWithStatusByIdentificatorTerreinobjectRequest request);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListHuisnummersWithStatusByRijksregisterAdresId", ReplyAction = "http://ws.agiv.be/crabws/ListHuisnummersWithStatusByRijksregisterAdresIdResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.HuisnummerWithStatusItem[]> ListHuisnummersWithStatusByRijksregisterAdresIdAsync(int RijksregisterAdresId, int SorteerVeld);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListHuisnummersWithStatusByStraatnaamId", ReplyAction = "http://ws.agiv.be/crabws/ListHuisnummersWithStatusByStraatnaamIdResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.HuisnummerWithStatusItem[]> ListHuisnummersWithStatusByStraatnaamIdAsync(int StraatnaamId, int SorteerVeld);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListOrganisaties", ReplyAction = "http://ws.agiv.be/crabws/ListOrganisatiesResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.CodeItem[]> ListOrganisatiesAsync(int SorteerVeld);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListPercelenByHuisnummer", ReplyAction = "http://ws.agiv.be/crabws/ListPercelenByHuisnummerResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.ListPercelenByHuisnummerResponse> ListPercelenByHuisnummerAsync(WsCrabServiceReference.ListPercelenByHuisnummerRequest request);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListPercelenByHuisnummerId", ReplyAction = "http://ws.agiv.be/crabws/ListPercelenByHuisnummerIdResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.PerceelItem[]> ListPercelenByHuisnummerIdAsync(int HuisnummerId);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListPostadressenByStraatnaamId", ReplyAction = "http://ws.agiv.be/crabws/ListPostadressenByStraatnaamIdResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.PostadresItem[]> ListPostadressenByStraatnaamIdAsync(int StraatnaamId);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListPostkantonsByGemeenteId", ReplyAction = "http://ws.agiv.be/crabws/ListPostkantonsByGemeenteIdResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.PostkantonItem[]> ListPostkantonsByGemeenteIdAsync(int GemeenteId);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListRijksregisterStratenByStraatnaamId", ReplyAction = "http://ws.agiv.be/crabws/ListRijksregisterStratenByStraatnaamIdResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.RijksregisterstraatItem[]> ListRijksregisterStratenByStraatnaamIdAsync(int StraatnaamId);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListRijksregisterAdresByHuisnummer", ReplyAction = "http://ws.agiv.be/crabws/ListRijksregisterAdresByHuisnummerResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.ListRijksregisterAdresByHuisnummerResponse> ListRijksregisterAdresByHuisnummerAsync(WsCrabServiceReference.ListRijksregisterAdresByHuisnummerRequest request);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListRijksregisterAdresByHuisnummerId", ReplyAction = "http://ws.agiv.be/crabws/ListRijksregisterAdresByHuisnummerIdResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.RijksregisterAdresItem[]> ListRijksregisterAdresByHuisnummerIdAsync(int HuisnummerId, int SorteerVeld);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListRijksregisterAdresBySubadresId", ReplyAction = "http://ws.agiv.be/crabws/ListRijksregisterAdresBySubadresIdResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.RijksregisterAdresItem[]> ListRijksregisterAdresBySubadresIdAsync(int SubadresId, int SorteerVeld);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListStatusGebouwen", ReplyAction = "http://ws.agiv.be/crabws/ListStatusGebouwenResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.CodeItem[]> ListStatusGebouwenAsync(int SorteerVeld);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListStatusHuisnummers", ReplyAction = "http://ws.agiv.be/crabws/ListStatusHuisnummersResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.CodeItem[]> ListStatusHuisnummersAsync(int SorteerVeld);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListStatusStraatnamen", ReplyAction = "http://ws.agiv.be/crabws/ListStatusStraatnamenResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.CodeItem[]> ListStatusStraatnamenAsync(int SorteerVeld);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListStatusSubadressen", ReplyAction = "http://ws.agiv.be/crabws/ListStatusSubadressenResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.CodeItem[]> ListStatusSubadressenAsync(int SorteerVeld);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListStatusWegsegmenten", ReplyAction = "http://ws.agiv.be/crabws/ListStatusWegsegmentenResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.CodeItem[]> ListStatusWegsegmentenAsync(int SorteerVeld);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListStraatnamenByGemeenteId", ReplyAction = "http://ws.agiv.be/crabws/ListStraatnamenByGemeenteIdResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.StraatnaamItem[]> ListStraatnamenByGemeenteIdAsync(int GemeenteId, int SorteerVeld);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListStraatnamenByIdentificatorWegobject", ReplyAction = "http://ws.agiv.be/crabws/ListStraatnamenByIdentificatorWegobjectResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.ListStraatnamenByIdentificatorWegobjectResponse> ListStraatnamenByIdentificatorWegobjectAsync(WsCrabServiceReference.ListStraatnamenByIdentificatorWegobjectRequest request);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListStraatnamenWithStatusByGemeenteId", ReplyAction = "http://ws.agiv.be/crabws/ListStraatnamenWithStatusByGemeenteIdResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.StraatnaamWithStatusItem[]> ListStraatnamenWithStatusByGemeenteIdAsync(int GemeenteId, int SorteerVeld);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListStraatnamenWithStatusByIdentificatorWegobject", ReplyAction = "http://ws.agiv.be/crabws/ListStraatnamenWithStatusByIdentificatorWegobjectRespons" +
    //        "e")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.ListStraatnamenWithStatusByIdentificatorWegobjectResponse> ListStraatnamenWithStatusByIdentificatorWegobjectAsync(WsCrabServiceReference.ListStraatnamenWithStatusByIdentificatorWegobjectRequest request);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListStraatnamenWithStatusByIdentificatorWegsegment", ReplyAction = "http://ws.agiv.be/crabws/ListStraatnamenWithStatusByIdentificatorWegsegmentRespon" +
    //        "se")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.ListStraatnamenWithStatusByIdentificatorWegsegmentResponse> ListStraatnamenWithStatusByIdentificatorWegsegmentAsync(WsCrabServiceReference.ListStraatnamenWithStatusByIdentificatorWegsegmentRequest request);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListSubadressenByHuisnummerId", ReplyAction = "http://ws.agiv.be/crabws/ListSubadressenByHuisnummerIdResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.SubadresItem[]> ListSubadressenByHuisnummerIdAsync(int HuisnummerId, int SorteerVeld);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListSubadressenWithStatusByHuisnummerId", ReplyAction = "http://ws.agiv.be/crabws/ListSubadressenWithStatusByHuisnummerIdResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.SubadresWithStatusItem[]> ListSubadressenWithStatusByHuisnummerIdAsync(int HuisnummerId, int SorteerVeld);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListSubadressenWithStatusByRijksregisterAdresId", ReplyAction = "http://ws.agiv.be/crabws/ListSubadressenWithStatusByRijksregisterAdresIdResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.SubadresWithStatusItem[]> ListSubadressenWithStatusByRijksregisterAdresIdAsync(int RijksregisterAdresId, int SorteerVeld);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListTalen", ReplyAction = "http://ws.agiv.be/crabws/ListTalenResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.CodeItem[]> ListTalenAsync(int SorteerVeld);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListTerreinobjectenByHuisnummerId", ReplyAction = "http://ws.agiv.be/crabws/ListTerreinobjectenByHuisnummerIdResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.TerreinobjectItem[]> ListTerreinobjectenByHuisnummerIdAsync(int HuisnummerId, int SorteerVeld);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListWegobjectenByStraatnaamId", ReplyAction = "http://ws.agiv.be/crabws/ListWegobjectenByStraatnaamIdResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.WegobjectItem[]> ListWegobjectenByStraatnaamIdAsync(int StraatnaamId, int SorteerVeld);

    //    [System.ServiceModel.OperationContractAttribute(Action = "http://ws.agiv.be/crabws/ListWegsegmentenByStraatnaamId", ReplyAction = "http://ws.agiv.be/crabws/ListWegsegmentenByStraatnaamIdResponse")]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.WegsegmentItem[]> ListWegsegmentenByStraatnaamIdAsync(int StraatnaamId, int SorteerVeld);
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class FindGemeentenRequest
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "FindGemeenten", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.FindGemeentenRequestBody Body;

    //    public FindGemeentenRequest()
    //    {
    //    }

    //    public FindGemeentenRequest(WsCrabServiceReference.FindGemeentenRequestBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class FindGemeentenRequestBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
    //    public string GemeenteNaam;

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
    //    public int GewestId;

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
    //    public int SorteerVeld;

    //    public FindGemeentenRequestBody()
    //    {
    //    }

    //    public FindGemeentenRequestBody(string GemeenteNaam, int GewestId, int SorteerVeld)
    //    {
    //        this.GemeenteNaam = GemeenteNaam;
    //        this.GewestId = GewestId;
    //        this.SorteerVeld = SorteerVeld;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class FindGemeentenResponse
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "FindGemeentenResponse", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.FindGemeentenResponseBody Body;

    //    public FindGemeentenResponse()
    //    {
    //    }

    //    public FindGemeentenResponse(WsCrabServiceReference.FindGemeentenResponseBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class FindGemeentenResponseBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 0)]
    //    public WsCrabServiceReference.GemeenteItem[] FindGemeentenResult;

    //    public FindGemeentenResponseBody()
    //    {
    //    }

    //    public FindGemeentenResponseBody(WsCrabServiceReference.GemeenteItem[] FindGemeentenResult)
    //    {
    //        this.FindGemeentenResult = FindGemeentenResult;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class FindHuisnummersRequest
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "FindHuisnummers", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.FindHuisnummersRequestBody Body;

    //    public FindHuisnummersRequest()
    //    {
    //    }

    //    public FindHuisnummersRequest(WsCrabServiceReference.FindHuisnummersRequestBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class FindHuisnummersRequestBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
    //    public string Huisnummer;

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
    //    public int StraatnaamId;

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
    //    public int SorteerVeld;

    //    public FindHuisnummersRequestBody()
    //    {
    //    }

    //    public FindHuisnummersRequestBody(string Huisnummer, int StraatnaamId, int SorteerVeld)
    //    {
    //        this.Huisnummer = Huisnummer;
    //        this.StraatnaamId = StraatnaamId;
    //        this.SorteerVeld = SorteerVeld;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class FindHuisnummersResponse
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "FindHuisnummersResponse", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.FindHuisnummersResponseBody Body;

    //    public FindHuisnummersResponse()
    //    {
    //    }

    //    public FindHuisnummersResponse(WsCrabServiceReference.FindHuisnummersResponseBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class FindHuisnummersResponseBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 0)]
    //    public WsCrabServiceReference.HuisnummerItem[] FindHuisnummersResult;

    //    public FindHuisnummersResponseBody()
    //    {
    //    }

    //    public FindHuisnummersResponseBody(WsCrabServiceReference.HuisnummerItem[] FindHuisnummersResult)
    //    {
    //        this.FindHuisnummersResult = FindHuisnummersResult;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class FindHuisnummersWithStatusRequest
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "FindHuisnummersWithStatus", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.FindHuisnummersWithStatusRequestBody Body;

    //    public FindHuisnummersWithStatusRequest()
    //    {
    //    }

    //    public FindHuisnummersWithStatusRequest(WsCrabServiceReference.FindHuisnummersWithStatusRequestBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class FindHuisnummersWithStatusRequestBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
    //    public string Huisnummer;

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
    //    public int StraatnaamId;

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
    //    public int SorteerVeld;

    //    public FindHuisnummersWithStatusRequestBody()
    //    {
    //    }

    //    public FindHuisnummersWithStatusRequestBody(string Huisnummer, int StraatnaamId, int SorteerVeld)
    //    {
    //        this.Huisnummer = Huisnummer;
    //        this.StraatnaamId = StraatnaamId;
    //        this.SorteerVeld = SorteerVeld;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class FindHuisnummersWithStatusResponse
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "FindHuisnummersWithStatusResponse", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.FindHuisnummersWithStatusResponseBody Body;

    //    public FindHuisnummersWithStatusResponse()
    //    {
    //    }

    //    public FindHuisnummersWithStatusResponse(WsCrabServiceReference.FindHuisnummersWithStatusResponseBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class FindHuisnummersWithStatusResponseBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 0)]
    //    public WsCrabServiceReference.HuisnummerWithStatusItem[] FindHuisnummersWithStatusResult;

    //    public FindHuisnummersWithStatusResponseBody()
    //    {
    //    }

    //    public FindHuisnummersWithStatusResponseBody(WsCrabServiceReference.HuisnummerWithStatusItem[] FindHuisnummersWithStatusResult)
    //    {
    //        this.FindHuisnummersWithStatusResult = FindHuisnummersWithStatusResult;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class FindStraatnamenRequest
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "FindStraatnamen", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.FindStraatnamenRequestBody Body;

    //    public FindStraatnamenRequest()
    //    {
    //    }

    //    public FindStraatnamenRequest(WsCrabServiceReference.FindStraatnamenRequestBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class FindStraatnamenRequestBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
    //    public string Straatnaam;

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
    //    public int GemeenteId;

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
    //    public int SorteerVeld;

    //    public FindStraatnamenRequestBody()
    //    {
    //    }

    //    public FindStraatnamenRequestBody(string Straatnaam, int GemeenteId, int SorteerVeld)
    //    {
    //        this.Straatnaam = Straatnaam;
    //        this.GemeenteId = GemeenteId;
    //        this.SorteerVeld = SorteerVeld;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class FindStraatnamenResponse
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "FindStraatnamenResponse", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.FindStraatnamenResponseBody Body;

    //    public FindStraatnamenResponse()
    //    {
    //    }

    //    public FindStraatnamenResponse(WsCrabServiceReference.FindStraatnamenResponseBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class FindStraatnamenResponseBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 0)]
    //    public WsCrabServiceReference.StraatnaamItem[] FindStraatnamenResult;

    //    public FindStraatnamenResponseBody()
    //    {
    //    }

    //    public FindStraatnamenResponseBody(WsCrabServiceReference.StraatnaamItem[] FindStraatnamenResult)
    //    {
    //        this.FindStraatnamenResult = FindStraatnamenResult;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class FindStraatnamenWithStatusRequest
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "FindStraatnamenWithStatus", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.FindStraatnamenWithStatusRequestBody Body;

    //    public FindStraatnamenWithStatusRequest()
    //    {
    //    }

    //    public FindStraatnamenWithStatusRequest(WsCrabServiceReference.FindStraatnamenWithStatusRequestBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class FindStraatnamenWithStatusRequestBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
    //    public string Straatnaam;

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
    //    public int GemeenteId;

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
    //    public int SorteerVeld;

    //    public FindStraatnamenWithStatusRequestBody()
    //    {
    //    }

    //    public FindStraatnamenWithStatusRequestBody(string Straatnaam, int GemeenteId, int SorteerVeld)
    //    {
    //        this.Straatnaam = Straatnaam;
    //        this.GemeenteId = GemeenteId;
    //        this.SorteerVeld = SorteerVeld;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class FindStraatnamenWithStatusResponse
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "FindStraatnamenWithStatusResponse", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.FindStraatnamenWithStatusResponseBody Body;

    //    public FindStraatnamenWithStatusResponse()
    //    {
    //    }

    //    public FindStraatnamenWithStatusResponse(WsCrabServiceReference.FindStraatnamenWithStatusResponseBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class FindStraatnamenWithStatusResponseBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 0)]
    //    public WsCrabServiceReference.StraatnaamWithStatusItem[] FindStraatnamenWithStatusResult;

    //    public FindStraatnamenWithStatusResponseBody()
    //    {
    //    }

    //    public FindStraatnamenWithStatusResponseBody(WsCrabServiceReference.StraatnaamWithStatusItem[] FindStraatnamenWithStatusResult)
    //    {
    //        this.FindStraatnamenWithStatusResult = FindStraatnamenWithStatusResult;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class FindSubadressenRequest
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "FindSubadressen", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.FindSubadressenRequestBody Body;

    //    public FindSubadressenRequest()
    //    {
    //    }

    //    public FindSubadressenRequest(WsCrabServiceReference.FindSubadressenRequestBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class FindSubadressenRequestBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
    //    public string Subadres;

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
    //    public int HuisnummerId;

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
    //    public int SorteerVeld;

    //    public FindSubadressenRequestBody()
    //    {
    //    }

    //    public FindSubadressenRequestBody(string Subadres, int HuisnummerId, int SorteerVeld)
    //    {
    //        this.Subadres = Subadres;
    //        this.HuisnummerId = HuisnummerId;
    //        this.SorteerVeld = SorteerVeld;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class FindSubadressenResponse
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "FindSubadressenResponse", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.FindSubadressenResponseBody Body;

    //    public FindSubadressenResponse()
    //    {
    //    }

    //    public FindSubadressenResponse(WsCrabServiceReference.FindSubadressenResponseBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class FindSubadressenResponseBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 0)]
    //    public WsCrabServiceReference.SubadresItem[] FindSubadressenResult;

    //    public FindSubadressenResponseBody()
    //    {
    //    }

    //    public FindSubadressenResponseBody(WsCrabServiceReference.SubadresItem[] FindSubadressenResult)
    //    {
    //        this.FindSubadressenResult = FindSubadressenResult;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class FindSubadressenWithStatusRequest
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "FindSubadressenWithStatus", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.FindSubadressenWithStatusRequestBody Body;

    //    public FindSubadressenWithStatusRequest()
    //    {
    //    }

    //    public FindSubadressenWithStatusRequest(WsCrabServiceReference.FindSubadressenWithStatusRequestBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class FindSubadressenWithStatusRequestBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
    //    public string Subadres;

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
    //    public int HuisnummerId;

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
    //    public int SorteerVeld;

    //    public FindSubadressenWithStatusRequestBody()
    //    {
    //    }

    //    public FindSubadressenWithStatusRequestBody(string Subadres, int HuisnummerId, int SorteerVeld)
    //    {
    //        this.Subadres = Subadres;
    //        this.HuisnummerId = HuisnummerId;
    //        this.SorteerVeld = SorteerVeld;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class FindSubadressenWithStatusResponse
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "FindSubadressenWithStatusResponse", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.FindSubadressenWithStatusResponseBody Body;

    //    public FindSubadressenWithStatusResponse()
    //    {
    //    }

    //    public FindSubadressenWithStatusResponse(WsCrabServiceReference.FindSubadressenWithStatusResponseBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class FindSubadressenWithStatusResponseBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 0)]
    //    public WsCrabServiceReference.SubadresWithStatusItem[] FindSubadressenWithStatusResult;

    //    public FindSubadressenWithStatusResponseBody()
    //    {
    //    }

    //    public FindSubadressenWithStatusResponseBody(WsCrabServiceReference.SubadresWithStatusItem[] FindSubadressenWithStatusResult)
    //    {
    //        this.FindSubadressenWithStatusResult = FindSubadressenWithStatusResult;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class GetGebouwByIdentificatorGebouwRequest
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "GetGebouwByIdentificatorGebouw", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.GetGebouwByIdentificatorGebouwRequestBody Body;

    //    public GetGebouwByIdentificatorGebouwRequest()
    //    {
    //    }

    //    public GetGebouwByIdentificatorGebouwRequest(WsCrabServiceReference.GetGebouwByIdentificatorGebouwRequestBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class GetGebouwByIdentificatorGebouwRequestBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
    //    public string IdentificatorGebouw;

    //    public GetGebouwByIdentificatorGebouwRequestBody()
    //    {
    //    }

    //    public GetGebouwByIdentificatorGebouwRequestBody(string IdentificatorGebouw)
    //    {
    //        this.IdentificatorGebouw = IdentificatorGebouw;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class GetGebouwByIdentificatorGebouwResponse
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "GetGebouwByIdentificatorGebouwResponse", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.GetGebouwByIdentificatorGebouwResponseBody Body;

    //    public GetGebouwByIdentificatorGebouwResponse()
    //    {
    //    }

    //    public GetGebouwByIdentificatorGebouwResponse(WsCrabServiceReference.GetGebouwByIdentificatorGebouwResponseBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class GetGebouwByIdentificatorGebouwResponseBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 0)]
    //    public WsCrabServiceReference.GebouwObject GetGebouwByIdentificatorGebouwResult;

    //    public GetGebouwByIdentificatorGebouwResponseBody()
    //    {
    //    }

    //    public GetGebouwByIdentificatorGebouwResponseBody(WsCrabServiceReference.GebouwObject GetGebouwByIdentificatorGebouwResult)
    //    {
    //        this.GetGebouwByIdentificatorGebouwResult = GetGebouwByIdentificatorGebouwResult;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class GetGemeenteByGemeenteNaamRequest
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "GetGemeenteByGemeenteNaam", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.GetGemeenteByGemeenteNaamRequestBody Body;

    //    public GetGemeenteByGemeenteNaamRequest()
    //    {
    //    }

    //    public GetGemeenteByGemeenteNaamRequest(WsCrabServiceReference.GetGemeenteByGemeenteNaamRequestBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class GetGemeenteByGemeenteNaamRequestBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
    //    public string GemeenteNaam;

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
    //    public int GewestId;

    //    public GetGemeenteByGemeenteNaamRequestBody()
    //    {
    //    }

    //    public GetGemeenteByGemeenteNaamRequestBody(string GemeenteNaam, int GewestId)
    //    {
    //        this.GemeenteNaam = GemeenteNaam;
    //        this.GewestId = GewestId;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class GetGemeenteByGemeenteNaamResponse
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "GetGemeenteByGemeenteNaamResponse", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.GetGemeenteByGemeenteNaamResponseBody Body;

    //    public GetGemeenteByGemeenteNaamResponse()
    //    {
    //    }

    //    public GetGemeenteByGemeenteNaamResponse(WsCrabServiceReference.GetGemeenteByGemeenteNaamResponseBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class GetGemeenteByGemeenteNaamResponseBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 0)]
    //    public WsCrabServiceReference.GemeenteObject GetGemeenteByGemeenteNaamResult;

    //    public GetGemeenteByGemeenteNaamResponseBody()
    //    {
    //    }

    //    public GetGemeenteByGemeenteNaamResponseBody(WsCrabServiceReference.GemeenteObject GetGemeenteByGemeenteNaamResult)
    //    {
    //        this.GetGemeenteByGemeenteNaamResult = GetGemeenteByGemeenteNaamResult;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class GetGewestByGewestIdAndTaalCodeRequest
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "GetGewestByGewestIdAndTaalCode", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.GetGewestByGewestIdAndTaalCodeRequestBody Body;

    //    public GetGewestByGewestIdAndTaalCodeRequest()
    //    {
    //    }

    //    public GetGewestByGewestIdAndTaalCodeRequest(WsCrabServiceReference.GetGewestByGewestIdAndTaalCodeRequestBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class GetGewestByGewestIdAndTaalCodeRequestBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 0)]
    //    public int GewestId;

    //    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 1)]
    //    public string TaalCode;

    //    public GetGewestByGewestIdAndTaalCodeRequestBody()
    //    {
    //    }

    //    public GetGewestByGewestIdAndTaalCodeRequestBody(int GewestId, string TaalCode)
    //    {
    //        this.GewestId = GewestId;
    //        this.TaalCode = TaalCode;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class GetGewestByGewestIdAndTaalCodeResponse
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "GetGewestByGewestIdAndTaalCodeResponse", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.GetGewestByGewestIdAndTaalCodeResponseBody Body;

    //    public GetGewestByGewestIdAndTaalCodeResponse()
    //    {
    //    }

    //    public GetGewestByGewestIdAndTaalCodeResponse(WsCrabServiceReference.GetGewestByGewestIdAndTaalCodeResponseBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class GetGewestByGewestIdAndTaalCodeResponseBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 0)]
    //    public WsCrabServiceReference.GewestObject GetGewestByGewestIdAndTaalCodeResult;

    //    public GetGewestByGewestIdAndTaalCodeResponseBody()
    //    {
    //    }

    //    public GetGewestByGewestIdAndTaalCodeResponseBody(WsCrabServiceReference.GewestObject GetGewestByGewestIdAndTaalCodeResult)
    //    {
    //        this.GetGewestByGewestIdAndTaalCodeResult = GetGewestByGewestIdAndTaalCodeResult;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class GetHuisnummerByHuisnummerRequest
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "GetHuisnummerByHuisnummer", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.GetHuisnummerByHuisnummerRequestBody Body;

    //    public GetHuisnummerByHuisnummerRequest()
    //    {
    //    }

    //    public GetHuisnummerByHuisnummerRequest(WsCrabServiceReference.GetHuisnummerByHuisnummerRequestBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class GetHuisnummerByHuisnummerRequestBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
    //    public string Huisnummer;

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
    //    public int StraatnaamId;

    //    public GetHuisnummerByHuisnummerRequestBody()
    //    {
    //    }

    //    public GetHuisnummerByHuisnummerRequestBody(string Huisnummer, int StraatnaamId)
    //    {
    //        this.Huisnummer = Huisnummer;
    //        this.StraatnaamId = StraatnaamId;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class GetHuisnummerByHuisnummerResponse
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "GetHuisnummerByHuisnummerResponse", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.GetHuisnummerByHuisnummerResponseBody Body;

    //    public GetHuisnummerByHuisnummerResponse()
    //    {
    //    }

    //    public GetHuisnummerByHuisnummerResponse(WsCrabServiceReference.GetHuisnummerByHuisnummerResponseBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class GetHuisnummerByHuisnummerResponseBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 0)]
    //    public WsCrabServiceReference.HuisnummerObject GetHuisnummerByHuisnummerResult;

    //    public GetHuisnummerByHuisnummerResponseBody()
    //    {
    //    }

    //    public GetHuisnummerByHuisnummerResponseBody(WsCrabServiceReference.HuisnummerObject GetHuisnummerByHuisnummerResult)
    //    {
    //        this.GetHuisnummerByHuisnummerResult = GetHuisnummerByHuisnummerResult;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class GetHuisnummerWithStatusByHuisnummerRequest
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "GetHuisnummerWithStatusByHuisnummer", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.GetHuisnummerWithStatusByHuisnummerRequestBody Body;

    //    public GetHuisnummerWithStatusByHuisnummerRequest()
    //    {
    //    }

    //    public GetHuisnummerWithStatusByHuisnummerRequest(WsCrabServiceReference.GetHuisnummerWithStatusByHuisnummerRequestBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class GetHuisnummerWithStatusByHuisnummerRequestBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
    //    public string Huisnummer;

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
    //    public int StraatnaamId;

    //    public GetHuisnummerWithStatusByHuisnummerRequestBody()
    //    {
    //    }

    //    public GetHuisnummerWithStatusByHuisnummerRequestBody(string Huisnummer, int StraatnaamId)
    //    {
    //        this.Huisnummer = Huisnummer;
    //        this.StraatnaamId = StraatnaamId;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class GetHuisnummerWithStatusByHuisnummerResponse
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "GetHuisnummerWithStatusByHuisnummerResponse", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.GetHuisnummerWithStatusByHuisnummerResponseBody Body;

    //    public GetHuisnummerWithStatusByHuisnummerResponse()
    //    {
    //    }

    //    public GetHuisnummerWithStatusByHuisnummerResponse(WsCrabServiceReference.GetHuisnummerWithStatusByHuisnummerResponseBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class GetHuisnummerWithStatusByHuisnummerResponseBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 0)]
    //    public WsCrabServiceReference.HuisnummerWithStatusObject GetHuisnummerWithStatusByHuisnummerResult;

    //    public GetHuisnummerWithStatusByHuisnummerResponseBody()
    //    {
    //    }

    //    public GetHuisnummerWithStatusByHuisnummerResponseBody(WsCrabServiceReference.HuisnummerWithStatusObject GetHuisnummerWithStatusByHuisnummerResult)
    //    {
    //        this.GetHuisnummerWithStatusByHuisnummerResult = GetHuisnummerWithStatusByHuisnummerResult;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class GetPerceelByIdentificatorPerceelRequest
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "GetPerceelByIdentificatorPerceel", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.GetPerceelByIdentificatorPerceelRequestBody Body;

    //    public GetPerceelByIdentificatorPerceelRequest()
    //    {
    //    }

    //    public GetPerceelByIdentificatorPerceelRequest(WsCrabServiceReference.GetPerceelByIdentificatorPerceelRequestBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class GetPerceelByIdentificatorPerceelRequestBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
    //    public string IdentificatorPerceel;

    //    public GetPerceelByIdentificatorPerceelRequestBody()
    //    {
    //    }

    //    public GetPerceelByIdentificatorPerceelRequestBody(string IdentificatorPerceel)
    //    {
    //        this.IdentificatorPerceel = IdentificatorPerceel;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class GetPerceelByIdentificatorPerceelResponse
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "GetPerceelByIdentificatorPerceelResponse", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.GetPerceelByIdentificatorPerceelResponseBody Body;

    //    public GetPerceelByIdentificatorPerceelResponse()
    //    {
    //    }

    //    public GetPerceelByIdentificatorPerceelResponse(WsCrabServiceReference.GetPerceelByIdentificatorPerceelResponseBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class GetPerceelByIdentificatorPerceelResponseBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 0)]
    //    public WsCrabServiceReference.PerceelObject GetPerceelByIdentificatorPerceelResult;

    //    public GetPerceelByIdentificatorPerceelResponseBody()
    //    {
    //    }

    //    public GetPerceelByIdentificatorPerceelResponseBody(WsCrabServiceReference.PerceelObject GetPerceelByIdentificatorPerceelResult)
    //    {
    //        this.GetPerceelByIdentificatorPerceelResult = GetPerceelByIdentificatorPerceelResult;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class GetStraatnaamByStraatnaamRequest
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "GetStraatnaamByStraatnaam", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.GetStraatnaamByStraatnaamRequestBody Body;

    //    public GetStraatnaamByStraatnaamRequest()
    //    {
    //    }

    //    public GetStraatnaamByStraatnaamRequest(WsCrabServiceReference.GetStraatnaamByStraatnaamRequestBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class GetStraatnaamByStraatnaamRequestBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
    //    public string Straatnaam;

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
    //    public int GemeenteId;

    //    public GetStraatnaamByStraatnaamRequestBody()
    //    {
    //    }

    //    public GetStraatnaamByStraatnaamRequestBody(string Straatnaam, int GemeenteId)
    //    {
    //        this.Straatnaam = Straatnaam;
    //        this.GemeenteId = GemeenteId;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class GetStraatnaamByStraatnaamResponse
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "GetStraatnaamByStraatnaamResponse", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.GetStraatnaamByStraatnaamResponseBody Body;

    //    public GetStraatnaamByStraatnaamResponse()
    //    {
    //    }

    //    public GetStraatnaamByStraatnaamResponse(WsCrabServiceReference.GetStraatnaamByStraatnaamResponseBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class GetStraatnaamByStraatnaamResponseBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 0)]
    //    public WsCrabServiceReference.StraatnaamObject GetStraatnaamByStraatnaamResult;

    //    public GetStraatnaamByStraatnaamResponseBody()
    //    {
    //    }

    //    public GetStraatnaamByStraatnaamResponseBody(WsCrabServiceReference.StraatnaamObject GetStraatnaamByStraatnaamResult)
    //    {
    //        this.GetStraatnaamByStraatnaamResult = GetStraatnaamByStraatnaamResult;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class GetStraatnaamWithStatusByStraatnaamRequest
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "GetStraatnaamWithStatusByStraatnaam", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.GetStraatnaamWithStatusByStraatnaamRequestBody Body;

    //    public GetStraatnaamWithStatusByStraatnaamRequest()
    //    {
    //    }

    //    public GetStraatnaamWithStatusByStraatnaamRequest(WsCrabServiceReference.GetStraatnaamWithStatusByStraatnaamRequestBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class GetStraatnaamWithStatusByStraatnaamRequestBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
    //    public string Straatnaam;

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
    //    public int GemeenteId;

    //    public GetStraatnaamWithStatusByStraatnaamRequestBody()
    //    {
    //    }

    //    public GetStraatnaamWithStatusByStraatnaamRequestBody(string Straatnaam, int GemeenteId)
    //    {
    //        this.Straatnaam = Straatnaam;
    //        this.GemeenteId = GemeenteId;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class GetStraatnaamWithStatusByStraatnaamResponse
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "GetStraatnaamWithStatusByStraatnaamResponse", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.GetStraatnaamWithStatusByStraatnaamResponseBody Body;

    //    public GetStraatnaamWithStatusByStraatnaamResponse()
    //    {
    //    }

    //    public GetStraatnaamWithStatusByStraatnaamResponse(WsCrabServiceReference.GetStraatnaamWithStatusByStraatnaamResponseBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class GetStraatnaamWithStatusByStraatnaamResponseBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 0)]
    //    public WsCrabServiceReference.StraatnaamWithStatusObject GetStraatnaamWithStatusByStraatnaamResult;

    //    public GetStraatnaamWithStatusByStraatnaamResponseBody()
    //    {
    //    }

    //    public GetStraatnaamWithStatusByStraatnaamResponseBody(WsCrabServiceReference.StraatnaamWithStatusObject GetStraatnaamWithStatusByStraatnaamResult)
    //    {
    //        this.GetStraatnaamWithStatusByStraatnaamResult = GetStraatnaamWithStatusByStraatnaamResult;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class GetTerreinobjectByIdentificatorTerreinobjectRequest
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "GetTerreinobjectByIdentificatorTerreinobject", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.GetTerreinobjectByIdentificatorTerreinobjectRequestBody Body;

    //    public GetTerreinobjectByIdentificatorTerreinobjectRequest()
    //    {
    //    }

    //    public GetTerreinobjectByIdentificatorTerreinobjectRequest(WsCrabServiceReference.GetTerreinobjectByIdentificatorTerreinobjectRequestBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class GetTerreinobjectByIdentificatorTerreinobjectRequestBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
    //    public string IdentificatorTerreinobject;

    //    public GetTerreinobjectByIdentificatorTerreinobjectRequestBody()
    //    {
    //    }

    //    public GetTerreinobjectByIdentificatorTerreinobjectRequestBody(string IdentificatorTerreinobject)
    //    {
    //        this.IdentificatorTerreinobject = IdentificatorTerreinobject;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class GetTerreinobjectByIdentificatorTerreinobjectResponse
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "GetTerreinobjectByIdentificatorTerreinobjectResponse", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.GetTerreinobjectByIdentificatorTerreinobjectResponseBody Body;

    //    public GetTerreinobjectByIdentificatorTerreinobjectResponse()
    //    {
    //    }

    //    public GetTerreinobjectByIdentificatorTerreinobjectResponse(WsCrabServiceReference.GetTerreinobjectByIdentificatorTerreinobjectResponseBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class GetTerreinobjectByIdentificatorTerreinobjectResponseBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 0)]
    //    public WsCrabServiceReference.TerreinobjectObject GetTerreinobjectByIdentificatorTerreinobjectResult;

    //    public GetTerreinobjectByIdentificatorTerreinobjectResponseBody()
    //    {
    //    }

    //    public GetTerreinobjectByIdentificatorTerreinobjectResponseBody(WsCrabServiceReference.TerreinobjectObject GetTerreinobjectByIdentificatorTerreinobjectResult)
    //    {
    //        this.GetTerreinobjectByIdentificatorTerreinobjectResult = GetTerreinobjectByIdentificatorTerreinobjectResult;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class GetWegobjectByIdentificatorWegobjectRequest
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "GetWegobjectByIdentificatorWegobject", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.GetWegobjectByIdentificatorWegobjectRequestBody Body;

    //    public GetWegobjectByIdentificatorWegobjectRequest()
    //    {
    //    }

    //    public GetWegobjectByIdentificatorWegobjectRequest(WsCrabServiceReference.GetWegobjectByIdentificatorWegobjectRequestBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class GetWegobjectByIdentificatorWegobjectRequestBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
    //    public string IdentificatorWegobject;

    //    public GetWegobjectByIdentificatorWegobjectRequestBody()
    //    {
    //    }

    //    public GetWegobjectByIdentificatorWegobjectRequestBody(string IdentificatorWegobject)
    //    {
    //        this.IdentificatorWegobject = IdentificatorWegobject;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class GetWegobjectByIdentificatorWegobjectResponse
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "GetWegobjectByIdentificatorWegobjectResponse", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.GetWegobjectByIdentificatorWegobjectResponseBody Body;

    //    public GetWegobjectByIdentificatorWegobjectResponse()
    //    {
    //    }

    //    public GetWegobjectByIdentificatorWegobjectResponse(WsCrabServiceReference.GetWegobjectByIdentificatorWegobjectResponseBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class GetWegobjectByIdentificatorWegobjectResponseBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 0)]
    //    public WsCrabServiceReference.WegobjectObject GetWegobjectByIdentificatorWegobjectResult;

    //    public GetWegobjectByIdentificatorWegobjectResponseBody()
    //    {
    //    }

    //    public GetWegobjectByIdentificatorWegobjectResponseBody(WsCrabServiceReference.WegobjectObject GetWegobjectByIdentificatorWegobjectResult)
    //    {
    //        this.GetWegobjectByIdentificatorWegobjectResult = GetWegobjectByIdentificatorWegobjectResult;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class GetWegsegmentByIdentificatorWegsegmentRequest
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "GetWegsegmentByIdentificatorWegsegment", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.GetWegsegmentByIdentificatorWegsegmentRequestBody Body;

    //    public GetWegsegmentByIdentificatorWegsegmentRequest()
    //    {
    //    }

    //    public GetWegsegmentByIdentificatorWegsegmentRequest(WsCrabServiceReference.GetWegsegmentByIdentificatorWegsegmentRequestBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class GetWegsegmentByIdentificatorWegsegmentRequestBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
    //    public string IdentificatorWegsegment;

    //    public GetWegsegmentByIdentificatorWegsegmentRequestBody()
    //    {
    //    }

    //    public GetWegsegmentByIdentificatorWegsegmentRequestBody(string IdentificatorWegsegment)
    //    {
    //        this.IdentificatorWegsegment = IdentificatorWegsegment;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class GetWegsegmentByIdentificatorWegsegmentResponse
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "GetWegsegmentByIdentificatorWegsegmentResponse", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.GetWegsegmentByIdentificatorWegsegmentResponseBody Body;

    //    public GetWegsegmentByIdentificatorWegsegmentResponse()
    //    {
    //    }

    //    public GetWegsegmentByIdentificatorWegsegmentResponse(WsCrabServiceReference.GetWegsegmentByIdentificatorWegsegmentResponseBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class GetWegsegmentByIdentificatorWegsegmentResponseBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 0)]
    //    public WsCrabServiceReference.WegsegmentObject GetWegsegmentByIdentificatorWegsegmentResult;

    //    public GetWegsegmentByIdentificatorWegsegmentResponseBody()
    //    {
    //    }

    //    public GetWegsegmentByIdentificatorWegsegmentResponseBody(WsCrabServiceReference.WegsegmentObject GetWegsegmentByIdentificatorWegsegmentResult)
    //    {
    //        this.GetWegsegmentByIdentificatorWegsegmentResult = GetWegsegmentByIdentificatorWegsegmentResult;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class ListAdrespositiesByHuisnummerRequest
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "ListAdrespositiesByHuisnummer", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.ListAdrespositiesByHuisnummerRequestBody Body;

    //    public ListAdrespositiesByHuisnummerRequest()
    //    {
    //    }

    //    public ListAdrespositiesByHuisnummerRequest(WsCrabServiceReference.ListAdrespositiesByHuisnummerRequestBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class ListAdrespositiesByHuisnummerRequestBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
    //    public string Huisnummer;

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
    //    public int StraatnaamId;

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
    //    public int SorteerVeld;

    //    public ListAdrespositiesByHuisnummerRequestBody()
    //    {
    //    }

    //    public ListAdrespositiesByHuisnummerRequestBody(string Huisnummer, int StraatnaamId, int SorteerVeld)
    //    {
    //        this.Huisnummer = Huisnummer;
    //        this.StraatnaamId = StraatnaamId;
    //        this.SorteerVeld = SorteerVeld;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class ListAdrespositiesByHuisnummerResponse
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "ListAdrespositiesByHuisnummerResponse", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.ListAdrespositiesByHuisnummerResponseBody Body;

    //    public ListAdrespositiesByHuisnummerResponse()
    //    {
    //    }

    //    public ListAdrespositiesByHuisnummerResponse(WsCrabServiceReference.ListAdrespositiesByHuisnummerResponseBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class ListAdrespositiesByHuisnummerResponseBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 0)]
    //    public WsCrabServiceReference.AdrespositieItem[] ListAdrespositiesByHuisnummerResult;

    //    public ListAdrespositiesByHuisnummerResponseBody()
    //    {
    //    }

    //    public ListAdrespositiesByHuisnummerResponseBody(WsCrabServiceReference.AdrespositieItem[] ListAdrespositiesByHuisnummerResult)
    //    {
    //        this.ListAdrespositiesByHuisnummerResult = ListAdrespositiesByHuisnummerResult;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class ListAdrespositiesBySubadresRequest
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "ListAdrespositiesBySubadres", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.ListAdrespositiesBySubadresRequestBody Body;

    //    public ListAdrespositiesBySubadresRequest()
    //    {
    //    }

    //    public ListAdrespositiesBySubadresRequest(WsCrabServiceReference.ListAdrespositiesBySubadresRequestBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class ListAdrespositiesBySubadresRequestBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
    //    public string Subadres;

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
    //    public int HuisnummerId;

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
    //    public int SorteerVeld;

    //    public ListAdrespositiesBySubadresRequestBody()
    //    {
    //    }

    //    public ListAdrespositiesBySubadresRequestBody(string Subadres, int HuisnummerId, int SorteerVeld)
    //    {
    //        this.Subadres = Subadres;
    //        this.HuisnummerId = HuisnummerId;
    //        this.SorteerVeld = SorteerVeld;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class ListAdrespositiesBySubadresResponse
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "ListAdrespositiesBySubadresResponse", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.ListAdrespositiesBySubadresResponseBody Body;

    //    public ListAdrespositiesBySubadresResponse()
    //    {
    //    }

    //    public ListAdrespositiesBySubadresResponse(WsCrabServiceReference.ListAdrespositiesBySubadresResponseBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class ListAdrespositiesBySubadresResponseBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 0)]
    //    public WsCrabServiceReference.AdrespositieItem[] ListAdrespositiesBySubadresResult;

    //    public ListAdrespositiesBySubadresResponseBody()
    //    {
    //    }

    //    public ListAdrespositiesBySubadresResponseBody(WsCrabServiceReference.AdrespositieItem[] ListAdrespositiesBySubadresResult)
    //    {
    //        this.ListAdrespositiesBySubadresResult = ListAdrespositiesBySubadresResult;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class ListGebouwenByHuisnummerRequest
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "ListGebouwenByHuisnummer", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.ListGebouwenByHuisnummerRequestBody Body;

    //    public ListGebouwenByHuisnummerRequest()
    //    {
    //    }

    //    public ListGebouwenByHuisnummerRequest(WsCrabServiceReference.ListGebouwenByHuisnummerRequestBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class ListGebouwenByHuisnummerRequestBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
    //    public string Huisnummer;

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
    //    public int StraatnaamId;

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
    //    public int SorteerVeld;

    //    public ListGebouwenByHuisnummerRequestBody()
    //    {
    //    }

    //    public ListGebouwenByHuisnummerRequestBody(string Huisnummer, int StraatnaamId, int SorteerVeld)
    //    {
    //        this.Huisnummer = Huisnummer;
    //        this.StraatnaamId = StraatnaamId;
    //        this.SorteerVeld = SorteerVeld;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class ListGebouwenByHuisnummerResponse
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "ListGebouwenByHuisnummerResponse", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.ListGebouwenByHuisnummerResponseBody Body;

    //    public ListGebouwenByHuisnummerResponse()
    //    {
    //    }

    //    public ListGebouwenByHuisnummerResponse(WsCrabServiceReference.ListGebouwenByHuisnummerResponseBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class ListGebouwenByHuisnummerResponseBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 0)]
    //    public WsCrabServiceReference.GebouwItem[] ListGebouwenByHuisnummerResult;

    //    public ListGebouwenByHuisnummerResponseBody()
    //    {
    //    }

    //    public ListGebouwenByHuisnummerResponseBody(WsCrabServiceReference.GebouwItem[] ListGebouwenByHuisnummerResult)
    //    {
    //        this.ListGebouwenByHuisnummerResult = ListGebouwenByHuisnummerResult;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class ListHuisnummersByIdentificatorTerreinobjectRequest
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "ListHuisnummersByIdentificatorTerreinobject", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.ListHuisnummersByIdentificatorTerreinobjectRequestBody Body;

    //    public ListHuisnummersByIdentificatorTerreinobjectRequest()
    //    {
    //    }

    //    public ListHuisnummersByIdentificatorTerreinobjectRequest(WsCrabServiceReference.ListHuisnummersByIdentificatorTerreinobjectRequestBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class ListHuisnummersByIdentificatorTerreinobjectRequestBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
    //    public string IdentificatorTerreinobject;

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
    //    public int SorteerVeld;

    //    public ListHuisnummersByIdentificatorTerreinobjectRequestBody()
    //    {
    //    }

    //    public ListHuisnummersByIdentificatorTerreinobjectRequestBody(string IdentificatorTerreinobject, int SorteerVeld)
    //    {
    //        this.IdentificatorTerreinobject = IdentificatorTerreinobject;
    //        this.SorteerVeld = SorteerVeld;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class ListHuisnummersByIdentificatorTerreinobjectResponse
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "ListHuisnummersByIdentificatorTerreinobjectResponse", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.ListHuisnummersByIdentificatorTerreinobjectResponseBody Body;

    //    public ListHuisnummersByIdentificatorTerreinobjectResponse()
    //    {
    //    }

    //    public ListHuisnummersByIdentificatorTerreinobjectResponse(WsCrabServiceReference.ListHuisnummersByIdentificatorTerreinobjectResponseBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class ListHuisnummersByIdentificatorTerreinobjectResponseBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 0)]
    //    public WsCrabServiceReference.HuisnummerItem[] ListHuisnummersByIdentificatorTerreinobjectResult;

    //    public ListHuisnummersByIdentificatorTerreinobjectResponseBody()
    //    {
    //    }

    //    public ListHuisnummersByIdentificatorTerreinobjectResponseBody(WsCrabServiceReference.HuisnummerItem[] ListHuisnummersByIdentificatorTerreinobjectResult)
    //    {
    //        this.ListHuisnummersByIdentificatorTerreinobjectResult = ListHuisnummersByIdentificatorTerreinobjectResult;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class ListHuisnummersWithStatusByIdentificatorGebouwRequest
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "ListHuisnummersWithStatusByIdentificatorGebouw", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.ListHuisnummersWithStatusByIdentificatorGebouwRequestBody Body;

    //    public ListHuisnummersWithStatusByIdentificatorGebouwRequest()
    //    {
    //    }

    //    public ListHuisnummersWithStatusByIdentificatorGebouwRequest(WsCrabServiceReference.ListHuisnummersWithStatusByIdentificatorGebouwRequestBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class ListHuisnummersWithStatusByIdentificatorGebouwRequestBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
    //    public string IdentificatorGebouw;

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
    //    public int SorteerVeld;

    //    public ListHuisnummersWithStatusByIdentificatorGebouwRequestBody()
    //    {
    //    }

    //    public ListHuisnummersWithStatusByIdentificatorGebouwRequestBody(string IdentificatorGebouw, int SorteerVeld)
    //    {
    //        this.IdentificatorGebouw = IdentificatorGebouw;
    //        this.SorteerVeld = SorteerVeld;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class ListHuisnummersWithStatusByIdentificatorGebouwResponse
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "ListHuisnummersWithStatusByIdentificatorGebouwResponse", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.ListHuisnummersWithStatusByIdentificatorGebouwResponseBody Body;

    //    public ListHuisnummersWithStatusByIdentificatorGebouwResponse()
    //    {
    //    }

    //    public ListHuisnummersWithStatusByIdentificatorGebouwResponse(WsCrabServiceReference.ListHuisnummersWithStatusByIdentificatorGebouwResponseBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class ListHuisnummersWithStatusByIdentificatorGebouwResponseBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 0)]
    //    public WsCrabServiceReference.HuisnummerWithStatusItem[] ListHuisnummersWithStatusByIdentificatorGebouwResult;

    //    public ListHuisnummersWithStatusByIdentificatorGebouwResponseBody()
    //    {
    //    }

    //    public ListHuisnummersWithStatusByIdentificatorGebouwResponseBody(WsCrabServiceReference.HuisnummerWithStatusItem[] ListHuisnummersWithStatusByIdentificatorGebouwResult)
    //    {
    //        this.ListHuisnummersWithStatusByIdentificatorGebouwResult = ListHuisnummersWithStatusByIdentificatorGebouwResult;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class ListHuisnummersWithStatusByIdentificatorPerceelRequest
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "ListHuisnummersWithStatusByIdentificatorPerceel", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.ListHuisnummersWithStatusByIdentificatorPerceelRequestBody Body;

    //    public ListHuisnummersWithStatusByIdentificatorPerceelRequest()
    //    {
    //    }

    //    public ListHuisnummersWithStatusByIdentificatorPerceelRequest(WsCrabServiceReference.ListHuisnummersWithStatusByIdentificatorPerceelRequestBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class ListHuisnummersWithStatusByIdentificatorPerceelRequestBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
    //    public string IdentificatorPerceel;

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
    //    public int SorteerVeld;

    //    public ListHuisnummersWithStatusByIdentificatorPerceelRequestBody()
    //    {
    //    }

    //    public ListHuisnummersWithStatusByIdentificatorPerceelRequestBody(string IdentificatorPerceel, int SorteerVeld)
    //    {
    //        this.IdentificatorPerceel = IdentificatorPerceel;
    //        this.SorteerVeld = SorteerVeld;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class ListHuisnummersWithStatusByIdentificatorPerceelResponse
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "ListHuisnummersWithStatusByIdentificatorPerceelResponse", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.ListHuisnummersWithStatusByIdentificatorPerceelResponseBody Body;

    //    public ListHuisnummersWithStatusByIdentificatorPerceelResponse()
    //    {
    //    }

    //    public ListHuisnummersWithStatusByIdentificatorPerceelResponse(WsCrabServiceReference.ListHuisnummersWithStatusByIdentificatorPerceelResponseBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class ListHuisnummersWithStatusByIdentificatorPerceelResponseBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 0)]
    //    public WsCrabServiceReference.HuisnummerWithStatusItem[] ListHuisnummersWithStatusByIdentificatorPerceelResult;

    //    public ListHuisnummersWithStatusByIdentificatorPerceelResponseBody()
    //    {
    //    }

    //    public ListHuisnummersWithStatusByIdentificatorPerceelResponseBody(WsCrabServiceReference.HuisnummerWithStatusItem[] ListHuisnummersWithStatusByIdentificatorPerceelResult)
    //    {
    //        this.ListHuisnummersWithStatusByIdentificatorPerceelResult = ListHuisnummersWithStatusByIdentificatorPerceelResult;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class ListHuisnummersWithStatusByIdentificatorTerreinobjectRequest
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "ListHuisnummersWithStatusByIdentificatorTerreinobject", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.ListHuisnummersWithStatusByIdentificatorTerreinobjectRequestBody Body;

    //    public ListHuisnummersWithStatusByIdentificatorTerreinobjectRequest()
    //    {
    //    }

    //    public ListHuisnummersWithStatusByIdentificatorTerreinobjectRequest(WsCrabServiceReference.ListHuisnummersWithStatusByIdentificatorTerreinobjectRequestBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class ListHuisnummersWithStatusByIdentificatorTerreinobjectRequestBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
    //    public string IdentificatorTerreinobject;

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
    //    public int SorteerVeld;

    //    public ListHuisnummersWithStatusByIdentificatorTerreinobjectRequestBody()
    //    {
    //    }

    //    public ListHuisnummersWithStatusByIdentificatorTerreinobjectRequestBody(string IdentificatorTerreinobject, int SorteerVeld)
    //    {
    //        this.IdentificatorTerreinobject = IdentificatorTerreinobject;
    //        this.SorteerVeld = SorteerVeld;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class ListHuisnummersWithStatusByIdentificatorTerreinobjectResponse
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "ListHuisnummersWithStatusByIdentificatorTerreinobjectResponse", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.ListHuisnummersWithStatusByIdentificatorTerreinobjectResponseBody Body;

    //    public ListHuisnummersWithStatusByIdentificatorTerreinobjectResponse()
    //    {
    //    }

    //    public ListHuisnummersWithStatusByIdentificatorTerreinobjectResponse(WsCrabServiceReference.ListHuisnummersWithStatusByIdentificatorTerreinobjectResponseBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class ListHuisnummersWithStatusByIdentificatorTerreinobjectResponseBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 0)]
    //    public WsCrabServiceReference.HuisnummerWithStatusItem[] ListHuisnummersWithStatusByIdentificatorTerreinobjectResult;

    //    public ListHuisnummersWithStatusByIdentificatorTerreinobjectResponseBody()
    //    {
    //    }

    //    public ListHuisnummersWithStatusByIdentificatorTerreinobjectResponseBody(WsCrabServiceReference.HuisnummerWithStatusItem[] ListHuisnummersWithStatusByIdentificatorTerreinobjectResult)
    //    {
    //        this.ListHuisnummersWithStatusByIdentificatorTerreinobjectResult = ListHuisnummersWithStatusByIdentificatorTerreinobjectResult;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class ListPercelenByHuisnummerRequest
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "ListPercelenByHuisnummer", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.ListPercelenByHuisnummerRequestBody Body;

    //    public ListPercelenByHuisnummerRequest()
    //    {
    //    }

    //    public ListPercelenByHuisnummerRequest(WsCrabServiceReference.ListPercelenByHuisnummerRequestBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class ListPercelenByHuisnummerRequestBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
    //    public string Huisnummer;

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
    //    public int StraatnaamId;

    //    public ListPercelenByHuisnummerRequestBody()
    //    {
    //    }

    //    public ListPercelenByHuisnummerRequestBody(string Huisnummer, int StraatnaamId)
    //    {
    //        this.Huisnummer = Huisnummer;
    //        this.StraatnaamId = StraatnaamId;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class ListPercelenByHuisnummerResponse
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "ListPercelenByHuisnummerResponse", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.ListPercelenByHuisnummerResponseBody Body;

    //    public ListPercelenByHuisnummerResponse()
    //    {
    //    }

    //    public ListPercelenByHuisnummerResponse(WsCrabServiceReference.ListPercelenByHuisnummerResponseBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class ListPercelenByHuisnummerResponseBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 0)]
    //    public WsCrabServiceReference.PerceelItem[] ListPercelenByHuisnummerResult;

    //    public ListPercelenByHuisnummerResponseBody()
    //    {
    //    }

    //    public ListPercelenByHuisnummerResponseBody(WsCrabServiceReference.PerceelItem[] ListPercelenByHuisnummerResult)
    //    {
    //        this.ListPercelenByHuisnummerResult = ListPercelenByHuisnummerResult;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class ListRijksregisterAdresByHuisnummerRequest
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "ListRijksregisterAdresByHuisnummer", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.ListRijksregisterAdresByHuisnummerRequestBody Body;

    //    public ListRijksregisterAdresByHuisnummerRequest()
    //    {
    //    }

    //    public ListRijksregisterAdresByHuisnummerRequest(WsCrabServiceReference.ListRijksregisterAdresByHuisnummerRequestBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class ListRijksregisterAdresByHuisnummerRequestBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
    //    public string Huisnummer;

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
    //    public int StraatnaamId;

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
    //    public int SorteerVeld;

    //    public ListRijksregisterAdresByHuisnummerRequestBody()
    //    {
    //    }

    //    public ListRijksregisterAdresByHuisnummerRequestBody(string Huisnummer, int StraatnaamId, int SorteerVeld)
    //    {
    //        this.Huisnummer = Huisnummer;
    //        this.StraatnaamId = StraatnaamId;
    //        this.SorteerVeld = SorteerVeld;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class ListRijksregisterAdresByHuisnummerResponse
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "ListRijksregisterAdresByHuisnummerResponse", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.ListRijksregisterAdresByHuisnummerResponseBody Body;

    //    public ListRijksregisterAdresByHuisnummerResponse()
    //    {
    //    }

    //    public ListRijksregisterAdresByHuisnummerResponse(WsCrabServiceReference.ListRijksregisterAdresByHuisnummerResponseBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class ListRijksregisterAdresByHuisnummerResponseBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 0)]
    //    public WsCrabServiceReference.RijksregisterAdresItem[] ListRijksregisterAdresByHuisnummerResult;

    //    public ListRijksregisterAdresByHuisnummerResponseBody()
    //    {
    //    }

    //    public ListRijksregisterAdresByHuisnummerResponseBody(WsCrabServiceReference.RijksregisterAdresItem[] ListRijksregisterAdresByHuisnummerResult)
    //    {
    //        this.ListRijksregisterAdresByHuisnummerResult = ListRijksregisterAdresByHuisnummerResult;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class ListStraatnamenByIdentificatorWegobjectRequest
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "ListStraatnamenByIdentificatorWegobject", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.ListStraatnamenByIdentificatorWegobjectRequestBody Body;

    //    public ListStraatnamenByIdentificatorWegobjectRequest()
    //    {
    //    }

    //    public ListStraatnamenByIdentificatorWegobjectRequest(WsCrabServiceReference.ListStraatnamenByIdentificatorWegobjectRequestBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class ListStraatnamenByIdentificatorWegobjectRequestBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
    //    public string IdentificatorWegobject;

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
    //    public int SorteerVeld;

    //    public ListStraatnamenByIdentificatorWegobjectRequestBody()
    //    {
    //    }

    //    public ListStraatnamenByIdentificatorWegobjectRequestBody(string IdentificatorWegobject, int SorteerVeld)
    //    {
    //        this.IdentificatorWegobject = IdentificatorWegobject;
    //        this.SorteerVeld = SorteerVeld;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class ListStraatnamenByIdentificatorWegobjectResponse
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "ListStraatnamenByIdentificatorWegobjectResponse", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.ListStraatnamenByIdentificatorWegobjectResponseBody Body;

    //    public ListStraatnamenByIdentificatorWegobjectResponse()
    //    {
    //    }

    //    public ListStraatnamenByIdentificatorWegobjectResponse(WsCrabServiceReference.ListStraatnamenByIdentificatorWegobjectResponseBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class ListStraatnamenByIdentificatorWegobjectResponseBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 0)]
    //    public WsCrabServiceReference.StraatnaamItem[] ListStraatnamenByIdentificatorWegobjectResult;

    //    public ListStraatnamenByIdentificatorWegobjectResponseBody()
    //    {
    //    }

    //    public ListStraatnamenByIdentificatorWegobjectResponseBody(WsCrabServiceReference.StraatnaamItem[] ListStraatnamenByIdentificatorWegobjectResult)
    //    {
    //        this.ListStraatnamenByIdentificatorWegobjectResult = ListStraatnamenByIdentificatorWegobjectResult;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class ListStraatnamenWithStatusByIdentificatorWegobjectRequest
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "ListStraatnamenWithStatusByIdentificatorWegobject", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.ListStraatnamenWithStatusByIdentificatorWegobjectRequestBody Body;

    //    public ListStraatnamenWithStatusByIdentificatorWegobjectRequest()
    //    {
    //    }

    //    public ListStraatnamenWithStatusByIdentificatorWegobjectRequest(WsCrabServiceReference.ListStraatnamenWithStatusByIdentificatorWegobjectRequestBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class ListStraatnamenWithStatusByIdentificatorWegobjectRequestBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
    //    public string IdentificatorWegobject;

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
    //    public int SorteerVeld;

    //    public ListStraatnamenWithStatusByIdentificatorWegobjectRequestBody()
    //    {
    //    }

    //    public ListStraatnamenWithStatusByIdentificatorWegobjectRequestBody(string IdentificatorWegobject, int SorteerVeld)
    //    {
    //        this.IdentificatorWegobject = IdentificatorWegobject;
    //        this.SorteerVeld = SorteerVeld;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class ListStraatnamenWithStatusByIdentificatorWegobjectResponse
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "ListStraatnamenWithStatusByIdentificatorWegobjectResponse", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.ListStraatnamenWithStatusByIdentificatorWegobjectResponseBody Body;

    //    public ListStraatnamenWithStatusByIdentificatorWegobjectResponse()
    //    {
    //    }

    //    public ListStraatnamenWithStatusByIdentificatorWegobjectResponse(WsCrabServiceReference.ListStraatnamenWithStatusByIdentificatorWegobjectResponseBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class ListStraatnamenWithStatusByIdentificatorWegobjectResponseBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 0)]
    //    public WsCrabServiceReference.StraatnaamWithStatusItem[] ListStraatnamenWithStatusByIdentificatorWegobjectResult;

    //    public ListStraatnamenWithStatusByIdentificatorWegobjectResponseBody()
    //    {
    //    }

    //    public ListStraatnamenWithStatusByIdentificatorWegobjectResponseBody(WsCrabServiceReference.StraatnaamWithStatusItem[] ListStraatnamenWithStatusByIdentificatorWegobjectResult)
    //    {
    //        this.ListStraatnamenWithStatusByIdentificatorWegobjectResult = ListStraatnamenWithStatusByIdentificatorWegobjectResult;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class ListStraatnamenWithStatusByIdentificatorWegsegmentRequest
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "ListStraatnamenWithStatusByIdentificatorWegsegment", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.ListStraatnamenWithStatusByIdentificatorWegsegmentRequestBody Body;

    //    public ListStraatnamenWithStatusByIdentificatorWegsegmentRequest()
    //    {
    //    }

    //    public ListStraatnamenWithStatusByIdentificatorWegsegmentRequest(WsCrabServiceReference.ListStraatnamenWithStatusByIdentificatorWegsegmentRequestBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class ListStraatnamenWithStatusByIdentificatorWegsegmentRequestBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
    //    public string IdentificatorWegsegment;

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
    //    public int SorteerVeld;

    //    public ListStraatnamenWithStatusByIdentificatorWegsegmentRequestBody()
    //    {
    //    }

    //    public ListStraatnamenWithStatusByIdentificatorWegsegmentRequestBody(string IdentificatorWegsegment, int SorteerVeld)
    //    {
    //        this.IdentificatorWegsegment = IdentificatorWegsegment;
    //        this.SorteerVeld = SorteerVeld;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    //public class ListStraatnamenWithStatusByIdentificatorWegsegmentResponse
    //{

    //    [System.ServiceModel.MessageBodyMemberAttribute(Name = "ListStraatnamenWithStatusByIdentificatorWegsegmentResponse", Namespace = "http://ws.agiv.be/crabws", Order = 0)]
    //    public WsCrabServiceReference.ListStraatnamenWithStatusByIdentificatorWegsegmentResponseBody Body;

    //    public ListStraatnamenWithStatusByIdentificatorWegsegmentResponse()
    //    {
    //    }

    //    public ListStraatnamenWithStatusByIdentificatorWegsegmentResponse(WsCrabServiceReference.ListStraatnamenWithStatusByIdentificatorWegsegmentResponseBody Body)
    //    {
    //        this.Body = Body;
    //    }
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.Runtime.Serialization.DataContractAttribute(Namespace = "http://ws.agiv.be/crabws")]
    //public class ListStraatnamenWithStatusByIdentificatorWegsegmentResponseBody
    //{

    //    [System.Runtime.Serialization.DataMemberAttribute(Order = 0)]
    //    public WsCrabServiceReference.StraatnaamWithStatusItem[] ListStraatnamenWithStatusByIdentificatorWegsegmentResult;

    //    public ListStraatnamenWithStatusByIdentificatorWegsegmentResponseBody()
    //    {
    //    }

    //    public ListStraatnamenWithStatusByIdentificatorWegsegmentResponseBody(WsCrabServiceReference.StraatnaamWithStatusItem[] ListStraatnamenWithStatusByIdentificatorWegsegmentResult)
    //    {
    //        this.ListStraatnamenWithStatusByIdentificatorWegsegmentResult = ListStraatnamenWithStatusByIdentificatorWegsegmentResult;
    //    }
    //}

    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //public interface IWsCrabChannel : WsCrabServiceReference.IWsCrab, System.ServiceModel.IClientChannel
    //{
    //}

    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.2.0.0")]
    //public class WsCrabClient : System.ServiceModel.ClientBase<WsCrabServiceReference.IWsCrab>, WsCrabServiceReference.IWsCrab
    //{

    //    /// <summary>
    //    /// Implement this partial method to configure the service endpoint.
    //    /// </summary>
    //    /// <param name="serviceEndpoint">The endpoint to configure</param>
    //    /// <param name="clientCredentials">The client credentials</param>
    //    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);

    //    public WsCrabClient() :
    //            base(WsCrabClient.GetDefaultBinding(), WsCrabClient.GetDefaultEndpointAddress())
    //    {
    //        this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IWsCrab.ToString();
    //        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    //    }

    //    public WsCrabClient(EndpointConfiguration endpointConfiguration) :
    //            base(WsCrabClient.GetBindingForEndpoint(endpointConfiguration), WsCrabClient.GetEndpointAddress(endpointConfiguration))
    //    {
    //        this.Endpoint.Name = endpointConfiguration.ToString();
    //        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    //    }

    //    public WsCrabClient(EndpointConfiguration endpointConfiguration, string remoteAddress) :
    //            base(WsCrabClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
    //    {
    //        this.Endpoint.Name = endpointConfiguration.ToString();
    //        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    //    }

    //    public WsCrabClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) :
    //            base(WsCrabClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
    //    {
    //        this.Endpoint.Name = endpointConfiguration.ToString();
    //        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    //    }

    //    public WsCrabClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
    //            base(binding, remoteAddress)
    //    {
    //    }

    //    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.FindGemeentenResponse> WsCrabServiceReference.IWsCrab.FindGemeentenAsync(WsCrabServiceReference.FindGemeentenRequest request)
    //    {
    //        return base.Channel.FindGemeentenAsync(request);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.FindGemeentenResponse> FindGemeentenAsync(string GemeenteNaam, int GewestId, int SorteerVeld)
    //    {
    //        WsCrabServiceReference.FindGemeentenRequest inValue = new WsCrabServiceReference.FindGemeentenRequest();
    //        inValue.Body = new WsCrabServiceReference.FindGemeentenRequestBody();
    //        inValue.Body.GemeenteNaam = GemeenteNaam;
    //        inValue.Body.GewestId = GewestId;
    //        inValue.Body.SorteerVeld = SorteerVeld;
    //        return ((WsCrabServiceReference.IWsCrab)(this)).FindGemeentenAsync(inValue);
    //    }

    //    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.FindHuisnummersResponse> WsCrabServiceReference.IWsCrab.FindHuisnummersAsync(WsCrabServiceReference.FindHuisnummersRequest request)
    //    {
    //        return base.Channel.FindHuisnummersAsync(request);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.FindHuisnummersResponse> FindHuisnummersAsync(string Huisnummer, int StraatnaamId, int SorteerVeld)
    //    {
    //        WsCrabServiceReference.FindHuisnummersRequest inValue = new WsCrabServiceReference.FindHuisnummersRequest();
    //        inValue.Body = new WsCrabServiceReference.FindHuisnummersRequestBody();
    //        inValue.Body.Huisnummer = Huisnummer;
    //        inValue.Body.StraatnaamId = StraatnaamId;
    //        inValue.Body.SorteerVeld = SorteerVeld;
    //        return ((WsCrabServiceReference.IWsCrab)(this)).FindHuisnummersAsync(inValue);
    //    }

    //    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.FindHuisnummersWithStatusResponse> WsCrabServiceReference.IWsCrab.FindHuisnummersWithStatusAsync(WsCrabServiceReference.FindHuisnummersWithStatusRequest request)
    //    {
    //        return base.Channel.FindHuisnummersWithStatusAsync(request);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.FindHuisnummersWithStatusResponse> FindHuisnummersWithStatusAsync(string Huisnummer, int StraatnaamId, int SorteerVeld)
    //    {
    //        WsCrabServiceReference.FindHuisnummersWithStatusRequest inValue = new WsCrabServiceReference.FindHuisnummersWithStatusRequest();
    //        inValue.Body = new WsCrabServiceReference.FindHuisnummersWithStatusRequestBody();
    //        inValue.Body.Huisnummer = Huisnummer;
    //        inValue.Body.StraatnaamId = StraatnaamId;
    //        inValue.Body.SorteerVeld = SorteerVeld;
    //        return ((WsCrabServiceReference.IWsCrab)(this)).FindHuisnummersWithStatusAsync(inValue);
    //    }

    //    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.FindStraatnamenResponse> WsCrabServiceReference.IWsCrab.FindStraatnamenAsync(WsCrabServiceReference.FindStraatnamenRequest request)
    //    {
    //        return base.Channel.FindStraatnamenAsync(request);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.FindStraatnamenResponse> FindStraatnamenAsync(string Straatnaam, int GemeenteId, int SorteerVeld)
    //    {
    //        WsCrabServiceReference.FindStraatnamenRequest inValue = new WsCrabServiceReference.FindStraatnamenRequest();
    //        inValue.Body = new WsCrabServiceReference.FindStraatnamenRequestBody();
    //        inValue.Body.Straatnaam = Straatnaam;
    //        inValue.Body.GemeenteId = GemeenteId;
    //        inValue.Body.SorteerVeld = SorteerVeld;
    //        return ((WsCrabServiceReference.IWsCrab)(this)).FindStraatnamenAsync(inValue);
    //    }

    //    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.FindStraatnamenWithStatusResponse> WsCrabServiceReference.IWsCrab.FindStraatnamenWithStatusAsync(WsCrabServiceReference.FindStraatnamenWithStatusRequest request)
    //    {
    //        return base.Channel.FindStraatnamenWithStatusAsync(request);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.FindStraatnamenWithStatusResponse> FindStraatnamenWithStatusAsync(string Straatnaam, int GemeenteId, int SorteerVeld)
    //    {
    //        WsCrabServiceReference.FindStraatnamenWithStatusRequest inValue = new WsCrabServiceReference.FindStraatnamenWithStatusRequest();
    //        inValue.Body = new WsCrabServiceReference.FindStraatnamenWithStatusRequestBody();
    //        inValue.Body.Straatnaam = Straatnaam;
    //        inValue.Body.GemeenteId = GemeenteId;
    //        inValue.Body.SorteerVeld = SorteerVeld;
    //        return ((WsCrabServiceReference.IWsCrab)(this)).FindStraatnamenWithStatusAsync(inValue);
    //    }

    //    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.FindSubadressenResponse> WsCrabServiceReference.IWsCrab.FindSubadressenAsync(WsCrabServiceReference.FindSubadressenRequest request)
    //    {
    //        return base.Channel.FindSubadressenAsync(request);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.FindSubadressenResponse> FindSubadressenAsync(string Subadres, int HuisnummerId, int SorteerVeld)
    //    {
    //        WsCrabServiceReference.FindSubadressenRequest inValue = new WsCrabServiceReference.FindSubadressenRequest();
    //        inValue.Body = new WsCrabServiceReference.FindSubadressenRequestBody();
    //        inValue.Body.Subadres = Subadres;
    //        inValue.Body.HuisnummerId = HuisnummerId;
    //        inValue.Body.SorteerVeld = SorteerVeld;
    //        return ((WsCrabServiceReference.IWsCrab)(this)).FindSubadressenAsync(inValue);
    //    }

    //    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.FindSubadressenWithStatusResponse> WsCrabServiceReference.IWsCrab.FindSubadressenWithStatusAsync(WsCrabServiceReference.FindSubadressenWithStatusRequest request)
    //    {
    //        return base.Channel.FindSubadressenWithStatusAsync(request);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.FindSubadressenWithStatusResponse> FindSubadressenWithStatusAsync(string Subadres, int HuisnummerId, int SorteerVeld)
    //    {
    //        WsCrabServiceReference.FindSubadressenWithStatusRequest inValue = new WsCrabServiceReference.FindSubadressenWithStatusRequest();
    //        inValue.Body = new WsCrabServiceReference.FindSubadressenWithStatusRequestBody();
    //        inValue.Body.Subadres = Subadres;
    //        inValue.Body.HuisnummerId = HuisnummerId;
    //        inValue.Body.SorteerVeld = SorteerVeld;
    //        return ((WsCrabServiceReference.IWsCrab)(this)).FindSubadressenWithStatusAsync(inValue);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.AdrespositieObject> GetAdrespositieByAdrespositieIdAsync(int AdrespositieId)
    //    {
    //        return base.Channel.GetAdrespositieByAdrespositieIdAsync(AdrespositieId);
    //    }

    //    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.GetGebouwByIdentificatorGebouwResponse> WsCrabServiceReference.IWsCrab.GetGebouwByIdentificatorGebouwAsync(WsCrabServiceReference.GetGebouwByIdentificatorGebouwRequest request)
    //    {
    //        return base.Channel.GetGebouwByIdentificatorGebouwAsync(request);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.GetGebouwByIdentificatorGebouwResponse> GetGebouwByIdentificatorGebouwAsync(string IdentificatorGebouw)
    //    {
    //        WsCrabServiceReference.GetGebouwByIdentificatorGebouwRequest inValue = new WsCrabServiceReference.GetGebouwByIdentificatorGebouwRequest();
    //        inValue.Body = new WsCrabServiceReference.GetGebouwByIdentificatorGebouwRequestBody();
    //        inValue.Body.IdentificatorGebouw = IdentificatorGebouw;
    //        return ((WsCrabServiceReference.IWsCrab)(this)).GetGebouwByIdentificatorGebouwAsync(inValue);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.GemeenteObject> GetGemeenteByGemeenteIdAsync(int GemeenteId)
    //    {
    //        return base.Channel.GetGemeenteByGemeenteIdAsync(GemeenteId);
    //    }

    //    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.GetGemeenteByGemeenteNaamResponse> WsCrabServiceReference.IWsCrab.GetGemeenteByGemeenteNaamAsync(WsCrabServiceReference.GetGemeenteByGemeenteNaamRequest request)
    //    {
    //        return base.Channel.GetGemeenteByGemeenteNaamAsync(request);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.GetGemeenteByGemeenteNaamResponse> GetGemeenteByGemeenteNaamAsync(string GemeenteNaam, int GewestId)
    //    {
    //        WsCrabServiceReference.GetGemeenteByGemeenteNaamRequest inValue = new WsCrabServiceReference.GetGemeenteByGemeenteNaamRequest();
    //        inValue.Body = new WsCrabServiceReference.GetGemeenteByGemeenteNaamRequestBody();
    //        inValue.Body.GemeenteNaam = GemeenteNaam;
    //        inValue.Body.GewestId = GewestId;
    //        return ((WsCrabServiceReference.IWsCrab)(this)).GetGemeenteByGemeenteNaamAsync(inValue);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.GemeenteObject> GetGemeenteByNISGemeenteCodeAsync(int NISGemeenteCode)
    //    {
    //        return base.Channel.GetGemeenteByNISGemeenteCodeAsync(NISGemeenteCode);
    //    }

    //    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.GetGewestByGewestIdAndTaalCodeResponse> WsCrabServiceReference.IWsCrab.GetGewestByGewestIdAndTaalCodeAsync(WsCrabServiceReference.GetGewestByGewestIdAndTaalCodeRequest request)
    //    {
    //        return base.Channel.GetGewestByGewestIdAndTaalCodeAsync(request);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.GetGewestByGewestIdAndTaalCodeResponse> GetGewestByGewestIdAndTaalCodeAsync(int GewestId, string TaalCode)
    //    {
    //        WsCrabServiceReference.GetGewestByGewestIdAndTaalCodeRequest inValue = new WsCrabServiceReference.GetGewestByGewestIdAndTaalCodeRequest();
    //        inValue.Body = new WsCrabServiceReference.GetGewestByGewestIdAndTaalCodeRequestBody();
    //        inValue.Body.GewestId = GewestId;
    //        inValue.Body.TaalCode = TaalCode;
    //        return ((WsCrabServiceReference.IWsCrab)(this)).GetGewestByGewestIdAndTaalCodeAsync(inValue);
    //    }

    //    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.GetHuisnummerByHuisnummerResponse> WsCrabServiceReference.IWsCrab.GetHuisnummerByHuisnummerAsync(WsCrabServiceReference.GetHuisnummerByHuisnummerRequest request)
    //    {
    //        return base.Channel.GetHuisnummerByHuisnummerAsync(request);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.GetHuisnummerByHuisnummerResponse> GetHuisnummerByHuisnummerAsync(string Huisnummer, int StraatnaamId)
    //    {
    //        WsCrabServiceReference.GetHuisnummerByHuisnummerRequest inValue = new WsCrabServiceReference.GetHuisnummerByHuisnummerRequest();
    //        inValue.Body = new WsCrabServiceReference.GetHuisnummerByHuisnummerRequestBody();
    //        inValue.Body.Huisnummer = Huisnummer;
    //        inValue.Body.StraatnaamId = StraatnaamId;
    //        return ((WsCrabServiceReference.IWsCrab)(this)).GetHuisnummerByHuisnummerAsync(inValue);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.HuisnummerObject> GetHuisnummerByHuisnummerIdAsync(int HuisnummerId)
    //    {
    //        return base.Channel.GetHuisnummerByHuisnummerIdAsync(HuisnummerId);
    //    }

    //    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.GetHuisnummerWithStatusByHuisnummerResponse> WsCrabServiceReference.IWsCrab.GetHuisnummerWithStatusByHuisnummerAsync(WsCrabServiceReference.GetHuisnummerWithStatusByHuisnummerRequest request)
    //    {
    //        return base.Channel.GetHuisnummerWithStatusByHuisnummerAsync(request);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.GetHuisnummerWithStatusByHuisnummerResponse> GetHuisnummerWithStatusByHuisnummerAsync(string Huisnummer, int StraatnaamId)
    //    {
    //        WsCrabServiceReference.GetHuisnummerWithStatusByHuisnummerRequest inValue = new WsCrabServiceReference.GetHuisnummerWithStatusByHuisnummerRequest();
    //        inValue.Body = new WsCrabServiceReference.GetHuisnummerWithStatusByHuisnummerRequestBody();
    //        inValue.Body.Huisnummer = Huisnummer;
    //        inValue.Body.StraatnaamId = StraatnaamId;
    //        return ((WsCrabServiceReference.IWsCrab)(this)).GetHuisnummerWithStatusByHuisnummerAsync(inValue);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.HuisnummerWithStatusObject> GetHuisnummerWithStatusByHuisnummerIdAsync(int HuisnummerId)
    //    {
    //        return base.Channel.GetHuisnummerWithStatusByHuisnummerIdAsync(HuisnummerId);
    //    }

    //    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.GetPerceelByIdentificatorPerceelResponse> WsCrabServiceReference.IWsCrab.GetPerceelByIdentificatorPerceelAsync(WsCrabServiceReference.GetPerceelByIdentificatorPerceelRequest request)
    //    {
    //        return base.Channel.GetPerceelByIdentificatorPerceelAsync(request);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.GetPerceelByIdentificatorPerceelResponse> GetPerceelByIdentificatorPerceelAsync(string IdentificatorPerceel)
    //    {
    //        WsCrabServiceReference.GetPerceelByIdentificatorPerceelRequest inValue = new WsCrabServiceReference.GetPerceelByIdentificatorPerceelRequest();
    //        inValue.Body = new WsCrabServiceReference.GetPerceelByIdentificatorPerceelRequestBody();
    //        inValue.Body.IdentificatorPerceel = IdentificatorPerceel;
    //        return ((WsCrabServiceReference.IWsCrab)(this)).GetPerceelByIdentificatorPerceelAsync(inValue);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.PostadresObject> GetPostadresByHuisnummerIdAsync(int HuisnummerId)
    //    {
    //        return base.Channel.GetPostadresByHuisnummerIdAsync(HuisnummerId);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.PostadresObject> GetPostadresBySubadresIdAsync(int SubadresId)
    //    {
    //        return base.Channel.GetPostadresBySubadresIdAsync(SubadresId);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.PostkantonObject> GetPostkantonByHuisnummerIdAsync(int HuisnummerId)
    //    {
    //        return base.Channel.GetPostkantonByHuisnummerIdAsync(HuisnummerId);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.RijksregisterstraatObject> GetRijksregisterStraatByRijksregisterStraatCodeAsync(int StraatCode, int SubkantonCode)
    //    {
    //        return base.Channel.GetRijksregisterStraatByRijksregisterStraatCodeAsync(StraatCode, SubkantonCode);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.StraatnaamObject> GetStraatnaamByRijksregisterStraatCodeAsync(int StraatCode, int SubkantonCode)
    //    {
    //        return base.Channel.GetStraatnaamByRijksregisterStraatCodeAsync(StraatCode, SubkantonCode);
    //    }

    //    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.GetStraatnaamByStraatnaamResponse> WsCrabServiceReference.IWsCrab.GetStraatnaamByStraatnaamAsync(WsCrabServiceReference.GetStraatnaamByStraatnaamRequest request)
    //    {
    //        return base.Channel.GetStraatnaamByStraatnaamAsync(request);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.GetStraatnaamByStraatnaamResponse> GetStraatnaamByStraatnaamAsync(string Straatnaam, int GemeenteId)
    //    {
    //        WsCrabServiceReference.GetStraatnaamByStraatnaamRequest inValue = new WsCrabServiceReference.GetStraatnaamByStraatnaamRequest();
    //        inValue.Body = new WsCrabServiceReference.GetStraatnaamByStraatnaamRequestBody();
    //        inValue.Body.Straatnaam = Straatnaam;
    //        inValue.Body.GemeenteId = GemeenteId;
    //        return ((WsCrabServiceReference.IWsCrab)(this)).GetStraatnaamByStraatnaamAsync(inValue);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.StraatnaamObject> GetStraatnaamByStraatnaamIdAsync(int StraatnaamId)
    //    {
    //        return base.Channel.GetStraatnaamByStraatnaamIdAsync(StraatnaamId);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.StraatnaamWithStatusObject> GetStraatnaamWithStatusByRijksregisterStraatCodeAsync(int StraatCode, int SubkantonCode)
    //    {
    //        return base.Channel.GetStraatnaamWithStatusByRijksregisterStraatCodeAsync(StraatCode, SubkantonCode);
    //    }

    //    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.GetStraatnaamWithStatusByStraatnaamResponse> WsCrabServiceReference.IWsCrab.GetStraatnaamWithStatusByStraatnaamAsync(WsCrabServiceReference.GetStraatnaamWithStatusByStraatnaamRequest request)
    //    {
    //        return base.Channel.GetStraatnaamWithStatusByStraatnaamAsync(request);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.GetStraatnaamWithStatusByStraatnaamResponse> GetStraatnaamWithStatusByStraatnaamAsync(string Straatnaam, int GemeenteId)
    //    {
    //        WsCrabServiceReference.GetStraatnaamWithStatusByStraatnaamRequest inValue = new WsCrabServiceReference.GetStraatnaamWithStatusByStraatnaamRequest();
    //        inValue.Body = new WsCrabServiceReference.GetStraatnaamWithStatusByStraatnaamRequestBody();
    //        inValue.Body.Straatnaam = Straatnaam;
    //        inValue.Body.GemeenteId = GemeenteId;
    //        return ((WsCrabServiceReference.IWsCrab)(this)).GetStraatnaamWithStatusByStraatnaamAsync(inValue);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.StraatnaamWithStatusObject> GetStraatnaamWithStatusByStraatnaamIdAsync(int StraatnaamId)
    //    {
    //        return base.Channel.GetStraatnaamWithStatusByStraatnaamIdAsync(StraatnaamId);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.SubadresObject> GetSubadresBySubadresIdAsync(int SubadresId)
    //    {
    //        return base.Channel.GetSubadresBySubadresIdAsync(SubadresId);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.SubadresWithStatusObject> GetSubadresWithStatusBySubadresIdAsync(int SubadresId)
    //    {
    //        return base.Channel.GetSubadresWithStatusBySubadresIdAsync(SubadresId);
    //    }

    //    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.GetTerreinobjectByIdentificatorTerreinobjectResponse> WsCrabServiceReference.IWsCrab.GetTerreinobjectByIdentificatorTerreinobjectAsync(WsCrabServiceReference.GetTerreinobjectByIdentificatorTerreinobjectRequest request)
    //    {
    //        return base.Channel.GetTerreinobjectByIdentificatorTerreinobjectAsync(request);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.GetTerreinobjectByIdentificatorTerreinobjectResponse> GetTerreinobjectByIdentificatorTerreinobjectAsync(string IdentificatorTerreinobject)
    //    {
    //        WsCrabServiceReference.GetTerreinobjectByIdentificatorTerreinobjectRequest inValue = new WsCrabServiceReference.GetTerreinobjectByIdentificatorTerreinobjectRequest();
    //        inValue.Body = new WsCrabServiceReference.GetTerreinobjectByIdentificatorTerreinobjectRequestBody();
    //        inValue.Body.IdentificatorTerreinobject = IdentificatorTerreinobject;
    //        return ((WsCrabServiceReference.IWsCrab)(this)).GetTerreinobjectByIdentificatorTerreinobjectAsync(inValue);
    //    }

    //    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.GetWegobjectByIdentificatorWegobjectResponse> WsCrabServiceReference.IWsCrab.GetWegobjectByIdentificatorWegobjectAsync(WsCrabServiceReference.GetWegobjectByIdentificatorWegobjectRequest request)
    //    {
    //        return base.Channel.GetWegobjectByIdentificatorWegobjectAsync(request);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.GetWegobjectByIdentificatorWegobjectResponse> GetWegobjectByIdentificatorWegobjectAsync(string IdentificatorWegobject)
    //    {
    //        WsCrabServiceReference.GetWegobjectByIdentificatorWegobjectRequest inValue = new WsCrabServiceReference.GetWegobjectByIdentificatorWegobjectRequest();
    //        inValue.Body = new WsCrabServiceReference.GetWegobjectByIdentificatorWegobjectRequestBody();
    //        inValue.Body.IdentificatorWegobject = IdentificatorWegobject;
    //        return ((WsCrabServiceReference.IWsCrab)(this)).GetWegobjectByIdentificatorWegobjectAsync(inValue);
    //    }

    //    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.GetWegsegmentByIdentificatorWegsegmentResponse> WsCrabServiceReference.IWsCrab.GetWegsegmentByIdentificatorWegsegmentAsync(WsCrabServiceReference.GetWegsegmentByIdentificatorWegsegmentRequest request)
    //    {
    //        return base.Channel.GetWegsegmentByIdentificatorWegsegmentAsync(request);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.GetWegsegmentByIdentificatorWegsegmentResponse> GetWegsegmentByIdentificatorWegsegmentAsync(string IdentificatorWegsegment)
    //    {
    //        WsCrabServiceReference.GetWegsegmentByIdentificatorWegsegmentRequest inValue = new WsCrabServiceReference.GetWegsegmentByIdentificatorWegsegmentRequest();
    //        inValue.Body = new WsCrabServiceReference.GetWegsegmentByIdentificatorWegsegmentRequestBody();
    //        inValue.Body.IdentificatorWegsegment = IdentificatorWegsegment;
    //        return ((WsCrabServiceReference.IWsCrab)(this)).GetWegsegmentByIdentificatorWegsegmentAsync(inValue);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.CodeItem[]> ListAardAdressenAsync(int SorteerVeld)
    //    {
    //        return base.Channel.ListAardAdressenAsync(SorteerVeld);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.CodeItem[]> ListAardGebouwenAsync(int SorteerVeld)
    //    {
    //        return base.Channel.ListAardGebouwenAsync(SorteerVeld);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.CodeItem[]> ListAardSubadressenAsync(int SorteerVeld)
    //    {
    //        return base.Channel.ListAardSubadressenAsync(SorteerVeld);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.CodeItem[]> ListAardTerreinobjectenAsync(int SorteerVeld)
    //    {
    //        return base.Channel.ListAardTerreinobjectenAsync(SorteerVeld);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.CodeItem[]> ListAardWegobjectenAsync(int SorteerVeld)
    //    {
    //        return base.Channel.ListAardWegobjectenAsync(SorteerVeld);
    //    }

    //    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.ListAdrespositiesByHuisnummerResponse> WsCrabServiceReference.IWsCrab.ListAdrespositiesByHuisnummerAsync(WsCrabServiceReference.ListAdrespositiesByHuisnummerRequest request)
    //    {
    //        return base.Channel.ListAdrespositiesByHuisnummerAsync(request);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.ListAdrespositiesByHuisnummerResponse> ListAdrespositiesByHuisnummerAsync(string Huisnummer, int StraatnaamId, int SorteerVeld)
    //    {
    //        WsCrabServiceReference.ListAdrespositiesByHuisnummerRequest inValue = new WsCrabServiceReference.ListAdrespositiesByHuisnummerRequest();
    //        inValue.Body = new WsCrabServiceReference.ListAdrespositiesByHuisnummerRequestBody();
    //        inValue.Body.Huisnummer = Huisnummer;
    //        inValue.Body.StraatnaamId = StraatnaamId;
    //        inValue.Body.SorteerVeld = SorteerVeld;
    //        return ((WsCrabServiceReference.IWsCrab)(this)).ListAdrespositiesByHuisnummerAsync(inValue);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.AdrespositieItem[]> ListAdrespositiesByHuisnummerIdAsync(int HuisnummerId, int SorteerVeld)
    //    {
    //        return base.Channel.ListAdrespositiesByHuisnummerIdAsync(HuisnummerId, SorteerVeld);
    //    }

    //    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.ListAdrespositiesBySubadresResponse> WsCrabServiceReference.IWsCrab.ListAdrespositiesBySubadresAsync(WsCrabServiceReference.ListAdrespositiesBySubadresRequest request)
    //    {
    //        return base.Channel.ListAdrespositiesBySubadresAsync(request);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.ListAdrespositiesBySubadresResponse> ListAdrespositiesBySubadresAsync(string Subadres, int HuisnummerId, int SorteerVeld)
    //    {
    //        WsCrabServiceReference.ListAdrespositiesBySubadresRequest inValue = new WsCrabServiceReference.ListAdrespositiesBySubadresRequest();
    //        inValue.Body = new WsCrabServiceReference.ListAdrespositiesBySubadresRequestBody();
    //        inValue.Body.Subadres = Subadres;
    //        inValue.Body.HuisnummerId = HuisnummerId;
    //        inValue.Body.SorteerVeld = SorteerVeld;
    //        return ((WsCrabServiceReference.IWsCrab)(this)).ListAdrespositiesBySubadresAsync(inValue);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.AdrespositieItem[]> ListAdrespositiesBySubadresIdAsync(int SubadresId, int SorteerVeld)
    //    {
    //        return base.Channel.ListAdrespositiesBySubadresIdAsync(SubadresId, SorteerVeld);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.CodeItem[]> ListBewerkingenAsync(int SorteerVeld)
    //    {
    //        return base.Channel.ListBewerkingenAsync(SorteerVeld);
    //    }

    //    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.ListGebouwenByHuisnummerResponse> WsCrabServiceReference.IWsCrab.ListGebouwenByHuisnummerAsync(WsCrabServiceReference.ListGebouwenByHuisnummerRequest request)
    //    {
    //        return base.Channel.ListGebouwenByHuisnummerAsync(request);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.ListGebouwenByHuisnummerResponse> ListGebouwenByHuisnummerAsync(string Huisnummer, int StraatnaamId, int SorteerVeld)
    //    {
    //        WsCrabServiceReference.ListGebouwenByHuisnummerRequest inValue = new WsCrabServiceReference.ListGebouwenByHuisnummerRequest();
    //        inValue.Body = new WsCrabServiceReference.ListGebouwenByHuisnummerRequestBody();
    //        inValue.Body.Huisnummer = Huisnummer;
    //        inValue.Body.StraatnaamId = StraatnaamId;
    //        inValue.Body.SorteerVeld = SorteerVeld;
    //        return ((WsCrabServiceReference.IWsCrab)(this)).ListGebouwenByHuisnummerAsync(inValue);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.GebouwItem[]> ListGebouwenByHuisnummerIdAsync(int HuisnummerId, int SorteerVeld)
    //    {
    //        return base.Channel.ListGebouwenByHuisnummerIdAsync(HuisnummerId, SorteerVeld);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.GemeenteItem[]> ListGemeentenByGewestIdAsync(int GewestId, int SorteerVeld)
    //    {
    //        return base.Channel.ListGemeentenByGewestIdAsync(GewestId, SorteerVeld);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.CodeItem[]> ListGeometriemethodeGebouwenAsync(int SorteerVeld)
    //    {
    //        return base.Channel.ListGeometriemethodeGebouwenAsync(SorteerVeld);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.CodeItem[]> ListGeometriemethodeWegsegmentenAsync(int SorteerVeld)
    //    {
    //        return base.Channel.ListGeometriemethodeWegsegmentenAsync(SorteerVeld);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.GewestItem[]> ListGewestenAsync(int SorteerVeld)
    //    {
    //        return base.Channel.ListGewestenAsync(SorteerVeld);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.CodeItem[]> ListHerkomstAdrespositiesAsync(int SorteerVeld)
    //    {
    //        return base.Channel.ListHerkomstAdrespositiesAsync(SorteerVeld);
    //    }

    //    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.ListHuisnummersByIdentificatorTerreinobjectResponse> WsCrabServiceReference.IWsCrab.ListHuisnummersByIdentificatorTerreinobjectAsync(WsCrabServiceReference.ListHuisnummersByIdentificatorTerreinobjectRequest request)
    //    {
    //        return base.Channel.ListHuisnummersByIdentificatorTerreinobjectAsync(request);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.ListHuisnummersByIdentificatorTerreinobjectResponse> ListHuisnummersByIdentificatorTerreinobjectAsync(string IdentificatorTerreinobject, int SorteerVeld)
    //    {
    //        WsCrabServiceReference.ListHuisnummersByIdentificatorTerreinobjectRequest inValue = new WsCrabServiceReference.ListHuisnummersByIdentificatorTerreinobjectRequest();
    //        inValue.Body = new WsCrabServiceReference.ListHuisnummersByIdentificatorTerreinobjectRequestBody();
    //        inValue.Body.IdentificatorTerreinobject = IdentificatorTerreinobject;
    //        inValue.Body.SorteerVeld = SorteerVeld;
    //        return ((WsCrabServiceReference.IWsCrab)(this)).ListHuisnummersByIdentificatorTerreinobjectAsync(inValue);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.HuisnummerItem[]> ListHuisnummersByStraatnaamIdAsync(int StraatnaamId, int SorteerVeld)
    //    {
    //        return base.Channel.ListHuisnummersByStraatnaamIdAsync(StraatnaamId, SorteerVeld);
    //    }

    //    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.ListHuisnummersWithStatusByIdentificatorGebouwResponse> WsCrabServiceReference.IWsCrab.ListHuisnummersWithStatusByIdentificatorGebouwAsync(WsCrabServiceReference.ListHuisnummersWithStatusByIdentificatorGebouwRequest request)
    //    {
    //        return base.Channel.ListHuisnummersWithStatusByIdentificatorGebouwAsync(request);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.ListHuisnummersWithStatusByIdentificatorGebouwResponse> ListHuisnummersWithStatusByIdentificatorGebouwAsync(string IdentificatorGebouw, int SorteerVeld)
    //    {
    //        WsCrabServiceReference.ListHuisnummersWithStatusByIdentificatorGebouwRequest inValue = new WsCrabServiceReference.ListHuisnummersWithStatusByIdentificatorGebouwRequest();
    //        inValue.Body = new WsCrabServiceReference.ListHuisnummersWithStatusByIdentificatorGebouwRequestBody();
    //        inValue.Body.IdentificatorGebouw = IdentificatorGebouw;
    //        inValue.Body.SorteerVeld = SorteerVeld;
    //        return ((WsCrabServiceReference.IWsCrab)(this)).ListHuisnummersWithStatusByIdentificatorGebouwAsync(inValue);
    //    }

    //    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.ListHuisnummersWithStatusByIdentificatorPerceelResponse> WsCrabServiceReference.IWsCrab.ListHuisnummersWithStatusByIdentificatorPerceelAsync(WsCrabServiceReference.ListHuisnummersWithStatusByIdentificatorPerceelRequest request)
    //    {
    //        return base.Channel.ListHuisnummersWithStatusByIdentificatorPerceelAsync(request);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.ListHuisnummersWithStatusByIdentificatorPerceelResponse> ListHuisnummersWithStatusByIdentificatorPerceelAsync(string IdentificatorPerceel, int SorteerVeld)
    //    {
    //        WsCrabServiceReference.ListHuisnummersWithStatusByIdentificatorPerceelRequest inValue = new WsCrabServiceReference.ListHuisnummersWithStatusByIdentificatorPerceelRequest();
    //        inValue.Body = new WsCrabServiceReference.ListHuisnummersWithStatusByIdentificatorPerceelRequestBody();
    //        inValue.Body.IdentificatorPerceel = IdentificatorPerceel;
    //        inValue.Body.SorteerVeld = SorteerVeld;
    //        return ((WsCrabServiceReference.IWsCrab)(this)).ListHuisnummersWithStatusByIdentificatorPerceelAsync(inValue);
    //    }

    //    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.ListHuisnummersWithStatusByIdentificatorTerreinobjectResponse> WsCrabServiceReference.IWsCrab.ListHuisnummersWithStatusByIdentificatorTerreinobjectAsync(WsCrabServiceReference.ListHuisnummersWithStatusByIdentificatorTerreinobjectRequest request)
    //    {
    //        return base.Channel.ListHuisnummersWithStatusByIdentificatorTerreinobjectAsync(request);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.ListHuisnummersWithStatusByIdentificatorTerreinobjectResponse> ListHuisnummersWithStatusByIdentificatorTerreinobjectAsync(string IdentificatorTerreinobject, int SorteerVeld)
    //    {
    //        WsCrabServiceReference.ListHuisnummersWithStatusByIdentificatorTerreinobjectRequest inValue = new WsCrabServiceReference.ListHuisnummersWithStatusByIdentificatorTerreinobjectRequest();
    //        inValue.Body = new WsCrabServiceReference.ListHuisnummersWithStatusByIdentificatorTerreinobjectRequestBody();
    //        inValue.Body.IdentificatorTerreinobject = IdentificatorTerreinobject;
    //        inValue.Body.SorteerVeld = SorteerVeld;
    //        return ((WsCrabServiceReference.IWsCrab)(this)).ListHuisnummersWithStatusByIdentificatorTerreinobjectAsync(inValue);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.HuisnummerWithStatusItem[]> ListHuisnummersWithStatusByRijksregisterAdresIdAsync(int RijksregisterAdresId, int SorteerVeld)
    //    {
    //        return base.Channel.ListHuisnummersWithStatusByRijksregisterAdresIdAsync(RijksregisterAdresId, SorteerVeld);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.HuisnummerWithStatusItem[]> ListHuisnummersWithStatusByStraatnaamIdAsync(int StraatnaamId, int SorteerVeld)
    //    {
    //        return base.Channel.ListHuisnummersWithStatusByStraatnaamIdAsync(StraatnaamId, SorteerVeld);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.CodeItem[]> ListOrganisatiesAsync(int SorteerVeld)
    //    {
    //        return base.Channel.ListOrganisatiesAsync(SorteerVeld);
    //    }

    //    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.ListPercelenByHuisnummerResponse> WsCrabServiceReference.IWsCrab.ListPercelenByHuisnummerAsync(WsCrabServiceReference.ListPercelenByHuisnummerRequest request)
    //    {
    //        return base.Channel.ListPercelenByHuisnummerAsync(request);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.ListPercelenByHuisnummerResponse> ListPercelenByHuisnummerAsync(string Huisnummer, int StraatnaamId)
    //    {
    //        WsCrabServiceReference.ListPercelenByHuisnummerRequest inValue = new WsCrabServiceReference.ListPercelenByHuisnummerRequest();
    //        inValue.Body = new WsCrabServiceReference.ListPercelenByHuisnummerRequestBody();
    //        inValue.Body.Huisnummer = Huisnummer;
    //        inValue.Body.StraatnaamId = StraatnaamId;
    //        return ((WsCrabServiceReference.IWsCrab)(this)).ListPercelenByHuisnummerAsync(inValue);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.PerceelItem[]> ListPercelenByHuisnummerIdAsync(int HuisnummerId)
    //    {
    //        return base.Channel.ListPercelenByHuisnummerIdAsync(HuisnummerId);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.PostadresItem[]> ListPostadressenByStraatnaamIdAsync(int StraatnaamId)
    //    {
    //        return base.Channel.ListPostadressenByStraatnaamIdAsync(StraatnaamId);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.PostkantonItem[]> ListPostkantonsByGemeenteIdAsync(int GemeenteId)
    //    {
    //        return base.Channel.ListPostkantonsByGemeenteIdAsync(GemeenteId);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.RijksregisterstraatItem[]> ListRijksregisterStratenByStraatnaamIdAsync(int StraatnaamId)
    //    {
    //        return base.Channel.ListRijksregisterStratenByStraatnaamIdAsync(StraatnaamId);
    //    }

    //    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.ListRijksregisterAdresByHuisnummerResponse> WsCrabServiceReference.IWsCrab.ListRijksregisterAdresByHuisnummerAsync(WsCrabServiceReference.ListRijksregisterAdresByHuisnummerRequest request)
    //    {
    //        return base.Channel.ListRijksregisterAdresByHuisnummerAsync(request);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.ListRijksregisterAdresByHuisnummerResponse> ListRijksregisterAdresByHuisnummerAsync(string Huisnummer, int StraatnaamId, int SorteerVeld)
    //    {
    //        WsCrabServiceReference.ListRijksregisterAdresByHuisnummerRequest inValue = new WsCrabServiceReference.ListRijksregisterAdresByHuisnummerRequest();
    //        inValue.Body = new WsCrabServiceReference.ListRijksregisterAdresByHuisnummerRequestBody();
    //        inValue.Body.Huisnummer = Huisnummer;
    //        inValue.Body.StraatnaamId = StraatnaamId;
    //        inValue.Body.SorteerVeld = SorteerVeld;
    //        return ((WsCrabServiceReference.IWsCrab)(this)).ListRijksregisterAdresByHuisnummerAsync(inValue);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.RijksregisterAdresItem[]> ListRijksregisterAdresByHuisnummerIdAsync(int HuisnummerId, int SorteerVeld)
    //    {
    //        return base.Channel.ListRijksregisterAdresByHuisnummerIdAsync(HuisnummerId, SorteerVeld);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.RijksregisterAdresItem[]> ListRijksregisterAdresBySubadresIdAsync(int SubadresId, int SorteerVeld)
    //    {
    //        return base.Channel.ListRijksregisterAdresBySubadresIdAsync(SubadresId, SorteerVeld);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.CodeItem[]> ListStatusGebouwenAsync(int SorteerVeld)
    //    {
    //        return base.Channel.ListStatusGebouwenAsync(SorteerVeld);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.CodeItem[]> ListStatusHuisnummersAsync(int SorteerVeld)
    //    {
    //        return base.Channel.ListStatusHuisnummersAsync(SorteerVeld);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.CodeItem[]> ListStatusStraatnamenAsync(int SorteerVeld)
    //    {
    //        return base.Channel.ListStatusStraatnamenAsync(SorteerVeld);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.CodeItem[]> ListStatusSubadressenAsync(int SorteerVeld)
    //    {
    //        return base.Channel.ListStatusSubadressenAsync(SorteerVeld);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.CodeItem[]> ListStatusWegsegmentenAsync(int SorteerVeld)
    //    {
    //        return base.Channel.ListStatusWegsegmentenAsync(SorteerVeld);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.StraatnaamItem[]> ListStraatnamenByGemeenteIdAsync(int GemeenteId, int SorteerVeld)
    //    {
    //        return base.Channel.ListStraatnamenByGemeenteIdAsync(GemeenteId, SorteerVeld);
    //    }

    //    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.ListStraatnamenByIdentificatorWegobjectResponse> WsCrabServiceReference.IWsCrab.ListStraatnamenByIdentificatorWegobjectAsync(WsCrabServiceReference.ListStraatnamenByIdentificatorWegobjectRequest request)
    //    {
    //        return base.Channel.ListStraatnamenByIdentificatorWegobjectAsync(request);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.ListStraatnamenByIdentificatorWegobjectResponse> ListStraatnamenByIdentificatorWegobjectAsync(string IdentificatorWegobject, int SorteerVeld)
    //    {
    //        WsCrabServiceReference.ListStraatnamenByIdentificatorWegobjectRequest inValue = new WsCrabServiceReference.ListStraatnamenByIdentificatorWegobjectRequest();
    //        inValue.Body = new WsCrabServiceReference.ListStraatnamenByIdentificatorWegobjectRequestBody();
    //        inValue.Body.IdentificatorWegobject = IdentificatorWegobject;
    //        inValue.Body.SorteerVeld = SorteerVeld;
    //        return ((WsCrabServiceReference.IWsCrab)(this)).ListStraatnamenByIdentificatorWegobjectAsync(inValue);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.StraatnaamWithStatusItem[]> ListStraatnamenWithStatusByGemeenteIdAsync(int GemeenteId, int SorteerVeld)
    //    {
    //        return base.Channel.ListStraatnamenWithStatusByGemeenteIdAsync(GemeenteId, SorteerVeld);
    //    }

    //    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.ListStraatnamenWithStatusByIdentificatorWegobjectResponse> WsCrabServiceReference.IWsCrab.ListStraatnamenWithStatusByIdentificatorWegobjectAsync(WsCrabServiceReference.ListStraatnamenWithStatusByIdentificatorWegobjectRequest request)
    //    {
    //        return base.Channel.ListStraatnamenWithStatusByIdentificatorWegobjectAsync(request);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.ListStraatnamenWithStatusByIdentificatorWegobjectResponse> ListStraatnamenWithStatusByIdentificatorWegobjectAsync(string IdentificatorWegobject, int SorteerVeld)
    //    {
    //        WsCrabServiceReference.ListStraatnamenWithStatusByIdentificatorWegobjectRequest inValue = new WsCrabServiceReference.ListStraatnamenWithStatusByIdentificatorWegobjectRequest();
    //        inValue.Body = new WsCrabServiceReference.ListStraatnamenWithStatusByIdentificatorWegobjectRequestBody();
    //        inValue.Body.IdentificatorWegobject = IdentificatorWegobject;
    //        inValue.Body.SorteerVeld = SorteerVeld;
    //        return ((WsCrabServiceReference.IWsCrab)(this)).ListStraatnamenWithStatusByIdentificatorWegobjectAsync(inValue);
    //    }

    //    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //    System.Threading.Tasks.Task<WsCrabServiceReference.ListStraatnamenWithStatusByIdentificatorWegsegmentResponse> WsCrabServiceReference.IWsCrab.ListStraatnamenWithStatusByIdentificatorWegsegmentAsync(WsCrabServiceReference.ListStraatnamenWithStatusByIdentificatorWegsegmentRequest request)
    //    {
    //        return base.Channel.ListStraatnamenWithStatusByIdentificatorWegsegmentAsync(request);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.ListStraatnamenWithStatusByIdentificatorWegsegmentResponse> ListStraatnamenWithStatusByIdentificatorWegsegmentAsync(string IdentificatorWegsegment, int SorteerVeld)
    //    {
    //        WsCrabServiceReference.ListStraatnamenWithStatusByIdentificatorWegsegmentRequest inValue = new WsCrabServiceReference.ListStraatnamenWithStatusByIdentificatorWegsegmentRequest();
    //        inValue.Body = new WsCrabServiceReference.ListStraatnamenWithStatusByIdentificatorWegsegmentRequestBody();
    //        inValue.Body.IdentificatorWegsegment = IdentificatorWegsegment;
    //        inValue.Body.SorteerVeld = SorteerVeld;
    //        return ((WsCrabServiceReference.IWsCrab)(this)).ListStraatnamenWithStatusByIdentificatorWegsegmentAsync(inValue);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.SubadresItem[]> ListSubadressenByHuisnummerIdAsync(int HuisnummerId, int SorteerVeld)
    //    {
    //        return base.Channel.ListSubadressenByHuisnummerIdAsync(HuisnummerId, SorteerVeld);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.SubadresWithStatusItem[]> ListSubadressenWithStatusByHuisnummerIdAsync(int HuisnummerId, int SorteerVeld)
    //    {
    //        return base.Channel.ListSubadressenWithStatusByHuisnummerIdAsync(HuisnummerId, SorteerVeld);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.SubadresWithStatusItem[]> ListSubadressenWithStatusByRijksregisterAdresIdAsync(int RijksregisterAdresId, int SorteerVeld)
    //    {
    //        return base.Channel.ListSubadressenWithStatusByRijksregisterAdresIdAsync(RijksregisterAdresId, SorteerVeld);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.CodeItem[]> ListTalenAsync(int SorteerVeld)
    //    {
    //        return base.Channel.ListTalenAsync(SorteerVeld);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.TerreinobjectItem[]> ListTerreinobjectenByHuisnummerIdAsync(int HuisnummerId, int SorteerVeld)
    //    {
    //        return base.Channel.ListTerreinobjectenByHuisnummerIdAsync(HuisnummerId, SorteerVeld);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.WegobjectItem[]> ListWegobjectenByStraatnaamIdAsync(int StraatnaamId, int SorteerVeld)
    //    {
    //        return base.Channel.ListWegobjectenByStraatnaamIdAsync(StraatnaamId, SorteerVeld);
    //    }

    //    public System.Threading.Tasks.Task<WsCrabServiceReference.WegsegmentItem[]> ListWegsegmentenByStraatnaamIdAsync(int StraatnaamId, int SorteerVeld)
    //    {
    //        return base.Channel.ListWegsegmentenByStraatnaamIdAsync(StraatnaamId, SorteerVeld);
    //    }

    //    public virtual System.Threading.Tasks.Task OpenAsync()
    //    {
    //        return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
    //    }

    //    public virtual System.Threading.Tasks.Task CloseAsync()
    //    {
    //        return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
    //    }

    //    private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
    //    {
    //        if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IWsCrab))
    //        {
    //            System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
    //            result.MaxBufferSize = int.MaxValue;
    //            result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
    //            result.MaxReceivedMessageSize = int.MaxValue;
    //            result.AllowCookies = true;
    //            return result;
    //        }
    //        throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
    //    }

    //    private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
    //    {
    //        if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IWsCrab))
    //        {
    //            return new System.ServiceModel.EndpointAddress("http://crab.agiv.be/wscrab/WsCrab.svc");
    //        }
    //        throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
    //    }

    //    private static System.ServiceModel.Channels.Binding GetDefaultBinding()
    //    {
    //        return WsCrabClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IWsCrab);
    //    }

    //    private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
    //    {
    //        return WsCrabClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IWsCrab);
    //    }

    //    public enum EndpointConfiguration
    //    {

    //        BasicHttpBinding_IWsCrab,
    //    }
    //}
