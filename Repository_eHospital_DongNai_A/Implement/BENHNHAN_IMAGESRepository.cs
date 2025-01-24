namespace Repository_eHospital_DongNai_A.Implement
{
    public class BENHNHAN_IMAGESRepository : BaseRepository<BENHNHAN_IMAGES>
    , IBENHNHAN_IMAGESRepository
    {
    private readonly Context _context;
    public BENHNHAN_IMAGESRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

