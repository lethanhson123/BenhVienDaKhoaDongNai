import { Base } from "./Base.model";

export class LichLamViecChiTiet extends Base{
LichLamViecChiTiet_Id?: number;
NhanVien_Id?: number;
PhongBan_Id?: number;
Ngay?: Date;
ThoiGianBatDau?: Date;
ThoiGianKetThuc?: Date;
Schedule_id?: number;
ScheduleDetail_Id?: number;
Huy?: boolean;
TamNgung?: boolean;
NguoiTao_Id?: number;
NguoiCapNhat?: number;
NgayTao?: Date;
NgayCapNhat?: Date;
NhanVienTao_id?: number;
NhanVienCapNhat_id?: number;
LyDoCapNhat?: string;
GhiChu?: string;
Schedule_Type_Id?: number;
Block?: number;
PrecentOfBlock?: number;
isHoliday?: boolean;
Holiday_Id?: number;

}


