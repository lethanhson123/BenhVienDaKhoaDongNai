namespace Repository_eHospital_DongNai_A.Implement
{
    public class ChiPhiKCBNgoaiTru_BHYTRepository : BaseRepository<ChiPhiKCBNgoaiTru_BHYT>
    , IChiPhiKCBNgoaiTru_BHYTRepository
    {
    private readonly Context _context;
    public ChiPhiKCBNgoaiTru_BHYTRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

