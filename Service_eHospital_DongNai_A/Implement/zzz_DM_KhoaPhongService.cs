namespace Service_eHospital_DongNai_A.Implement
{
    public class zzz_DM_KhoaPhongService : BaseService<zzz_DM_KhoaPhong, Izzz_DM_KhoaPhongRepository>
    , Izzz_DM_KhoaPhongService
    {
    private readonly Izzz_DM_KhoaPhongRepository _zzz_DM_KhoaPhongRepository;
    public zzz_DM_KhoaPhongService(Izzz_DM_KhoaPhongRepository zzz_DM_KhoaPhongRepository) : base(zzz_DM_KhoaPhongRepository)
    {
    _zzz_DM_KhoaPhongRepository = zzz_DM_KhoaPhongRepository;
    }
    }
    }

