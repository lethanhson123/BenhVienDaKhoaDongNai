namespace Repository_eHospital_DongNai_A.Implement
{
    public class CSKH_The_GiamGiaRepository : BaseRepository<CSKH_The_GiamGia>
    , ICSKH_The_GiamGiaRepository
    {
    private readonly Context _context;
    public CSKH_The_GiamGiaRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

