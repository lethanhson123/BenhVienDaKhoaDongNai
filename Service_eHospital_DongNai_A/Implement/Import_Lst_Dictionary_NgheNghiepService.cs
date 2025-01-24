namespace Service_eHospital_DongNai_A.Implement
{
    public class Import_Lst_Dictionary_NgheNghiepService : BaseService<Import_Lst_Dictionary_NgheNghiep, IImport_Lst_Dictionary_NgheNghiepRepository>
    , IImport_Lst_Dictionary_NgheNghiepService
    {
    private readonly IImport_Lst_Dictionary_NgheNghiepRepository _Import_Lst_Dictionary_NgheNghiepRepository;
    public Import_Lst_Dictionary_NgheNghiepService(IImport_Lst_Dictionary_NgheNghiepRepository Import_Lst_Dictionary_NgheNghiepRepository) : base(Import_Lst_Dictionary_NgheNghiepRepository)
    {
    _Import_Lst_Dictionary_NgheNghiepRepository = Import_Lst_Dictionary_NgheNghiepRepository;
    }
    }
    }

