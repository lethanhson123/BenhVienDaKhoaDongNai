namespace Service_eHospital_DongNai_A.Implement
{
    public class ztmp_BC_Mau26A_NoiTru_EService : BaseService<ztmp_BC_Mau26A_NoiTru_E, Iztmp_BC_Mau26A_NoiTru_ERepository>
    , Iztmp_BC_Mau26A_NoiTru_EService
    {
    private readonly Iztmp_BC_Mau26A_NoiTru_ERepository _ztmp_BC_Mau26A_NoiTru_ERepository;
    public ztmp_BC_Mau26A_NoiTru_EService(Iztmp_BC_Mau26A_NoiTru_ERepository ztmp_BC_Mau26A_NoiTru_ERepository) : base(ztmp_BC_Mau26A_NoiTru_ERepository)
    {
    _ztmp_BC_Mau26A_NoiTru_ERepository = ztmp_BC_Mau26A_NoiTru_ERepository;
    }
    }
    }

