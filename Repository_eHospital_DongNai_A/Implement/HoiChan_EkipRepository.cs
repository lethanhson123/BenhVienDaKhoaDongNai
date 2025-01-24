namespace Repository_eHospital_DongNai_A.Implement
{
    public class HoiChan_EkipRepository : BaseRepository<HoiChan_Ekip>
    , IHoiChan_EkipRepository
    {
    private readonly Context _context;
    public HoiChan_EkipRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

