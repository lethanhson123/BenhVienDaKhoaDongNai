import { Base } from "./Base.model";

export class DM_BenhNhan_Notes extends Base{
BenhNhan_Notes_Id?: number;
TiepNhan_Id?: number;
BenhNhan_Id?: number;
TieuDe?: string;
NoiDung?: string;
NgayBatDau?: Date;
NgayKetThuc?: Date;
Status_Id?: number;
Reminder?: boolean;
Reminder_Position?: string;
NguoiLap_Id?: number;
NguoiTao_Id?: number;
NgayTao?: Date;
NguoiCapNhat_Id?: number;
NgayCapNhat?: Date;

}


