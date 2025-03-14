import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_BenhNhan_BHYT } from './DM_BenhNhan_BHYT.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_BenhNhan_BHYTService extends BaseService {
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhNhan_BHYT_Id', 'BenhNhan_Id', 'LoaiBHYT', 'SoThe', 'NgayCap', 'NgayHieuLuc', 'NgayHetHieuLuc', 'TinhThanh_CapThe_Id', 'BenhVien_KCB_Id', 'TamNgung', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'Tren3Nam', 'Tren6Thang', 'NgayHuong5Nam'];

    DisplayColumns002: string[] = ['Save', 'STT', 'BenhNhan_BHYT_Id', 'BenhVien_KCB_Id', 'SoThe', 'NgayCap', 'NgayHieuLuc', 'NgayHetHieuLuc', 'NgayHuong5Nam', 'TamNgung', 'Tren6Thang', 'Tren3Nam', 'NgayCapNhat', 'NguoiCapNhat_Id'];
    DisplayColumns003: string[] = ['Save', 'STT', 'BenhNhan_BHYT_Id', 'BenhVien_KCB_Id', 'SoThe', 'NgayCap', 'NgayHieuLuc'];
    List: DM_BenhNhan_BHYT[] | undefined;
    ListFilter: DM_BenhNhan_BHYT[] | undefined;
    FormData!: DM_BenhNhan_BHYT;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_BenhNhan_BHYT";
    }

    GetByBenhNhan_IdAndEmptyToListAsync() {
        let url = this.APIURL + this.Controller + '/GetByBenhNhan_IdAndEmptyToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

