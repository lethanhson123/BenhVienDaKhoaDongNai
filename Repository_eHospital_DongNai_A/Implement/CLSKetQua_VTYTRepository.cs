namespace Repository_eHospital_DongNai_A.Implement
{
    public class CLSKetQua_VTYTRepository : BaseRepository<CLSKetQua_VTYT>
    , ICLSKetQua_VTYTRepository
    {
    private readonly Context _context;
    public CLSKetQua_VTYTRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

