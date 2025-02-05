namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DeNghiKhenThuongService : BaseService<NS_DeNghiKhenThuong, INS_DeNghiKhenThuongRepository>
    , INS_DeNghiKhenThuongService
    {
    private readonly INS_DeNghiKhenThuongRepository _NS_DeNghiKhenThuongRepository;
    public NS_DeNghiKhenThuongService(INS_DeNghiKhenThuongRepository NS_DeNghiKhenThuongRepository) : base(NS_DeNghiKhenThuongRepository)
    {
    _NS_DeNghiKhenThuongRepository = NS_DeNghiKhenThuongRepository;
    }
    }
    }

