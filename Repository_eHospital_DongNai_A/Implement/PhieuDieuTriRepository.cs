namespace Repository_eHospital_DongNai_A.Implement
{
    public class PhieuDieuTriRepository : BaseRepository<PhieuDieuTri>
    , IPhieuDieuTriRepository
    {
    private readonly Context _context;
    public PhieuDieuTriRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

