namespace Repository_eHospital_DongNai_A.Implement
{
    public class Lst_KeyData_DuocPhamRepository : BaseRepository<Lst_KeyData_DuocPham>
    , ILst_KeyData_DuocPhamRepository
    {
    private readonly Context _context;
    public Lst_KeyData_DuocPhamRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

