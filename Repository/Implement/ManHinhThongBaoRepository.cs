namespace Repository.Implement
{
    public class ManHinhThongBaoRepository : BaseRepository<ManHinhThongBao>
    , IManHinhThongBaoRepository
    {
    private readonly Data.Context.Context _context;
    public ManHinhThongBaoRepository(Data.Context.Context context) : base(context)
    {
    _context = context;
    }
    }
    }

