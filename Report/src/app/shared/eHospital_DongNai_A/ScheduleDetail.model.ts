import { Base } from "./Base.model";

export class ScheduleDetail extends Base{
ScheduleDetail_Id?: number;
Schedule_Id?: number;
Schedule_Value?: number;
StartTime?: Date;
EndTime?: Date;
BreakStart?: Date;
BreakEnd?: Date;
TotalHours?: number;
CPI?: number;
Constant?: number;
NguoiTao_Id?: number;
NgayTao?: Date;
NguoiCapNhat_Id?: number;
NgayCapNhat?: Date;
Idx?: number;
NumOfGroup?: number;
Department_Id?: number;
Block?: number;
PercentOfBlock?: number;
Schedule_Type_Id?: number;
QuaNgay?: boolean;

}


