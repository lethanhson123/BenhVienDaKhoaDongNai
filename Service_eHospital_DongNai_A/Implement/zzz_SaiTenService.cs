namespace Service_eHospital_DongNai_A.Implement
{
    public class zzz_SaiTenService : BaseService<zzz_SaiTen, Izzz_SaiTenRepository>
    , Izzz_SaiTenService
    {
    private readonly Izzz_SaiTenRepository _zzz_SaiTenRepository;
    public zzz_SaiTenService(Izzz_SaiTenRepository zzz_SaiTenRepository) : base(zzz_SaiTenRepository)
    {
    _zzz_SaiTenRepository = zzz_SaiTenRepository;
    }
    }
    }

