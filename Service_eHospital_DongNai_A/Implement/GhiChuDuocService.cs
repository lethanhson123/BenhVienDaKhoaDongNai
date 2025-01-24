namespace Service_eHospital_DongNai_A.Implement
{
    public class GhiChuDuocService : BaseService<GhiChuDuoc, IGhiChuDuocRepository>
    , IGhiChuDuocService
    {
    private readonly IGhiChuDuocRepository _GhiChuDuocRepository;
    public GhiChuDuocService(IGhiChuDuocRepository GhiChuDuocRepository) : base(GhiChuDuocRepository)
    {
    _GhiChuDuocRepository = GhiChuDuocRepository;
    }
    }
    }

