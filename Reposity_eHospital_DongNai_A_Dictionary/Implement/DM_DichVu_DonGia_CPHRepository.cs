namespace Repository_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_DichVu_DonGia_CPHRepository : BaseRepository<DM_DichVu_DonGia_CPH>
    , IDM_DichVu_DonGia_CPHRepository
    {
    private readonly Context _context;
    public DM_DichVu_DonGia_CPHRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

