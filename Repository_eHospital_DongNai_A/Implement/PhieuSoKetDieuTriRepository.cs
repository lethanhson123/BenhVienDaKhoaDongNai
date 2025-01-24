namespace Repository_eHospital_DongNai_A.Implement
{
    public class PhieuSoKetDieuTriRepository : BaseRepository<PhieuSoKetDieuTri>
    , IPhieuSoKetDieuTriRepository
    {
    private readonly Context _context;
    public PhieuSoKetDieuTriRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

