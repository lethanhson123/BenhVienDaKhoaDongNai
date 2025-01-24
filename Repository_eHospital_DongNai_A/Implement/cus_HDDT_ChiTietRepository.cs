namespace Repository_eHospital_DongNai_A.Implement
{
    public class cus_HDDT_ChiTietRepository : BaseRepository<cus_HDDT_ChiTiet>
    , Icus_HDDT_ChiTietRepository
    {
    private readonly Context _context;
    public cus_HDDT_ChiTietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

