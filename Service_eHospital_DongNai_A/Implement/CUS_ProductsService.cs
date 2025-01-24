namespace Service_eHospital_DongNai_A.Implement
{
    public class CUS_ProductsService : BaseService<CUS_Products, ICUS_ProductsRepository>
    , ICUS_ProductsService
    {
    private readonly ICUS_ProductsRepository _CUS_ProductsRepository;
    public CUS_ProductsService(ICUS_ProductsRepository CUS_ProductsRepository) : base(CUS_ProductsRepository)
    {
    _CUS_ProductsRepository = CUS_ProductsRepository;
    }
    }
    }

