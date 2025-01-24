namespace Repository_eHospital_DongNai_A.Implement
{
    public class NoiTru_GiuongBenhRepository : BaseRepository<NoiTru_GiuongBenh>
    , INoiTru_GiuongBenhRepository
    {
    private readonly Context _context;
    public NoiTru_GiuongBenhRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

