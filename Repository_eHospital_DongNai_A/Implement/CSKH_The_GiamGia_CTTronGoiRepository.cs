namespace Repository_eHospital_DongNai_A.Implement
{
    public class CSKH_The_GiamGia_CTTronGoiRepository : BaseRepository<CSKH_The_GiamGia_CTTronGoi>
    , ICSKH_The_GiamGia_CTTronGoiRepository
    {
    private readonly Context _context;
    public CSKH_The_GiamGia_CTTronGoiRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

