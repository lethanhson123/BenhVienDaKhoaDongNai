namespace Repository_eHospital_DongNai_A.Implement
{
    public class CLSKetQua_XetNghiemRepository : BaseRepository<CLSKetQua_XetNghiem>
    , ICLSKetQua_XetNghiemRepository
    {
    private readonly Context _context;
    public CLSKetQua_XetNghiemRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

