namespace Repository_eHospital_DongNai_A.Implement
{
    public class MienGiamNoiTruChiTietRepository : BaseRepository<MienGiamNoiTruChiTiet>
    , IMienGiamNoiTruChiTietRepository
    {
    private readonly Context _context;
    public MienGiamNoiTruChiTietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

