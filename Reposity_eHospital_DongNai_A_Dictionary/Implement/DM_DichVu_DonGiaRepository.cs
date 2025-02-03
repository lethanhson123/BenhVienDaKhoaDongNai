namespace Repository_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_DichVu_DonGiaRepository : BaseRepository<DM_DichVu_DonGia>
    , IDM_DichVu_DonGiaRepository
    {
    private readonly Context _context;
    public DM_DichVu_DonGiaRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

