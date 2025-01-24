namespace Repository_eHospital_DongNai_A.Implement
{
    public class NoiTru_ChamSocDichTruyenRepository : BaseRepository<NoiTru_ChamSocDichTruyen>
    , INoiTru_ChamSocDichTruyenRepository
    {
    private readonly Context _context;
    public NoiTru_ChamSocDichTruyenRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

