namespace Repository_eHospital_DongNai_A.Implement
{
    public class HoiChan_EKipMoRepository : BaseRepository<HoiChan_EKipMo>
    , IHoiChan_EKipMoRepository
    {
    private readonly Context _context;
    public HoiChan_EKipMoRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

