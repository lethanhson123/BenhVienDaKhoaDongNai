import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ChamCong } from './ChamCong.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ChamCongService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'MaTheChamCong', 'NgayGioVao', 'NgayGioRa', 'SoGioLam', 'MayQuetThe', 'GhiChu', 'SoGioLamThem', 'NgayChamCong', 'Truc', 'GioVaoChuan', 'GioRaChuan'];

    List: ChamCong[] | undefined;
    ListFilter: ChamCong[] | undefined;
    FormData!: ChamCong;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ChamCong";
    }
}

