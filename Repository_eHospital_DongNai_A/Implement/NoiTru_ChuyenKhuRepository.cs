namespace Repository_eHospital_DongNai_A.Implement
{
    public class NoiTru_ChuyenKhuRepository : BaseRepository<NoiTru_ChuyenKhu>
    , INoiTru_ChuyenKhuRepository
    {
    private readonly Context _context;
    public NoiTru_ChuyenKhuRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

