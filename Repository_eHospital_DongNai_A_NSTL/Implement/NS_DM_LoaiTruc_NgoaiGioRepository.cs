namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_LoaiTruc_NgoaiGioRepository : BaseRepository<NS_DM_LoaiTruc_NgoaiGio>
    , INS_DM_LoaiTruc_NgoaiGioRepository
    {
    private readonly Context _context;
    public NS_DM_LoaiTruc_NgoaiGioRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

