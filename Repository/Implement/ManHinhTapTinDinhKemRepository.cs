namespace Repository.Implement
{
    public class ManHinhTapTinDinhKemRepository : BaseRepository<ManHinhTapTinDinhKem>
    , IManHinhTapTinDinhKemRepository
    {
    private readonly Data.Context.Context _context;
    public ManHinhTapTinDinhKemRepository(Data.Context.Context context) : base(context)
    {
    _context = context;
    }
    }
    }

