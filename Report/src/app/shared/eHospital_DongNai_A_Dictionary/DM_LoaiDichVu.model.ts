import { Base } from "./Base.model";

export class DM_LoaiDichVu extends Base{
LoaiDichVu_Id?: number;
MaLoaiDichVu?: string;
TenLoaiDichVu?: string;
TenLoaiDichVu_En?: string;
TenLoaiDichVu_Ru?: string;
TamNgung?: boolean;
TenKhongDau?: string;
NgayTao?: Date;
NguoiTao_Id?: number;
NgayCapNhat?: Date;
NguoiCapNhat_Id?: number;
SiteCode?: string;
Mapping_Public_Id?: number;

}


