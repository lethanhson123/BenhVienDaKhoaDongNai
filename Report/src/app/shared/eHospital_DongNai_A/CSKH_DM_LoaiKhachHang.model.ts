import { Base } from "./Base.model";

export class CSKH_DM_LoaiKhachHang extends Base{
LoaiKhachHang_Id?: number;
MaLoaiKhachHang?: string;
TenLoaiKhachHang?: string;
GhiChu?: string;
TuoiMin?: number;
TuoiMax?: number;
SoTien?: number;
TienTe_Id?: string;
IsThanhVien?: boolean;
AppNam?: boolean;
AppNguoi?: boolean;
TamNgung?: boolean;
NgayTao?: Date;
NguoiTao_Id?: number;
NgayCapNhat?: Date;
NguoiCapNhat_Id?: number;
IsTheVinMec?: boolean;
CoThuTien?: boolean;
DonViPhatHanh_Id?: number;
NhomLoaiHoiVien_Id?: number;
Prefixcode?: string;

}


