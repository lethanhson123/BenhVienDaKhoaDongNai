namespace Repository_eHospital_DongNai_A.Implement
{
    public class HoSoSucKhoe_DinhKy_ChitietRepository : BaseRepository<HoSoSucKhoe_DinhKy_Chitiet>
    , IHoSoSucKhoe_DinhKy_ChitietRepository
    {
    private readonly Context _context;
    public HoSoSucKhoe_DinhKy_ChitietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

