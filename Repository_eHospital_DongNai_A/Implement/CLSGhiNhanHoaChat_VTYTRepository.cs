namespace Repository_eHospital_DongNai_A.Implement
{
    public class CLSGhiNhanHoaChat_VTYTRepository : BaseRepository<CLSGhiNhanHoaChat_VTYT>
    , ICLSGhiNhanHoaChat_VTYTRepository
    {
    private readonly Context _context;
    public CLSGhiNhanHoaChat_VTYTRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

