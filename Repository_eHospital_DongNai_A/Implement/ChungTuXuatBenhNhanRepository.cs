namespace Repository_eHospital_DongNai_A.Implement
{
    public class ChungTuXuatBenhNhanRepository : BaseRepository<ChungTuXuatBenhNhan>
    , IChungTuXuatBenhNhanRepository
    {
    private readonly Context _context;
    public ChungTuXuatBenhNhanRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

