import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { EMR } from './EMR.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class EMRService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'BENHAN_ID', 'LOAIBENHAN_ID', 'SOBENHAN', 'MAYTE', 'TENBENHNHAN', 'NAMSINH', 'GIOITINH', 'FILENAME', 'NGAYTAO', 'NGUOICHUYEN', 'NGAYRAVIEN'];

    List: EMR[] | undefined;
    ListFilter: EMR[] | undefined;
    FormData!: EMR;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "EMR";
    }
}

