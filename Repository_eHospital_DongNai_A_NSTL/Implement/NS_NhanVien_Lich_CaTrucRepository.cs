namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_NhanVien_Lich_CaTrucRepository : BaseRepository<NS_NhanVien_Lich_CaTruc>
    , INS_NhanVien_Lich_CaTrucRepository
    {
    private readonly Context _context;
    public NS_NhanVien_Lich_CaTrucRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

