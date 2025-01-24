namespace Service_eHospital_DongNai_A.Implement
{
    public class ztmp_BC_Mau25A_NgoaiTru_EService : BaseService<ztmp_BC_Mau25A_NgoaiTru_E, Iztmp_BC_Mau25A_NgoaiTru_ERepository>
    , Iztmp_BC_Mau25A_NgoaiTru_EService
    {
    private readonly Iztmp_BC_Mau25A_NgoaiTru_ERepository _ztmp_BC_Mau25A_NgoaiTru_ERepository;
    public ztmp_BC_Mau25A_NgoaiTru_EService(Iztmp_BC_Mau25A_NgoaiTru_ERepository ztmp_BC_Mau25A_NgoaiTru_ERepository) : base(ztmp_BC_Mau25A_NgoaiTru_ERepository)
    {
    _ztmp_BC_Mau25A_NgoaiTru_ERepository = ztmp_BC_Mau25A_NgoaiTru_ERepository;
    }
    }
    }

