import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ThongTinChamCong } from './ThongTinChamCong.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ThongTinChamCongService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Id', 'username', 'starttime', 'endtime', 'deptid', 'inscopetim', 'attdate'];

    List: ThongTinChamCong[] | undefined;
    ListFilter: ThongTinChamCong[] | undefined;
    FormData!: ThongTinChamCong;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ThongTinChamCong";
    }
}

