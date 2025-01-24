namespace Repository_eHospital_DongNai_A.Implement
{
    public class KhamBenh_ThayDoiRepository : BaseRepository<KhamBenh_ThayDoi>
    , IKhamBenh_ThayDoiRepository
    {
    private readonly Context _context;
    public KhamBenh_ThayDoiRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

