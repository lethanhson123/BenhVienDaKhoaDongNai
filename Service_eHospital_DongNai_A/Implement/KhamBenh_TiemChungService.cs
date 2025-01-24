namespace Service_eHospital_DongNai_A.Implement
{
    public class KhamBenh_TiemChungService : BaseService<KhamBenh_TiemChung, IKhamBenh_TiemChungRepository>
    , IKhamBenh_TiemChungService
    {
    private readonly IKhamBenh_TiemChungRepository _KhamBenh_TiemChungRepository;
    public KhamBenh_TiemChungService(IKhamBenh_TiemChungRepository KhamBenh_TiemChungRepository) : base(KhamBenh_TiemChungRepository)
    {
    _KhamBenh_TiemChungRepository = KhamBenh_TiemChungRepository;
    }
    }
    }

