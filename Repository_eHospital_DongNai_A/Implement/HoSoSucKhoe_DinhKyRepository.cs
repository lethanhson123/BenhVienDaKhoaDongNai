namespace Repository_eHospital_DongNai_A.Implement
{
    public class HoSoSucKhoe_DinhKyRepository : BaseRepository<HoSoSucKhoe_DinhKy>
    , IHoSoSucKhoe_DinhKyRepository
    {
    private readonly Context _context;
    public HoSoSucKhoe_DinhKyRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

