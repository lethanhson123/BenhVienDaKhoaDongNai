import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { His_XepLich } from './His_XepLich.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class His_XepLichService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Schedule_His_Id', 'Schedule_Id', 'NhanVien_Id', 'StartDay', 'EndDay', 'Schedule_Type', 'Repeat', 'Resource_Id', 'Type_Id', 'Department_Id', 'NguoiTao_Id', 'NgayTao', 'NguoiCapNhat_Id', 'NgayCapNhat', 'StartOfWeek', 'LyDoDoi'];

    List: His_XepLich[] | undefined;
    ListFilter: His_XepLich[] | undefined;
    FormData!: His_XepLich;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "His_XepLich";
    }
}

