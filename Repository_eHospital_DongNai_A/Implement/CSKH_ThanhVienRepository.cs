namespace Repository_eHospital_DongNai_A.Implement
{
    public class CSKH_ThanhVienRepository : BaseRepository<CSKH_ThanhVien>
    , ICSKH_ThanhVienRepository
    {
    private readonly Context _context;
    public CSKH_ThanhVienRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

