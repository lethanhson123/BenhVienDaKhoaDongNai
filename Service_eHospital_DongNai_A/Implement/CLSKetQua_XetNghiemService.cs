namespace Service_eHospital_DongNai_A.Implement
{
    public class CLSKetQua_XetNghiemService : BaseService<CLSKetQua_XetNghiem, ICLSKetQua_XetNghiemRepository>
    , ICLSKetQua_XetNghiemService
    {
    private readonly ICLSKetQua_XetNghiemRepository _CLSKetQua_XetNghiemRepository;
    public CLSKetQua_XetNghiemService(ICLSKetQua_XetNghiemRepository CLSKetQua_XetNghiemRepository) : base(CLSKetQua_XetNghiemRepository)
    {
    _CLSKetQua_XetNghiemRepository = CLSKetQua_XetNghiemRepository;
    }
    }
    }

