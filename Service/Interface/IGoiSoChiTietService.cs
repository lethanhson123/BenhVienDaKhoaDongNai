namespace Service.Interface
{
    public interface IGoiSoChiTietService : IBaseService<GoiSoChiTiet>
    {
        Task<GoiSoChiTiet> GetByDanhMucDichVuID_NgayCapSoSoThuTuAsync(long DanhMucDichVuID, int NgayCapSoSoThuTu);
    }
}

