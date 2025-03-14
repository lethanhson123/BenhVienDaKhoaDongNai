import { Base } from "./Base.model";

export class DM_KhoDuoc extends Base{
KhoDuoc_Id?: number;
MaKho?: string;
TenKho?: string;
PhongBan_Id?: number;
LoaiKho_Id?: number;
TamNgung?: boolean;
TenKhongDau?: string;
NgayTao?: Date;
NguoiTao_Id?: number;
NgayCapNhat?: Date;
NguoiCapNhat_Id?: number;
QLNguon?: boolean;
KhoDuoc?: boolean;
KhoTaiSan?: boolean;
KhoNHM?: boolean;
KhoVPP?: boolean;
KhoTTB?: boolean;
ChuyenKhoa_Id?: number;
CostCenter_Id?: number;
SiteCode?: string;
Mapping_Public_Id?: number;

}


