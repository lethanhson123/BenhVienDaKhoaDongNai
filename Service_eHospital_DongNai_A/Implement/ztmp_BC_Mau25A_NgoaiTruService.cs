namespace Service_eHospital_DongNai_A.Implement
{
    public class ztmp_BC_Mau25A_NgoaiTruService : BaseService<ztmp_BC_Mau25A_NgoaiTru, Iztmp_BC_Mau25A_NgoaiTruRepository>
    , Iztmp_BC_Mau25A_NgoaiTruService
    {
    private readonly Iztmp_BC_Mau25A_NgoaiTruRepository _ztmp_BC_Mau25A_NgoaiTruRepository;
    public ztmp_BC_Mau25A_NgoaiTruService(Iztmp_BC_Mau25A_NgoaiTruRepository ztmp_BC_Mau25A_NgoaiTruRepository) : base(ztmp_BC_Mau25A_NgoaiTruRepository)
    {
    _ztmp_BC_Mau25A_NgoaiTruRepository = ztmp_BC_Mau25A_NgoaiTruRepository;
    }
    }
    }

