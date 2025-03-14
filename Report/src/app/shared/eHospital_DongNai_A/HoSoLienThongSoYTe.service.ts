import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { HoSoLienThongSoYTe } from './HoSoLienThongSoYTe.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class HoSoLienThongSoYTeService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'GiaoDich_Id', 'MaGiaoDich', 'FileXML', 'Messenger', 'CreateDate', 'SoHoSo', 'TimTuThoiGian', 'TimDenThoiGian', 'PID', 'isNoiNgoai', 'TiepNhan_Id'];

    List: HoSoLienThongSoYTe[] | undefined;
    ListFilter: HoSoLienThongSoYTe[] | undefined;
    FormData!: HoSoLienThongSoYTe;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "HoSoLienThongSoYTe";
    }
}

