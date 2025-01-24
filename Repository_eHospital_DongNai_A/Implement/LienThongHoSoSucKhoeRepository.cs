namespace Repository_eHospital_DongNai_A.Implement
{
    public class LienThongHoSoSucKhoeRepository : BaseRepository<LienThongHoSoSucKhoe>
    , ILienThongHoSoSucKhoeRepository
    {
    private readonly Context _context;
    public LienThongHoSoSucKhoeRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

