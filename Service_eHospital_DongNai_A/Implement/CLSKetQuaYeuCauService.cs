namespace Service_eHospital_DongNai_A.Implement
{
    public class CLSKetQuaYeuCauService : BaseService<CLSKetQuaYeuCau, ICLSKetQuaYeuCauRepository>
    , ICLSKetQuaYeuCauService
    {
    private readonly ICLSKetQuaYeuCauRepository _CLSKetQuaYeuCauRepository;
    public CLSKetQuaYeuCauService(ICLSKetQuaYeuCauRepository CLSKetQuaYeuCauRepository) : base(CLSKetQuaYeuCauRepository)
    {
    _CLSKetQuaYeuCauRepository = CLSKetQuaYeuCauRepository;
    }
    }
    }

