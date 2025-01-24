namespace Service_eHospital_DongNai_A.Implement
{
    public class CLSKetQuaMauService : BaseService<CLSKetQuaMau, ICLSKetQuaMauRepository>
    , ICLSKetQuaMauService
    {
    private readonly ICLSKetQuaMauRepository _CLSKetQuaMauRepository;
    public CLSKetQuaMauService(ICLSKetQuaMauRepository CLSKetQuaMauRepository) : base(CLSKetQuaMauRepository)
    {
    _CLSKetQuaMauRepository = CLSKetQuaMauRepository;
    }
    }
    }

