namespace Repository_eHospital_DongNai_A.Implement
{
    public class MienGiamChiTietRepository : BaseRepository<MienGiamChiTiet>
    , IMienGiamChiTietRepository
    {
    private readonly Context _context;
    public MienGiamChiTietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

