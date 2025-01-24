namespace Repository_eHospital_DongNai_A.Implement
{
    public class CDT_KSK_PhanLoaiNhomBenhRepository : BaseRepository<CDT_KSK_PhanLoaiNhomBenh>
    , ICDT_KSK_PhanLoaiNhomBenhRepository
    {
    private readonly Context _context;
    public CDT_KSK_PhanLoaiNhomBenhRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

