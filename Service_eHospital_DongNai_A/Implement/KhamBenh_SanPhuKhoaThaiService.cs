namespace Service_eHospital_DongNai_A.Implement
{
    public class KhamBenh_SanPhuKhoaThaiService : BaseService<KhamBenh_SanPhuKhoaThai, IKhamBenh_SanPhuKhoaThaiRepository>
    , IKhamBenh_SanPhuKhoaThaiService
    {
    private readonly IKhamBenh_SanPhuKhoaThaiRepository _KhamBenh_SanPhuKhoaThaiRepository;
    public KhamBenh_SanPhuKhoaThaiService(IKhamBenh_SanPhuKhoaThaiRepository KhamBenh_SanPhuKhoaThaiRepository) : base(KhamBenh_SanPhuKhoaThaiRepository)
    {
    _KhamBenh_SanPhuKhoaThaiRepository = KhamBenh_SanPhuKhoaThaiRepository;
    }
    }
    }

