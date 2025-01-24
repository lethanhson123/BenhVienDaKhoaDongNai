namespace Service_eHospital_DongNai_A.Implement
{
    public class zzzzBangKe_TuChiTra_AllService : BaseService<zzzzBangKe_TuChiTra_All, IzzzzBangKe_TuChiTra_AllRepository>
    , IzzzzBangKe_TuChiTra_AllService
    {
    private readonly IzzzzBangKe_TuChiTra_AllRepository _zzzzBangKe_TuChiTra_AllRepository;
    public zzzzBangKe_TuChiTra_AllService(IzzzzBangKe_TuChiTra_AllRepository zzzzBangKe_TuChiTra_AllRepository) : base(zzzzBangKe_TuChiTra_AllRepository)
    {
    _zzzzBangKe_TuChiTra_AllRepository = zzzzBangKe_TuChiTra_AllRepository;
    }
    }
    }

