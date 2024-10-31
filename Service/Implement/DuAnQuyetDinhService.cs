using Microsoft.AspNetCore.Hosting;
using Service.Interface;

namespace Service.Implement
{
    public class DuAnQuyetDinhService : BaseService<DuAnQuyetDinh, IDuAnQuyetDinhRepository>
    , IDuAnQuyetDinhService
    {
        private readonly IDuAnQuyetDinhRepository _DuAnQuyetDinhRepository;

        private readonly IToChucRepository _ToChucRepository;

        private readonly IThanhVienService _ThanhVienService;
        public DuAnQuyetDinhService(IDuAnQuyetDinhRepository DuAnQuyetDinhRepository

            , IToChucRepository ToChucRepository

            , IThanhVienService ThanhVienService

            ) : base(DuAnQuyetDinhRepository)
        {
            _DuAnQuyetDinhRepository = DuAnQuyetDinhRepository;

            _ToChucRepository = ToChucRepository;            

            _ThanhVienService = ThanhVienService;
        }

        public override void Initialization(DuAnQuyetDinh model)
        {
            BaseInitialization(model);
            
            if (model.NgayKy == null)
            {
                model.NgayKy = GlobalHelper.InitializationDateTime;
            }           

            if (model.BenDauTuID > 0)
            {
                ToChuc ToChuc = _ToChucRepository.GetByID(model.BenDauTuID.Value);
                model.BenDauTuName = ToChuc.Name;
                model.BenDauTuMaSoThue = ToChuc.MaSoThue;
                model.BenDauTuDienThoai = ToChuc.DienThoai;
                model.BenDauTuDiaChi = ToChuc.DiaChi;
                model.BenDauTuEmail = ToChuc.Email;
            }
            else
            {
                if (!string.IsNullOrEmpty(model.BenDauTuName))
                {
                    ToChuc ToChuc = _ToChucRepository.GetByName(model.BenDauTuName);
                    if (ToChuc == null)
                    {
                        ToChuc = new ToChuc();
                        ToChuc.Name = model.BenDauTuName;
                        _ToChucRepository.Add(ToChuc);
                    }
                    model.BenDauTuID = ToChuc.ID;
                }
            }            

            if (model.NguoiDauTuID > 0)
            {
                ThanhVien ThanhVien = _ThanhVienService.GetByID(model.NguoiDauTuID.Value);
                model.NguoiDauTuName = ThanhVien.Name;
                model.NguoiDauTuChucDanh = ThanhVien.DanhMucChucDanhName;
            }
            else
            {
                if (!string.IsNullOrEmpty(model.NguoiDauTuName))
                {
                    ThanhVien ThanhVien = _ThanhVienService.GetByName(model.NguoiDauTuName);
                    if (ThanhVien == null)
                    {
                        ThanhVien = new ThanhVien();
                        ThanhVien.Name = model.NguoiDauTuName;
                        ThanhVien.DanhMucChucDanhName = model.NguoiDauTuChucDanh;
                        _ThanhVienService.Save(ThanhVien);
                    }
                    model.NguoiDauTuID = ThanhVien.ID;
                }
            }           
        }
    }
}

