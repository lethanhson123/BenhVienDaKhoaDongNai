import { Base } from "./Base.model";

export class LienThongHoSoSucKhoe extends Base{
LienThongHoSoSucKhoe_Id?: number;
KhamBenh_Id?: number;
KhamSucKhoe_Id?: number;
HoSo_Id?: number;
SoHoSo?: string;
LoaiHoSo?: string;
UUID?: string;
HoSoContent?: string;
HoSoContentXML?: string;
KetQuaContent?: string;
DaGui?: boolean;
NguoiGui_Id?: number;
NgayGui?: Date;
ThoiGianGui?: Date;
ThuHoi?: boolean;
NguoiThuHoi_Id?: number;
NgayThuHoi?: Date;
ThoiGianThuHoi?: Date;
NguoiCapNhat_ID?: number;
NgayCapNhat?: Date;
ThoiGianCapNhat?: Date;

}


