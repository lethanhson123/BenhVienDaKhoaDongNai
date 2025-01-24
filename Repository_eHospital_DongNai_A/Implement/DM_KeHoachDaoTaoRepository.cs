namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_KeHoachDaoTaoRepository : BaseRepository<DM_KeHoachDaoTao>
    , IDM_KeHoachDaoTaoRepository
    {
    private readonly Context _context;
    public DM_KeHoachDaoTaoRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

