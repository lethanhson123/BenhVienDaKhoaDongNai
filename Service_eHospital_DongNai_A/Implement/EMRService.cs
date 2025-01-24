namespace Service_eHospital_DongNai_A.Implement
{
    public class EMRService : BaseService<EMR, IEMRRepository>
    , IEMRService
    {
    private readonly IEMRRepository _EMRRepository;
    public EMRService(IEMRRepository EMRRepository) : base(EMRRepository)
    {
    _EMRRepository = EMRRepository;
    }
    }
    }

