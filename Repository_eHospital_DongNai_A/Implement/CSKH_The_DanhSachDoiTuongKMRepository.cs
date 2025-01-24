namespace Repository_eHospital_DongNai_A.Implement
{
    public class CSKH_The_DanhSachDoiTuongKMRepository : BaseRepository<CSKH_The_DanhSachDoiTuongKM>
    , ICSKH_The_DanhSachDoiTuongKMRepository
    {
    private readonly Context _context;
    public CSKH_The_DanhSachDoiTuongKMRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

