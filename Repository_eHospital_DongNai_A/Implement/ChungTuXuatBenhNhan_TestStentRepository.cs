namespace Repository_eHospital_DongNai_A.Implement
{
    public class ChungTuXuatBenhNhan_TestStentRepository : BaseRepository<ChungTuXuatBenhNhan_TestStent>
    , IChungTuXuatBenhNhan_TestStentRepository
    {
    private readonly Context _context;
    public ChungTuXuatBenhNhan_TestStentRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

