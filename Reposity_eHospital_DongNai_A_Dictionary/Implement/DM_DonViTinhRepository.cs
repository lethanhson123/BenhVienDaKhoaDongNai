namespace Repository_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_DonViTinhRepository : BaseRepository<DM_DonViTinh>
    , IDM_DonViTinhRepository
    {
    private readonly Context _context;
    public DM_DonViTinhRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

