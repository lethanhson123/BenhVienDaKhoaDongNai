namespace Service_eHospital_DongNai_A.Implement
{
    public class Sys_UserWorkingService : BaseService<Sys_UserWorking, ISys_UserWorkingRepository>
    , ISys_UserWorkingService
    {
    private readonly ISys_UserWorkingRepository _Sys_UserWorkingRepository;
    public Sys_UserWorkingService(ISys_UserWorkingRepository Sys_UserWorkingRepository) : base(Sys_UserWorkingRepository)
    {
    _Sys_UserWorkingRepository = Sys_UserWorkingRepository;
    }
    }
    }

