import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_BangGia_CPH } from './DM_BangGia_CPH.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_BangGia_CPHService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BangGia_CPH_Id', 'LoaiBangGia', 'LoaiGia_Id', 'TienTe_Id', 'NgayBanHanh', 'NgayHieuLuc', 'NgayHetHieuLuc', 'TrangThai', 'TamNgung', 'NguoiTao_Id', 'NgayTao', 'NguoiCapNhat_Id', 'NgayCapNhat'];

    List: DM_BangGia_CPH[] | undefined;
    ListFilter: DM_BangGia_CPH[] | undefined;
    FormData!: DM_BangGia_CPH;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_BangGia_CPH";
    }
    GetByBangGia_CPH_IdAsync() {
        let url = this.APIURL + this.Controller + '/GetByBangGia_CPH_IdAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

