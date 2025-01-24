namespace Service_eHospital_DongNai_A.Implement
{
    public class zzzPhongBanService : BaseService<zzzPhongBan, IzzzPhongBanRepository>
    , IzzzPhongBanService
    {
    private readonly IzzzPhongBanRepository _zzzPhongBanRepository;
    public zzzPhongBanService(IzzzPhongBanRepository zzzPhongBanRepository) : base(zzzPhongBanRepository)
    {
    _zzzPhongBanRepository = zzzPhongBanRepository;
    }
    }
    }

