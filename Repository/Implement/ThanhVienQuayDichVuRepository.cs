namespace Repository.Implement
{
    public class ThanhVienQuayDichVuRepository : BaseRepository<ThanhVienQuayDichVu>
    , IThanhVienQuayDichVuRepository
    {
    private readonly Data.Context.Context _context;
    public ThanhVienQuayDichVuRepository(Data.Context.Context context) : base(context)
    {
    _context = context;
    }
    }
    }

