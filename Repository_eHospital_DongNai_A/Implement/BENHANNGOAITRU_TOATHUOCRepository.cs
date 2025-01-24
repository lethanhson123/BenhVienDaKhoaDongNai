namespace Repository_eHospital_DongNai_A.Implement
{
    public class BENHANNGOAITRU_TOATHUOCRepository : BaseRepository<BENHANNGOAITRU_TOATHUOC>
    , IBENHANNGOAITRU_TOATHUOCRepository
    {
    private readonly Context _context;
    public BENHANNGOAITRU_TOATHUOCRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

