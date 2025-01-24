namespace Service_eHospital_DongNai_A.Implement
{
    public class KhamBenh_VTYTService : BaseService<KhamBenh_VTYT, IKhamBenh_VTYTRepository>
    , IKhamBenh_VTYTService
    {
    private readonly IKhamBenh_VTYTRepository _KhamBenh_VTYTRepository;
    public KhamBenh_VTYTService(IKhamBenh_VTYTRepository KhamBenh_VTYTRepository) : base(KhamBenh_VTYTRepository)
    {
    _KhamBenh_VTYTRepository = KhamBenh_VTYTRepository;
    }
    }
    }

