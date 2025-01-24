namespace Repository_eHospital_DongNai_A.Implement
{
    public class DuocKhoaSoChungTuRepository : BaseRepository<DuocKhoaSoChungTu>
    , IDuocKhoaSoChungTuRepository
    {
    private readonly Context _context;
    public DuocKhoaSoChungTuRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

