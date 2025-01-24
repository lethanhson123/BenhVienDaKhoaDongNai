namespace Service_eHospital_DongNai_A.Implement
{
    public class ToaThuocMauService : BaseService<ToaThuocMau, IToaThuocMauRepository>
    , IToaThuocMauService
    {
    private readonly IToaThuocMauRepository _ToaThuocMauRepository;
    public ToaThuocMauService(IToaThuocMauRepository ToaThuocMauRepository) : base(ToaThuocMauRepository)
    {
    _ToaThuocMauRepository = ToaThuocMauRepository;
    }
    }
    }

