import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ScheduleDetail } from './ScheduleDetail.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ScheduleDetailService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ScheduleDetail_Id', 'Schedule_Id', 'Schedule_Value', 'StartTime', 'EndTime', 'BreakStart', 'BreakEnd', 'TotalHours', 'CPI', 'Constant', 'NguoiTao_Id', 'NgayTao', 'NguoiCapNhat_Id', 'NgayCapNhat', 'Idx', 'NumOfGroup', 'Department_Id', 'Block', 'PercentOfBlock', 'Schedule_Type_Id', 'QuaNgay'];

    List: ScheduleDetail[] | undefined;
    ListFilter: ScheduleDetail[] | undefined;
    FormData!: ScheduleDetail;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ScheduleDetail";
    }
}

