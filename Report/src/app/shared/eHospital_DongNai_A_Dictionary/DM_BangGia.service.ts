import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_BangGia } from './DM_BangGia.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_BangGiaService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BangGia_Id', 'LoaiBangGia', 'LoaiGia_Id', 'TienTe_Id', 'NgayBanHanh', 'NgayHieuLuc', 'NgayHetHieuLuc', 'TrangThai', 'TamNgung', 'NguoiTao_Id', 'NgayTao', 'NguoiCapNhat_Id', 'NgayCapNhat'];

    List: DM_BangGia[] | undefined;
    ListFilter: DM_BangGia[] | undefined;
    FormData!: DM_BangGia;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_BangGia";
    }
    GetByBangGia_IdAsync() {
        let url = this.APIURL + this.Controller + '/GetByBangGia_IdAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

