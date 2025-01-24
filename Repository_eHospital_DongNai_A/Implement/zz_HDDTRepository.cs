namespace Repository_eHospital_DongNai_A.Implement
{
    public class zz_HDDTRepository : BaseRepository<zz_HDDT>
    , Izz_HDDTRepository
    {
    private readonly Context _context;
    public zz_HDDTRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

