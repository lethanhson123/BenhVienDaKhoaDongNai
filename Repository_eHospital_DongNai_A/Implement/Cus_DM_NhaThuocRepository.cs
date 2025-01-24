namespace Repository_eHospital_DongNai_A.Implement
{
    public class Cus_DM_NhaThuocRepository : BaseRepository<Cus_DM_NhaThuoc>
    , ICus_DM_NhaThuocRepository
    {
    private readonly Context _context;
    public Cus_DM_NhaThuocRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

