import { Base } from "./Base.model";

export class ThucHienCheckList extends Base{
ThucHienCheckList_Id?: number;
BenhNhan_Id?: number;
TiepNhan_Id?: number;
BenhAn_Id?: number;
NhanVienThucHien_Id?: number;
NgayThucHien?: Date;
NhanVienCapNhat_Id?: number;
NgayNhanVienCapNhat?: Date;
NhanVienKiemTra_Id?: number;
NgayKiemTra?: Date;
NguoiTao_Id?: number;
NgayTao?: Date;
NguoiCapNhat_Id?: number;
NgayCapNhat?: Date;
GhiChu?: string;
ThoiGianThucHien?: Date;
ThoiGianKiemTra?: Date;
NgayLuu?: Date;
ThoiGianLuu?: Date;
MauCheckList_Id?: number;

}


