namespace Service_eHospital_DongNai_A.Implement
{
    public class CLSKetQuaXNHuyet_TuyDoService : BaseService<CLSKetQuaXNHuyet_TuyDo, ICLSKetQuaXNHuyet_TuyDoRepository>
    , ICLSKetQuaXNHuyet_TuyDoService
    {
    private readonly ICLSKetQuaXNHuyet_TuyDoRepository _CLSKetQuaXNHuyet_TuyDoRepository;
    public CLSKetQuaXNHuyet_TuyDoService(ICLSKetQuaXNHuyet_TuyDoRepository CLSKetQuaXNHuyet_TuyDoRepository) : base(CLSKetQuaXNHuyet_TuyDoRepository)
    {
    _CLSKetQuaXNHuyet_TuyDoRepository = CLSKetQuaXNHuyet_TuyDoRepository;
    }
    }
    }

