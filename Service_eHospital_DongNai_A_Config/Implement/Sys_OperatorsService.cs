namespace Service_eHospital_DongNai_A_Config.Implement
{
    public class Sys_OperatorsService : BaseService<Sys_Operators, ISys_OperatorsRepository>
    , ISys_OperatorsService
    {
    private readonly ISys_OperatorsRepository _Sys_OperatorsRepository;
    public Sys_OperatorsService(ISys_OperatorsRepository Sys_OperatorsRepository) : base(Sys_OperatorsRepository)
    {
    _Sys_OperatorsRepository = Sys_OperatorsRepository;
    }
    }
    }

