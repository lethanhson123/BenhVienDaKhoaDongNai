namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_BacSi_DichVuRepository : BaseRepository<DM_BacSi_DichVu>
    , IDM_BacSi_DichVuRepository
    {
    private readonly Context _context;
    public DM_BacSi_DichVuRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

