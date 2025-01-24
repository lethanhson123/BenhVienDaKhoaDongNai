namespace Repository_eHospital_DongNai_A.Implement
{
    public class cus_PhongKham_TimeRepository : BaseRepository<cus_PhongKham_Time>
    , Icus_PhongKham_TimeRepository
    {
    private readonly Context _context;
    public cus_PhongKham_TimeRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

