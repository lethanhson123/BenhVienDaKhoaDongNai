namespace Repository_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_BangGia_CPHRepository : BaseRepository<DM_BangGia_CPH>
    , IDM_BangGia_CPHRepository
    {
    private readonly Context _context;
    public DM_BangGia_CPHRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

