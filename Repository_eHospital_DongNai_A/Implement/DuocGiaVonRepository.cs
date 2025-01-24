namespace Repository_eHospital_DongNai_A.Implement
{
    public class DuocGiaVonRepository : BaseRepository<DuocGiaVon>
    , IDuocGiaVonRepository
    {
    private readonly Context _context;
    public DuocGiaVonRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

