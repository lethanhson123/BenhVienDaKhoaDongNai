namespace Repository_eHospital_DongNai_A.Implement
{
    public class NoiTru_DichVuRepository : BaseRepository<NoiTru_DichVu>
    , INoiTru_DichVuRepository
    {
    private readonly Context _context;
    public NoiTru_DichVuRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

