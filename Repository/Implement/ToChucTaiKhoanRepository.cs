namespace Repository.Implement
{
    public class ToChucTaiKhoanRepository : BaseRepository<ToChucTaiKhoan>
    , IToChucTaiKhoanRepository
    {
    private readonly Data.Context.Context _context;
    public ToChucTaiKhoanRepository(Data.Context.Context context) : base(context)
    {
    _context = context;
    }
    }
    }

