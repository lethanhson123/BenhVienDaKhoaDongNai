import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_TUYENDUNG } from './NS_TUYENDUNG.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_TUYENDUNGService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'id', 'MaUngVien', 'NoidungthiPV', 'Vongthi', 'MaNhanVien', 'Ngaythi', 'Nhanxet', 'Ketqua'];

    List: NS_TUYENDUNG[] | undefined;
    ListFilter: NS_TUYENDUNG[] | undefined;
    FormData!: NS_TUYENDUNG;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_TUYENDUNG";
    }
}

