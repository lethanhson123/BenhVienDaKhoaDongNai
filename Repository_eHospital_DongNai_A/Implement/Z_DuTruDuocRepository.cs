namespace Repository_eHospital_DongNai_A.Implement
{
    public class Z_DuTruDuocRepository : BaseRepository<Z_DuTruDuoc>
    , IZ_DuTruDuocRepository
    {
    private readonly Context _context;
    public Z_DuTruDuocRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

