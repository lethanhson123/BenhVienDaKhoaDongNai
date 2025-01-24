namespace Repository_eHospital_DongNai_A.Implement
{
    public class ChungTuSoLoNhap_Delete20230518Repository : BaseRepository<ChungTuSoLoNhap_Delete20230518>
    , IChungTuSoLoNhap_Delete20230518Repository
    {
    private readonly Context _context;
    public ChungTuSoLoNhap_Delete20230518Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

