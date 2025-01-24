namespace Service_eHospital_DongNai_A.Implement
{
    public class KhamBenh_HenTaiKhamService : BaseService<KhamBenh_HenTaiKham, IKhamBenh_HenTaiKhamRepository>
    , IKhamBenh_HenTaiKhamService
    {
    private readonly IKhamBenh_HenTaiKhamRepository _KhamBenh_HenTaiKhamRepository;
    public KhamBenh_HenTaiKhamService(IKhamBenh_HenTaiKhamRepository KhamBenh_HenTaiKhamRepository) : base(KhamBenh_HenTaiKhamRepository)
    {
    _KhamBenh_HenTaiKhamRepository = KhamBenh_HenTaiKhamRepository;
    }
    }
    }

