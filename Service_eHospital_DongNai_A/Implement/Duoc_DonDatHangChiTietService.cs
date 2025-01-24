namespace Service_eHospital_DongNai_A.Implement
{
    public class Duoc_DonDatHangChiTietService : BaseService<Duoc_DonDatHangChiTiet, IDuoc_DonDatHangChiTietRepository>
    , IDuoc_DonDatHangChiTietService
    {
    private readonly IDuoc_DonDatHangChiTietRepository _Duoc_DonDatHangChiTietRepository;
    public Duoc_DonDatHangChiTietService(IDuoc_DonDatHangChiTietRepository Duoc_DonDatHangChiTietRepository) : base(Duoc_DonDatHangChiTietRepository)
    {
    _Duoc_DonDatHangChiTietRepository = Duoc_DonDatHangChiTietRepository;
    }
    }
    }

