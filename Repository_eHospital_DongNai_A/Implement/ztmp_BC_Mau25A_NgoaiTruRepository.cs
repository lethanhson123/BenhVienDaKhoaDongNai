namespace Repository_eHospital_DongNai_A.Implement
{
    public class ztmp_BC_Mau25A_NgoaiTruRepository : BaseRepository<ztmp_BC_Mau25A_NgoaiTru>
    , Iztmp_BC_Mau25A_NgoaiTruRepository
    {
    private readonly Context _context;
    public ztmp_BC_Mau25A_NgoaiTruRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

