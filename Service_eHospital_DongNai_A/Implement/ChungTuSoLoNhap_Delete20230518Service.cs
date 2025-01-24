namespace Service_eHospital_DongNai_A.Implement
{
    public class ChungTuSoLoNhap_Delete20230518Service : BaseService<ChungTuSoLoNhap_Delete20230518, IChungTuSoLoNhap_Delete20230518Repository>
    , IChungTuSoLoNhap_Delete20230518Service
    {
    private readonly IChungTuSoLoNhap_Delete20230518Repository _ChungTuSoLoNhap_Delete20230518Repository;
    public ChungTuSoLoNhap_Delete20230518Service(IChungTuSoLoNhap_Delete20230518Repository ChungTuSoLoNhap_Delete20230518Repository) : base(ChungTuSoLoNhap_Delete20230518Repository)
    {
    _ChungTuSoLoNhap_Delete20230518Repository = ChungTuSoLoNhap_Delete20230518Repository;
    }
    }
    }

