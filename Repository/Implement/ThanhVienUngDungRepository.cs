namespace Repository.Implement
{
    public class ThanhVienUngDungRepository : BaseRepository<ThanhVienUngDung>
    , IThanhVienUngDungRepository
    {
    private readonly Data.Context.Context _context;
    public ThanhVienUngDungRepository(Data.Context.Context context) : base(context)
    {
    _context = context;
    }
    }
    }

