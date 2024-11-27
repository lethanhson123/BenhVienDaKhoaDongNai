
namespace Service.Implement
{
    public class GoiSoChiTietPhongKhamService : BaseService<GoiSoChiTietPhongKham, IGoiSoChiTietPhongKhamRepository>
    , IGoiSoChiTietPhongKhamService
    {
        private readonly IGoiSoChiTietPhongKhamRepository _GoiSoChiTietPhongKhamRepository;

        private readonly IDanhMucPhongKhamRepository _DanhMucPhongKhamRepository;

        private readonly IGoiSoRepository _GoiSoRepository;

        private readonly IWebHostEnvironment _WebHostEnvironment;

        public GoiSoChiTietPhongKhamService(IGoiSoChiTietPhongKhamRepository GoiSoChiTietPhongKhamRepository

            , IGoiSoRepository GoiSoRepository

            , IDanhMucPhongKhamRepository danhMucPhongKhamRepository

            , IWebHostEnvironment WebHostEnvironment

            ) : base(GoiSoChiTietPhongKhamRepository)
        {
            _GoiSoChiTietPhongKhamRepository = GoiSoChiTietPhongKhamRepository;

            _GoiSoRepository = GoiSoRepository;

            _DanhMucPhongKhamRepository = danhMucPhongKhamRepository;

            _WebHostEnvironment = WebHostEnvironment;
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
            if (string.IsNullOrEmpty(model.Barcode))
            {
                string folderPath = Path.Combine(_WebHostEnvironment.WebRootPath, model.GetType().Name);
                bool isFolderExists = System.IO.Directory.Exists(folderPath);
                if (!isFolderExists)
                {
                    System.IO.Directory.CreateDirectory(folderPath);
                }
                Barcode Barcode = new Barcode();
                Barcode = Ean13.CreateEAN13(folderPath);
                model.Barcode = Barcode.Code;
                model.BarcodeFileName = GlobalHelper.APISite + "/" + model.GetType().Name + "/" + Barcode.FileName;
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

