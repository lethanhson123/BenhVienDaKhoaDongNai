namespace Repository_eHospital_DongNai_A.Implement
{
    public class ThuPhanUngThuocCoHaiRepository : BaseRepository<ThuPhanUngThuocCoHai>
    , IThuPhanUngThuocCoHaiRepository
    {
    private readonly Context _context;
    public ThuPhanUngThuocCoHaiRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

