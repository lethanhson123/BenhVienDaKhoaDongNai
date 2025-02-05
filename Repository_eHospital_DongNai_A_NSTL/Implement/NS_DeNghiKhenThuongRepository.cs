namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DeNghiKhenThuongRepository : BaseRepository<NS_DeNghiKhenThuong>
    , INS_DeNghiKhenThuongRepository
    {
    private readonly Context _context;
    public NS_DeNghiKhenThuongRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

