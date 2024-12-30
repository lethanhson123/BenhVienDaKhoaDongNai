namespace Repository.Implement
{
    public class KhamSucKhoeRepository : BaseRepository<KhamSucKhoe>
    , IKhamSucKhoeRepository
    {
    private readonly Data.Context.Context _context;
    public KhamSucKhoeRepository(Data.Context.Context context) : base(context)
    {
    _context = context;
    }
    }
    }

