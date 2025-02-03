namespace Service_eHospital_DongNai_A_Config.Implement
{
    public class Sys_ModifySource_ServerService : BaseService<Sys_ModifySource_Server, ISys_ModifySource_ServerRepository>
    , ISys_ModifySource_ServerService
    {
    private readonly ISys_ModifySource_ServerRepository _Sys_ModifySource_ServerRepository;
    public Sys_ModifySource_ServerService(ISys_ModifySource_ServerRepository Sys_ModifySource_ServerRepository) : base(Sys_ModifySource_ServerRepository)
    {
    _Sys_ModifySource_ServerRepository = Sys_ModifySource_ServerRepository;
    }
    }
    }

