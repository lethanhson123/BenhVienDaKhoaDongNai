namespace Service_eHospital_DongNai_A.Implement
{
    public class zzz_NgoaiTru_XuatLaiXMLService : BaseService<zzz_NgoaiTru_XuatLaiXML, Izzz_NgoaiTru_XuatLaiXMLRepository>
    , Izzz_NgoaiTru_XuatLaiXMLService
    {
    private readonly Izzz_NgoaiTru_XuatLaiXMLRepository _zzz_NgoaiTru_XuatLaiXMLRepository;
    public zzz_NgoaiTru_XuatLaiXMLService(Izzz_NgoaiTru_XuatLaiXMLRepository zzz_NgoaiTru_XuatLaiXMLRepository) : base(zzz_NgoaiTru_XuatLaiXMLRepository)
    {
    _zzz_NgoaiTru_XuatLaiXMLRepository = zzz_NgoaiTru_XuatLaiXMLRepository;
    }
    }
    }

