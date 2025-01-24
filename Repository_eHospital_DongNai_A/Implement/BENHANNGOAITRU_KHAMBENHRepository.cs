namespace Repository_eHospital_DongNai_A.Implement
{
    public class BENHANNGOAITRU_KHAMBENHRepository : BaseRepository<BENHANNGOAITRU_KHAMBENH>
    , IBENHANNGOAITRU_KHAMBENHRepository
    {
    private readonly Context _context;
    public BENHANNGOAITRU_KHAMBENHRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

