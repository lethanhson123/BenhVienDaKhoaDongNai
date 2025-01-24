namespace Repository_eHospital_DongNai_A.Implement
{
    public class VienPhiNoiTru_Loai_IDRefRepository : BaseRepository<VienPhiNoiTru_Loai_IDRef>
    , IVienPhiNoiTru_Loai_IDRefRepository
    {
    private readonly Context _context;
    public VienPhiNoiTru_Loai_IDRefRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

