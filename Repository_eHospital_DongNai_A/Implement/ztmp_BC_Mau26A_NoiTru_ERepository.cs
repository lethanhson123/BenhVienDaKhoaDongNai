namespace Repository_eHospital_DongNai_A.Implement
{
    public class ztmp_BC_Mau26A_NoiTru_ERepository : BaseRepository<ztmp_BC_Mau26A_NoiTru_E>
    , Iztmp_BC_Mau26A_NoiTru_ERepository
    {
    private readonly Context _context;
    public ztmp_BC_Mau26A_NoiTru_ERepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

