namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAn_PhauThuatTrongMiengRepository : BaseRepository<BenhAn_PhauThuatTrongMieng>
    , IBenhAn_PhauThuatTrongMiengRepository
    {
    private readonly Context _context;
    public BenhAn_PhauThuatTrongMiengRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

