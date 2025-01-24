namespace Repository_eHospital_DongNai_A.Implement
{
    public class ThoiGianYCDuoi7Gio_1_T67Repository : BaseRepository<ThoiGianYCDuoi7Gio_1_T67>
    , IThoiGianYCDuoi7Gio_1_T67Repository
    {
    private readonly Context _context;
    public ThoiGianYCDuoi7Gio_1_T67Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

