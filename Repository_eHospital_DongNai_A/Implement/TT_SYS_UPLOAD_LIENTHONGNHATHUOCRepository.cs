namespace Repository_eHospital_DongNai_A.Implement
{
    public class TT_SYS_UPLOAD_LIENTHONGNHATHUOCRepository : BaseRepository<TT_SYS_UPLOAD_LIENTHONGNHATHUOC>
    , ITT_SYS_UPLOAD_LIENTHONGNHATHUOCRepository
    {
    private readonly Context _context;
    public TT_SYS_UPLOAD_LIENTHONGNHATHUOCRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

