import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_ThiDua } from './NS_ThiDua.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_ThiDuaService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'MaNhanVien', 'Nam', 'TongDiem', 'KhongDat', 'KhongXet', 'MucI', 'MucII', 'MucIII', 'MucIV', 'MucV', 'MucVI', 'MucVII', 'MucVIII', 'MucIX', 'MucX', 'MucXI', 'MucXII', 'MucXIII', 'MucXIV', 'MucXV', 'MucXVI', 'GhiChu', 'ThiDuaDangKyDauNam', 'KhoaPhongBau', 'HDThiDuaXetDuyet'];

    List: NS_ThiDua[] | undefined;
    ListFilter: NS_ThiDua[] | undefined;
    FormData!: NS_ThiDua;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_ThiDua";
    }
}

