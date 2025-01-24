namespace Repository_eHospital_DongNai_A.Implement
{
    public class HOADON_PAYRESULTRepository : BaseRepository<HOADON_PAYRESULT>
    , IHOADON_PAYRESULTRepository
    {
    private readonly Context _context;
    public HOADON_PAYRESULTRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

