namespace Service_eHospital_DongNai_A.Implement
{
    public class CLSKetQuaXNHuyet_TuyDo_ChiTietService : BaseService<CLSKetQuaXNHuyet_TuyDo_ChiTiet, ICLSKetQuaXNHuyet_TuyDo_ChiTietRepository>
    , ICLSKetQuaXNHuyet_TuyDo_ChiTietService
    {
    private readonly ICLSKetQuaXNHuyet_TuyDo_ChiTietRepository _CLSKetQuaXNHuyet_TuyDo_ChiTietRepository;
    public CLSKetQuaXNHuyet_TuyDo_ChiTietService(ICLSKetQuaXNHuyet_TuyDo_ChiTietRepository CLSKetQuaXNHuyet_TuyDo_ChiTietRepository) : base(CLSKetQuaXNHuyet_TuyDo_ChiTietRepository)
    {
    _CLSKetQuaXNHuyet_TuyDo_ChiTietRepository = CLSKetQuaXNHuyet_TuyDo_ChiTietRepository;
    }
    }
    }

