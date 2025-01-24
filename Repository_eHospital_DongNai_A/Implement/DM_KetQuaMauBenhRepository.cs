namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_KetQuaMauBenhRepository : BaseRepository<DM_KetQuaMauBenh>
    , IDM_KetQuaMauBenhRepository
    {
    private readonly Context _context;
    public DM_KetQuaMauBenhRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

