namespace Service_eHospital_DongNai_A.Implement
{
    public class zzz_NoiTru_XuatLaiXMLService : BaseService<zzz_NoiTru_XuatLaiXML, Izzz_NoiTru_XuatLaiXMLRepository>
    , Izzz_NoiTru_XuatLaiXMLService
    {
    private readonly Izzz_NoiTru_XuatLaiXMLRepository _zzz_NoiTru_XuatLaiXMLRepository;
    public zzz_NoiTru_XuatLaiXMLService(Izzz_NoiTru_XuatLaiXMLRepository zzz_NoiTru_XuatLaiXMLRepository) : base(zzz_NoiTru_XuatLaiXMLRepository)
    {
    _zzz_NoiTru_XuatLaiXMLRepository = zzz_NoiTru_XuatLaiXMLRepository;
    }
    }
    }

