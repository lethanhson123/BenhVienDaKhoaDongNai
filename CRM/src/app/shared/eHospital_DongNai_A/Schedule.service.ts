import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Schedule } from './Schedule.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ScheduleService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Schedule_Id', 'NhanVien_Id', 'StartDay', 'EndDay', 'Schedule_Type', 'Repeat', 'Resource_Id', 'Type_Id', 'Department_Id', 'NguoiTao_Id', 'NgayTao', 'NguoiCapNhat_Id', 'NgayCapNhat', 'StartOfWeek'];

    List: Schedule[] | undefined;
    ListFilter: Schedule[] | undefined;
    FormData!: Schedule;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Schedule";
    }
}

