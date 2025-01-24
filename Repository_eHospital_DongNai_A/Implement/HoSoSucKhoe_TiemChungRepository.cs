namespace Repository_eHospital_DongNai_A.Implement
{
    public class HoSoSucKhoe_TiemChungRepository : BaseRepository<HoSoSucKhoe_TiemChung>
    , IHoSoSucKhoe_TiemChungRepository
    {
    private readonly Context _context;
    public HoSoSucKhoe_TiemChungRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

