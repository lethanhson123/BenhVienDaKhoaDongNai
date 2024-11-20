namespace Repository.Implement
{
    public class ThanhVienDichVuRepository : BaseRepository<ThanhVienDichVu>
    , IThanhVienDichVuRepository
    {
    private readonly Data.Context.Context _context;
    public ThanhVienDichVuRepository(Data.Context.Context context) : base(context)
    {
    _context = context;
    }
    }
    }

