namespace Repository_eHospital_DongNai_A.Implement
{
    public class CDT_KetQuaXuTriRepository : BaseRepository<CDT_KetQuaXuTri>
    , ICDT_KetQuaXuTriRepository
    {
    private readonly Context _context;
    public CDT_KetQuaXuTriRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

