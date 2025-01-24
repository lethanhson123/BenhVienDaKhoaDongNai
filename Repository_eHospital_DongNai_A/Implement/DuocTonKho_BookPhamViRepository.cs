namespace Repository_eHospital_DongNai_A.Implement
{
    public class DuocTonKho_BookPhamViRepository : BaseRepository<DuocTonKho_BookPhamVi>
    , IDuocTonKho_BookPhamViRepository
    {
    private readonly Context _context;
    public DuocTonKho_BookPhamViRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

