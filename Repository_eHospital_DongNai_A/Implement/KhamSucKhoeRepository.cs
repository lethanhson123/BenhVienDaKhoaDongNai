namespace Repository_eHospital_DongNai_A.Implement
{
    public class KhamSucKhoeRepository : BaseRepository<KhamSucKhoe>
    , IKhamSucKhoeRepository
    {
    private readonly Context _context;
    public KhamSucKhoeRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

