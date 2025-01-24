namespace Repository_eHospital_DongNai_A.Implement
{
    public class TiepNhan_ThuocUngThuRepository : BaseRepository<TiepNhan_ThuocUngThu>
    , ITiepNhan_ThuocUngThuRepository
    {
    private readonly Context _context;
    public TiepNhan_ThuocUngThuRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

