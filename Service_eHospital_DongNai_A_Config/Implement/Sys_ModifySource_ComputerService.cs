namespace Service_eHospital_DongNai_A_Config.Implement
{
    public class Sys_ModifySource_ComputerService : BaseService<Sys_ModifySource_Computer, ISys_ModifySource_ComputerRepository>
    , ISys_ModifySource_ComputerService
    {
    private readonly ISys_ModifySource_ComputerRepository _Sys_ModifySource_ComputerRepository;
    public Sys_ModifySource_ComputerService(ISys_ModifySource_ComputerRepository Sys_ModifySource_ComputerRepository) : base(Sys_ModifySource_ComputerRepository)
    {
    _Sys_ModifySource_ComputerRepository = Sys_ModifySource_ComputerRepository;
    }
    }
    }

