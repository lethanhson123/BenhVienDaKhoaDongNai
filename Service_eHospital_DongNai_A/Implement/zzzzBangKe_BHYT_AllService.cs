namespace Service_eHospital_DongNai_A.Implement
{
    public class zzzzBangKe_BHYT_AllService : BaseService<zzzzBangKe_BHYT_All, IzzzzBangKe_BHYT_AllRepository>
    , IzzzzBangKe_BHYT_AllService
    {
    private readonly IzzzzBangKe_BHYT_AllRepository _zzzzBangKe_BHYT_AllRepository;
    public zzzzBangKe_BHYT_AllService(IzzzzBangKe_BHYT_AllRepository zzzzBangKe_BHYT_AllRepository) : base(zzzzBangKe_BHYT_AllRepository)
    {
    _zzzzBangKe_BHYT_AllRepository = zzzzBangKe_BHYT_AllRepository;
    }
    }
    }

