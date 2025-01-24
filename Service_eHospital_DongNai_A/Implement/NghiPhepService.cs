namespace Service_eHospital_DongNai_A.Implement
{
    public class NghiPhepService : BaseService<NghiPhep, INghiPhepRepository>
    , INghiPhepService
    {
    private readonly INghiPhepRepository _NghiPhepRepository;
    public NghiPhepService(INghiPhepRepository NghiPhepRepository) : base(NghiPhepRepository)
    {
    _NghiPhepRepository = NghiPhepRepository;
    }
    }
    }

