namespace Repository_eHospital_DongNai_A.Implement
{
    public class KhamBenh_BNDangKhamRepository : BaseRepository<KhamBenh_BNDangKham>
    , IKhamBenh_BNDangKhamRepository
    {
    private readonly Context _context;
    public KhamBenh_BNDangKhamRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

