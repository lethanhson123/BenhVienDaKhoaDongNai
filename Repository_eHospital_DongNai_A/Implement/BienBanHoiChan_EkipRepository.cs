namespace Repository_eHospital_DongNai_A.Implement
{
    public class BienBanHoiChan_EkipRepository : BaseRepository<BienBanHoiChan_Ekip>
    , IBienBanHoiChan_EkipRepository
    {
    private readonly Context _context;
    public BienBanHoiChan_EkipRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

