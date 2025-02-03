namespace Service_eHospital_DongNai_A_Config.Implement
{
    public class Sys_ModifySource_ClientService : BaseService<Sys_ModifySource_Client, ISys_ModifySource_ClientRepository>
    , ISys_ModifySource_ClientService
    {
    private readonly ISys_ModifySource_ClientRepository _Sys_ModifySource_ClientRepository;
    public Sys_ModifySource_ClientService(ISys_ModifySource_ClientRepository Sys_ModifySource_ClientRepository) : base(Sys_ModifySource_ClientRepository)
    {
    _Sys_ModifySource_ClientRepository = Sys_ModifySource_ClientRepository;
    }
    }
    }

