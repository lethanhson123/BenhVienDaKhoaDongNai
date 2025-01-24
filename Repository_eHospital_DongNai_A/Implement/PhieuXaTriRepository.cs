namespace Repository_eHospital_DongNai_A.Implement
{
    public class PhieuXaTriRepository : BaseRepository<PhieuXaTri>
    , IPhieuXaTriRepository
    {
    private readonly Context _context;
    public PhieuXaTriRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

