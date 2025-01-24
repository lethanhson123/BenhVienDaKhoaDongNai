namespace Repository_eHospital_DongNai_A.Implement
{
    public class PhacDoDieuTri_BNRepository : BaseRepository<PhacDoDieuTri_BN>
    , IPhacDoDieuTri_BNRepository
    {
    private readonly Context _context;
    public PhacDoDieuTri_BNRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

