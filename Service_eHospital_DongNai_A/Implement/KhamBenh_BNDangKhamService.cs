namespace Service_eHospital_DongNai_A.Implement
{
    public class KhamBenh_BNDangKhamService : BaseService<KhamBenh_BNDangKham, IKhamBenh_BNDangKhamRepository>
    , IKhamBenh_BNDangKhamService
    {
    private readonly IKhamBenh_BNDangKhamRepository _KhamBenh_BNDangKhamRepository;
    public KhamBenh_BNDangKhamService(IKhamBenh_BNDangKhamRepository KhamBenh_BNDangKhamRepository) : base(KhamBenh_BNDangKhamRepository)
    {
    _KhamBenh_BNDangKhamRepository = KhamBenh_BNDangKhamRepository;
    }
    }
    }

