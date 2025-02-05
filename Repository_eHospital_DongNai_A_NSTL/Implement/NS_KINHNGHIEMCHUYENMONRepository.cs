namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_KINHNGHIEMCHUYENMONRepository : BaseRepository<NS_KINHNGHIEMCHUYENMON>
    , INS_KINHNGHIEMCHUYENMONRepository
    {
    private readonly Context _context;
    public NS_KINHNGHIEMCHUYENMONRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

