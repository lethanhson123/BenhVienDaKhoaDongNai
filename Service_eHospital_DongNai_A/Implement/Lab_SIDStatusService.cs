namespace Service_eHospital_DongNai_A.Implement
{
    public class Lab_SIDStatusService : BaseService<Lab_SIDStatus, ILab_SIDStatusRepository>
    , ILab_SIDStatusService
    {
    private readonly ILab_SIDStatusRepository _Lab_SIDStatusRepository;
    public Lab_SIDStatusService(ILab_SIDStatusRepository Lab_SIDStatusRepository) : base(Lab_SIDStatusRepository)
    {
    _Lab_SIDStatusRepository = Lab_SIDStatusRepository;
    }
    }
    }

