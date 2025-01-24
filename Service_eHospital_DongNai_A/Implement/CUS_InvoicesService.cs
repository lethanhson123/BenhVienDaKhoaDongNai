namespace Service_eHospital_DongNai_A.Implement
{
    public class CUS_InvoicesService : BaseService<CUS_Invoices, ICUS_InvoicesRepository>
    , ICUS_InvoicesService
    {
    private readonly ICUS_InvoicesRepository _CUS_InvoicesRepository;
    public CUS_InvoicesService(ICUS_InvoicesRepository CUS_InvoicesRepository) : base(CUS_InvoicesRepository)
    {
    _CUS_InvoicesRepository = CUS_InvoicesRepository;
    }
    }
    }

