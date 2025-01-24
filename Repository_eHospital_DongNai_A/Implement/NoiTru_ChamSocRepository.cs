namespace Repository_eHospital_DongNai_A.Implement
{
    public class NoiTru_ChamSocRepository : BaseRepository<NoiTru_ChamSoc>
    , INoiTru_ChamSocRepository
    {
    private readonly Context _context;
    public NoiTru_ChamSocRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

