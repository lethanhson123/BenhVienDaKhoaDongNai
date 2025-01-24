namespace Repository_eHospital_DongNai_A.Implement
{
    public class DMDuocRepository : BaseRepository<DMDuoc>
    , IDMDuocRepository
    {
    private readonly Context _context;
    public DMDuocRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

