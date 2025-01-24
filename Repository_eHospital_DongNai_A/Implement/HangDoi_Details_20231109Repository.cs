namespace Repository_eHospital_DongNai_A.Implement
{
    public class HangDoi_Details_20231109Repository : BaseRepository<HangDoi_Details_20231109>
    , IHangDoi_Details_20231109Repository
    {
    private readonly Context _context;
    public HangDoi_Details_20231109Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

