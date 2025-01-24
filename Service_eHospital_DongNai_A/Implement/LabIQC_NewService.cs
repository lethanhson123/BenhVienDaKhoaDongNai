namespace Service_eHospital_DongNai_A.Implement
{
    public class LabIQC_NewService : BaseService<LabIQC_New, ILabIQC_NewRepository>
    , ILabIQC_NewService
    {
    private readonly ILabIQC_NewRepository _LabIQC_NewRepository;
    public LabIQC_NewService(ILabIQC_NewRepository LabIQC_NewRepository) : base(LabIQC_NewRepository)
    {
    _LabIQC_NewRepository = LabIQC_NewRepository;
    }
    }
    }

