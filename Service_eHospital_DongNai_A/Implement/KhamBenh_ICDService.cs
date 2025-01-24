namespace Service_eHospital_DongNai_A.Implement
{
    public class KhamBenh_ICDService : BaseService<KhamBenh_ICD, IKhamBenh_ICDRepository>
    , IKhamBenh_ICDService
    {
    private readonly IKhamBenh_ICDRepository _KhamBenh_ICDRepository;
    public KhamBenh_ICDService(IKhamBenh_ICDRepository KhamBenh_ICDRepository) : base(KhamBenh_ICDRepository)
    {
    _KhamBenh_ICDRepository = KhamBenh_ICDRepository;
    }
    }
    }

