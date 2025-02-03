namespace Service_eHospital_DongNai_A_Config.Implement
{
    public class Sys_ConstantsService : BaseService<Sys_Constants, ISys_ConstantsRepository>
    , ISys_ConstantsService
    {
    private readonly ISys_ConstantsRepository _Sys_ConstantsRepository;
    public Sys_ConstantsService(ISys_ConstantsRepository Sys_ConstantsRepository) : base(Sys_ConstantsRepository)
    {
    _Sys_ConstantsRepository = Sys_ConstantsRepository;
    }
    }
    }

