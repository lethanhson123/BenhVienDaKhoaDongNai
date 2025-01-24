namespace Service_eHospital_DongNai_A.Implement
{
    public class CLSKetQuaMau_ChiTietService : BaseService<CLSKetQuaMau_ChiTiet, ICLSKetQuaMau_ChiTietRepository>
    , ICLSKetQuaMau_ChiTietService
    {
    private readonly ICLSKetQuaMau_ChiTietRepository _CLSKetQuaMau_ChiTietRepository;
    public CLSKetQuaMau_ChiTietService(ICLSKetQuaMau_ChiTietRepository CLSKetQuaMau_ChiTietRepository) : base(CLSKetQuaMau_ChiTietRepository)
    {
    _CLSKetQuaMau_ChiTietRepository = CLSKetQuaMau_ChiTietRepository;
    }
    }
    }

