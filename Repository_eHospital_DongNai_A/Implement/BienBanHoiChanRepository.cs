namespace Repository_eHospital_DongNai_A.Implement
{
    public class BienBanHoiChanRepository : BaseRepository<BienBanHoiChan>
    , IBienBanHoiChanRepository
    {
    private readonly Context _context;
    public BienBanHoiChanRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

