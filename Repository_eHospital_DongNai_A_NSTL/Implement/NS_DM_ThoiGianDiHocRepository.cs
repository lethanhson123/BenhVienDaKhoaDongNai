namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_ThoiGianDiHocRepository : BaseRepository<NS_DM_ThoiGianDiHoc>
    , INS_DM_ThoiGianDiHocRepository
    {
    private readonly Context _context;
    public NS_DM_ThoiGianDiHocRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

