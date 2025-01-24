namespace Service_eHospital_DongNai_A.Implement
{
    public class cus_HDDT_ChiTietService : BaseService<cus_HDDT_ChiTiet, Icus_HDDT_ChiTietRepository>
    , Icus_HDDT_ChiTietService
    {
    private readonly Icus_HDDT_ChiTietRepository _cus_HDDT_ChiTietRepository;
    public cus_HDDT_ChiTietService(Icus_HDDT_ChiTietRepository cus_HDDT_ChiTietRepository) : base(cus_HDDT_ChiTietRepository)
    {
    _cus_HDDT_ChiTietRepository = cus_HDDT_ChiTietRepository;
    }
    }
    }

