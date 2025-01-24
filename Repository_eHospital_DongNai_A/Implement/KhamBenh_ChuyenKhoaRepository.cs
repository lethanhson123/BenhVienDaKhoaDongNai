namespace Repository_eHospital_DongNai_A.Implement
{
    public class KhamBenh_ChuyenKhoaRepository : BaseRepository<KhamBenh_ChuyenKhoa>
    , IKhamBenh_ChuyenKhoaRepository
    {
    private readonly Context _context;
    public KhamBenh_ChuyenKhoaRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

