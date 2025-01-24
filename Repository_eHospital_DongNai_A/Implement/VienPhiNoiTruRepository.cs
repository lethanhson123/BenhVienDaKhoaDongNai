namespace Repository_eHospital_DongNai_A.Implement
{
    public class VienPhiNoiTruRepository : BaseRepository<VienPhiNoiTru>
    , IVienPhiNoiTruRepository
    {
    private readonly Context _context;
    public VienPhiNoiTruRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

