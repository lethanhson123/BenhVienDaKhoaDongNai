namespace Repository_eHospital_DongNai_A.Implement
{
    public class ChiPhiKCBNoiTru_BHYTRepository : BaseRepository<ChiPhiKCBNoiTru_BHYT>
    , IChiPhiKCBNoiTru_BHYTRepository
    {
    private readonly Context _context;
    public ChiPhiKCBNoiTru_BHYTRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

