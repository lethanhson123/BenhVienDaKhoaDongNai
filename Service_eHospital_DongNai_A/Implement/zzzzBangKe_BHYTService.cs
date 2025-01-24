namespace Service_eHospital_DongNai_A.Implement
{
    public class zzzzBangKe_BHYTService : BaseService<zzzzBangKe_BHYT, IzzzzBangKe_BHYTRepository>
    , IzzzzBangKe_BHYTService
    {
    private readonly IzzzzBangKe_BHYTRepository _zzzzBangKe_BHYTRepository;
    public zzzzBangKe_BHYTService(IzzzzBangKe_BHYTRepository zzzzBangKe_BHYTRepository) : base(zzzzBangKe_BHYTRepository)
    {
    _zzzzBangKe_BHYTRepository = zzzzBangKe_BHYTRepository;
    }
    }
    }

