namespace Service_eHospital_DongNai_A.Implement
{
    public class zzzDonViHanhChanhzzzService : BaseService<zzzDonViHanhChanhzzz, IzzzDonViHanhChanhzzzRepository>
    , IzzzDonViHanhChanhzzzService
    {
    private readonly IzzzDonViHanhChanhzzzRepository _zzzDonViHanhChanhzzzRepository;
    public zzzDonViHanhChanhzzzService(IzzzDonViHanhChanhzzzRepository zzzDonViHanhChanhzzzRepository) : base(zzzDonViHanhChanhzzzRepository)
    {
    _zzzDonViHanhChanhzzzRepository = zzzDonViHanhChanhzzzRepository;
    }
    }
    }

