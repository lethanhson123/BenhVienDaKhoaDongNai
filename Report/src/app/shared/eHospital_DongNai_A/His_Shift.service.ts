import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { His_Shift } from './His_Shift.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class His_ShiftService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Shift_His_Id', 'Shift_Id', 'Shift_Name', 'Shift_Code', 'Schedule_Type', 'StartDay', 'EndDay', 'Resource_Id', 'Type_Id', 'Department_Id', 'NguoiTao_Id', 'NgayTao', 'NguoiCapNhat_Id', 'NgayCapNhat', 'Repeat', 'StartOfWeek', 'LyDoDoi'];

    List: His_Shift[] | undefined;
    ListFilter: His_Shift[] | undefined;
    FormData!: His_Shift;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "His_Shift";
    }
}

