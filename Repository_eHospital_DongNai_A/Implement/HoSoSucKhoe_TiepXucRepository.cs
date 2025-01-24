namespace Repository_eHospital_DongNai_A.Implement
{
    public class HoSoSucKhoe_TiepXucRepository : BaseRepository<HoSoSucKhoe_TiepXuc>
    , IHoSoSucKhoe_TiepXucRepository
    {
    private readonly Context _context;
    public HoSoSucKhoe_TiepXucRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

