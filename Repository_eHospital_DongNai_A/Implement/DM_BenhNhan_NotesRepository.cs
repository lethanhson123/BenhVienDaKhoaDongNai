namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_BenhNhan_NotesRepository : BaseRepository<DM_BenhNhan_Notes>
    , IDM_BenhNhan_NotesRepository
    {
    private readonly Context _context;
    public DM_BenhNhan_NotesRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

