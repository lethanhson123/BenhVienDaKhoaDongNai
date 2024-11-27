namespace Service.Interface
{
    public interface IGoiSoChiTietPhongKhamService : IBaseService<GoiSoChiTietPhongKham>
    {
        Task<GoiSoChiTietPhongKham> GetByDanhMucPhongKhamID_NgayCapSoSoThuTuAsync(long DanhMucPhongKhamID, int NgayCapSoSoThuTu);
    }
    }

