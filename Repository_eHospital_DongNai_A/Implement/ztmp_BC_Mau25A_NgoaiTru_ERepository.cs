namespace Repository_eHospital_DongNai_A.Implement
{
    public class ztmp_BC_Mau25A_NgoaiTru_ERepository : BaseRepository<ztmp_BC_Mau25A_NgoaiTru_E>
    , Iztmp_BC_Mau25A_NgoaiTru_ERepository
    {
    private readonly Context _context;
    public ztmp_BC_Mau25A_NgoaiTru_ERepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

