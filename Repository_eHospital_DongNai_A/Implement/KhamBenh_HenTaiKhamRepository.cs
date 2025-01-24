namespace Repository_eHospital_DongNai_A.Implement
{
    public class KhamBenh_HenTaiKhamRepository : BaseRepository<KhamBenh_HenTaiKham>
    , IKhamBenh_HenTaiKhamRepository
    {
    private readonly Context _context;
    public KhamBenh_HenTaiKhamRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

