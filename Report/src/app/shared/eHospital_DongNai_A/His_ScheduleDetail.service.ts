import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { His_ScheduleDetail } from './His_ScheduleDetail.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class His_ScheduleDetailService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ScheduleDetail_His_Id', 'Schedule_His_Id', 'ScheduleDetail_Id', 'Schedule_Id', 'Schedule_Value', 'StartTime', 'EndTime', 'BreakStart', 'BreakEnd', 'TotalHours', 'CPI', 'Constant', 'NguoiTao_Id', 'NgayTao', 'NguoiCapNhat_Id', 'NgayCapNhat', 'Idx', 'NumOfGroup', 'Department_Id', 'Block', 'PercentOfBlock', 'LyDoDoi', 'Schedule_Type_Id'];

    List: His_ScheduleDetail[] | undefined;
    ListFilter: His_ScheduleDetail[] | undefined;
    FormData!: His_ScheduleDetail;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "His_ScheduleDetail";
    }
}

