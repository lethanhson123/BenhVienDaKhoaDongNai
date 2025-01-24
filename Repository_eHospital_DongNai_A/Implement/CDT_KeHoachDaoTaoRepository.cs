namespace Repository_eHospital_DongNai_A.Implement
{
    public class CDT_KeHoachDaoTaoRepository : BaseRepository<CDT_KeHoachDaoTao>
    , ICDT_KeHoachDaoTaoRepository
    {
    private readonly Context _context;
    public CDT_KeHoachDaoTaoRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

