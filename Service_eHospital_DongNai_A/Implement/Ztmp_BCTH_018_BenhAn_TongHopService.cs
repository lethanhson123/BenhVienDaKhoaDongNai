namespace Service_eHospital_DongNai_A.Implement
{
    public class Ztmp_BCTH_018_BenhAn_TongHopService : BaseService<Ztmp_BCTH_018_BenhAn_TongHop, IZtmp_BCTH_018_BenhAn_TongHopRepository>
    , IZtmp_BCTH_018_BenhAn_TongHopService
    {
    private readonly IZtmp_BCTH_018_BenhAn_TongHopRepository _Ztmp_BCTH_018_BenhAn_TongHopRepository;
    public Ztmp_BCTH_018_BenhAn_TongHopService(IZtmp_BCTH_018_BenhAn_TongHopRepository Ztmp_BCTH_018_BenhAn_TongHopRepository) : base(Ztmp_BCTH_018_BenhAn_TongHopRepository)
    {
    _Ztmp_BCTH_018_BenhAn_TongHopRepository = Ztmp_BCTH_018_BenhAn_TongHopRepository;
    }
    }
    }

