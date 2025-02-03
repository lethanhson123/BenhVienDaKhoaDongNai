import { Base } from "./Base.model";

export class DM_BangGia extends Base{
BangGia_Id?: number;
LoaiBangGia?: string;
LoaiGia_Id?: number;
TienTe_Id?: string;
NgayBanHanh?: Date;
NgayHieuLuc?: Date;
NgayHetHieuLuc?: Date;
TrangThai?: string;
TamNgung?: boolean;
NguoiTao_Id?: number;
NgayTao?: Date;
NguoiCapNhat_Id?: number;
NgayCapNhat?: Date;

}


