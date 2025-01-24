namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_KeHoachDeAn_1816Repository : BaseRepository<DM_KeHoachDeAn_1816>
    , IDM_KeHoachDeAn_1816Repository
    {
    private readonly Context _context;
    public DM_KeHoachDeAn_1816Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

