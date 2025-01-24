namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_Duoc_CanhBaoRepository : BaseRepository<DM_Duoc_CanhBao>
    , IDM_Duoc_CanhBaoRepository
    {
    private readonly Context _context;
    public DM_Duoc_CanhBaoRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

