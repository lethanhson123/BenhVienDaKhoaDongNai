namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_TinhTrangQuanHeRepository : BaseRepository<NS_DM_TinhTrangQuanHe>
    , INS_DM_TinhTrangQuanHeRepository
    {
    private readonly Context _context;
    public NS_DM_TinhTrangQuanHeRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

