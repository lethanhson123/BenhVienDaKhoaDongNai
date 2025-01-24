namespace Repository_eHospital_DongNai_A.Implement
{
    public class CLSBenhPhamRepository : BaseRepository<CLSBenhPham>
    , ICLSBenhPhamRepository
    {
    private readonly Context _context;
    public CLSBenhPhamRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

