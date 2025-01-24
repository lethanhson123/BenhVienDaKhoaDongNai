namespace Repository_eHospital_DongNai_A.Implement
{
    public class TiepNhanCapCuuChiTietRepository : BaseRepository<TiepNhanCapCuuChiTiet>
    , ITiepNhanCapCuuChiTietRepository
    {
    private readonly Context _context;
    public TiepNhanCapCuuChiTietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

