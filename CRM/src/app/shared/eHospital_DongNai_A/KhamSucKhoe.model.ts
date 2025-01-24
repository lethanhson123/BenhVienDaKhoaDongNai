import { Base } from "./Base.model";

export class KhamSucKhoe extends Base{
KhamSucKhoe_ID?: number;
TiepNhan_Id?: number;
BenhNhan_ID?: number;
CongTy?: string;
KetLuan?: string;
XepLoai_ID?: number;
DuSucKhoeLamViec?: boolean;
DuSucKhoeLamViecCTBien?: boolean;
DuSucKhoeLamViecGioiHan?: boolean;
BacSi_ID?: number;
NgayKham?: Date;
NgayTao?: Date;
NgayCapNhat?: Date;
NguoiTao_Id?: number;
NguoiCapNhat_Id?: number;
Loai?: string;

}


