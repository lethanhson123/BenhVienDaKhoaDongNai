namespace Repository_eHospital_DongNai_A.Implement
{
    public class cus_BacSiKham_TimeRepository : BaseRepository<cus_BacSiKham_Time>
    , Icus_BacSiKham_TimeRepository
    {
    private readonly Context _context;
    public cus_BacSiKham_TimeRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

