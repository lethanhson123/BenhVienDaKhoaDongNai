namespace Repository_eHospital_DongNai_A.Implement
{
    public class TomTatHoSoBenhAnRepository : BaseRepository<TomTatHoSoBenhAn>
    , ITomTatHoSoBenhAnRepository
    {
    private readonly Context _context;
    public TomTatHoSoBenhAnRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

