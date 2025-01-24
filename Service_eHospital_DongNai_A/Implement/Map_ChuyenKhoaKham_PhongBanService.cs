namespace Service_eHospital_DongNai_A.Implement
{
    public class Map_ChuyenKhoaKham_PhongBanService : BaseService<Map_ChuyenKhoaKham_PhongBan, IMap_ChuyenKhoaKham_PhongBanRepository>
    , IMap_ChuyenKhoaKham_PhongBanService
    {
    private readonly IMap_ChuyenKhoaKham_PhongBanRepository _Map_ChuyenKhoaKham_PhongBanRepository;
    public Map_ChuyenKhoaKham_PhongBanService(IMap_ChuyenKhoaKham_PhongBanRepository Map_ChuyenKhoaKham_PhongBanRepository) : base(Map_ChuyenKhoaKham_PhongBanRepository)
    {
    _Map_ChuyenKhoaKham_PhongBanRepository = Map_ChuyenKhoaKham_PhongBanRepository;
    }
    }
    }

