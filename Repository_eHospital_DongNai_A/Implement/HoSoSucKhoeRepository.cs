namespace Repository_eHospital_DongNai_A.Implement
{
    public class HoSoSucKhoeRepository : BaseRepository<HoSoSucKhoe>
    , IHoSoSucKhoeRepository
    {
    private readonly Context _context;
    public HoSoSucKhoeRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

