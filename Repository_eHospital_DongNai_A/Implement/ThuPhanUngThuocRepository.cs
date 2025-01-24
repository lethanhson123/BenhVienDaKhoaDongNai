namespace Repository_eHospital_DongNai_A.Implement
{
    public class ThuPhanUngThuocRepository : BaseRepository<ThuPhanUngThuoc>
    , IThuPhanUngThuocRepository
    {
    private readonly Context _context;
    public ThuPhanUngThuocRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

