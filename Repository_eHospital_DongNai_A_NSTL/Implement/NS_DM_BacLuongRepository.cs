namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_BacLuongRepository : BaseRepository<NS_DM_BacLuong>
    , INS_DM_BacLuongRepository
    {
    private readonly Context _context;
    public NS_DM_BacLuongRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

