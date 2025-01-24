namespace Service_eHospital_DongNai_A.Implement
{
    public class HangDoi_Details_20231109Service : BaseService<HangDoi_Details_20231109, IHangDoi_Details_20231109Repository>
    , IHangDoi_Details_20231109Service
    {
    private readonly IHangDoi_Details_20231109Repository _HangDoi_Details_20231109Repository;
    public HangDoi_Details_20231109Service(IHangDoi_Details_20231109Repository HangDoi_Details_20231109Repository) : base(HangDoi_Details_20231109Repository)
    {
    _HangDoi_Details_20231109Repository = HangDoi_Details_20231109Repository;
    }
    }
    }

