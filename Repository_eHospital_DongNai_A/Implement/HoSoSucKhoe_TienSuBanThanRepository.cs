namespace Repository_eHospital_DongNai_A.Implement
{
    public class HoSoSucKhoe_TienSuBanThanRepository : BaseRepository<HoSoSucKhoe_TienSuBanThan>
    , IHoSoSucKhoe_TienSuBanThanRepository
    {
    private readonly Context _context;
    public HoSoSucKhoe_TienSuBanThanRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

