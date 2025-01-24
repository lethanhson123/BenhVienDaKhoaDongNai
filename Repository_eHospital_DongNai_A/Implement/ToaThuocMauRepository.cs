namespace Repository_eHospital_DongNai_A.Implement
{
    public class ToaThuocMauRepository : BaseRepository<ToaThuocMau>
    , IToaThuocMauRepository
    {
    private readonly Context _context;
    public ToaThuocMauRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

