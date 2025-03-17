namespace Repository.Implement
{
    public class DanhMucQRCodeRepository : BaseRepository<DanhMucQRCode>
    , IDanhMucQRCodeRepository
    {
    private readonly Data.Context.Context _context;
    public DanhMucQRCodeRepository(Data.Context.Context context) : base(context)
    {
    _context = context;
    }
    }
    }

