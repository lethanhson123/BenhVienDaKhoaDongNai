using Service.Interface;

namespace Service.Implement
{
    public class GoiSoChiTietPhongKhamService : BaseService<GoiSoChiTietPhongKham, IGoiSoChiTietPhongKhamRepository>
    , IGoiSoChiTietPhongKhamService
    {
        private readonly IGoiSoChiTietPhongKhamRepository _GoiSoChiTietPhongKhamRepository;

        private readonly IDanhMucPhongKhamRepository _DanhMucPhongKhamRepository;

        private readonly IGoiSoRepository _GoiSoRepository;

        public GoiSoChiTietPhongKhamService(IGoiSoChiTietPhongKhamRepository GoiSoChiTietPhongKhamRepository

            , IGoiSoRepository GoiSoRepository

            , IDanhMucPhongKhamRepository danhMucPhongKhamRepository

            ) : base(GoiSoChiTietPhongKhamRepository)
        {
            _GoiSoChiTietPhongKhamRepository = GoiSoChiTietPhongKhamRepository;

            _GoiSoRepository = GoiSoRepository;

            _DanhMucPhongKhamRepository = danhMucPhongKhamRepository;
        }
        public override void Initialization(GoiSoChiTietPhongKham model)
        {
            BaseInitialization(model);
            if (model.DanhMucPhongKhamID > 0)
            {
                if (string.IsNullOrEmpty(model.DanhMucPhongKhamName))
                {
                    model.DanhMucPhongKhamName = _DanhMucPhongKhamRepository.GetByID(model.DanhMucPhongKhamID.Value).Name;
                }
            }
            if (string.IsNullOrEmpty(model.NgayCapSoSoThuTuString))
            {
                if (model.NgayCapSoSoThuTu > 0)
                {
                    model.NgayCapSo = GlobalHelper.InitializationDateTime;
                    model.NgayCapSoSoThuTuString = model.NgayCapSoSoThuTu.ToString();
                    if (model.NgayCapSoSoThuTu < 10)
                    {
                        model.NgayCapSoSoThuTuString = "000" + model.NgayCapSoSoThuTuString;
                    }
                    else
                    {
                        if (model.NgayCapSoSoThuTu < 100)
                        {
                            model.NgayCapSoSoThuTuString = "00" + model.NgayCapSoSoThuTuString;
                        }
                        else
                        {
                            if (model.NgayCapSoSoThuTu < 1000)
                            {
                                model.NgayCapSoSoThuTuString = "0" + model.NgayCapSoSoThuTuString;
                            }
                        }
                    }
                }
            }
            if (string.IsNullOrEmpty(model.NgayDangKySoThuTuString))
            {
                if (model.NgayDangKySoThuTu > 0)
                {
                    model.NgayDangKy = GlobalHelper.InitializationDateTime;
                    model.NgayDangKySoThuTuString = model.NgayCapSoSoThuTu.ToString();
                    if (model.NgayDangKySoThuTu < 10)
                    {
                        model.NgayDangKySoThuTuString = "000" + model.NgayDangKySoThuTuString;
                    }
                    else
                    {
                        if (model.NgayDangKySoThuTu < 100)
                        {
                            model.NgayDangKySoThuTuString = "00" + model.NgayDangKySoThuTuString;
                        }
                        else
                        {
                            if (model.NgayDangKySoThuTu < 1000)
                            {
                                model.NgayDangKySoThuTuString = "0" + model.NgayDangKySoThuTuString;
                            }
                        }
                    }
                }
            }
        }

        public virtual async Task<GoiSoChiTietPhongKham> GetByDanhMucPhongKhamID_NgayCapSoSoThuTuAsync(long DanhMucPhongKhamID, int NgayCapSoSoThuTu)
        {
            GoiSoChiTietPhongKham result = new GoiSoChiTietPhongKham();
            try
            {
                DateTime Now = GlobalHelper.InitializationDateTime;
                result = await GetByCondition(item => item.DanhMucPhongKhamID == DanhMucPhongKhamID && item.NgayCapSoSoThuTu == NgayCapSoSoThuTu && item.NgayCapSo.Value.Year == Now.Year && item.NgayCapSo.Value.Month == Now.Month && item.NgayCapSo.Value.Day == Now.Day).FirstOrDefaultAsync();
                if (result == null)
                {
                    result = new GoiSoChiTietPhongKham();
                }
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            if (result == null)
            {
                result = new GoiSoChiTietPhongKham();
            }
            return result;
        }
    }
}

