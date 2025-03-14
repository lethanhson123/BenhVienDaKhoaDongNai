import { Base } from "./Base.model";

export class Duoc_DonDatHangChiTiet extends Base{
DonDatHangChiTiet_Id?: number;
DonDatHang_Id?: number;
Duoc_Id?: number;
SoVisa?: string;
DonViTinh_Id?: number;
SoLuongYeuCau?: string;
SoLuongThucTe?: string;
SoLuongDaXuat?: string;
TienTe_Id?: string;
TyGia?: string;
DonGiaMua?: string;
DonGiaBan?: string;
DonGiaVon?: string;
DonGiaThanhToan?: string;
SoQuyen?: string;
SoHoaDonVAT?: string;
TyLeVAT?: string;
GiaTriVAT?: string;
MienPhi?: boolean;
LyDoMienPhi_Id?: number;
SoChungTuKeToan?: string;
SoChungTuTienMat?: string;
TrangThai?: string;
DaPhatSinhPhieuXuat?: boolean;
DaPhatSinhPhieuHoanTra?: boolean;
NgayTao?: Date;
NguoiTao_Id?: number;
NgayCapNhat?: Date;
NguoiCapNhat_Id?: number;

}


