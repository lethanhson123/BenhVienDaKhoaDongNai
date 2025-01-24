namespace Service_eHospital_DongNai_A.Implement
{
    public class zzzzBangKe_TuChiTraService : BaseService<zzzzBangKe_TuChiTra, IzzzzBangKe_TuChiTraRepository>
    , IzzzzBangKe_TuChiTraService
    {
    private readonly IzzzzBangKe_TuChiTraRepository _zzzzBangKe_TuChiTraRepository;
    public zzzzBangKe_TuChiTraService(IzzzzBangKe_TuChiTraRepository zzzzBangKe_TuChiTraRepository) : base(zzzzBangKe_TuChiTraRepository)
    {
    _zzzzBangKe_TuChiTraRepository = zzzzBangKe_TuChiTraRepository;
    }
    }
    }

