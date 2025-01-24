import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ThuPhanUngThuocCoHai_ThuocGayNghiNgoADR } from './ThuPhanUngThuocCoHai_ThuocGayNghiNgoADR.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ThuPhanUngThuocCoHai_ThuocGayNghiNgoADRService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ThuocGayNghiNgoADR_Id', 'PhanUngThuocCoHai_Id', 'Duoc_Id', 'HamLuong', 'LieuDungMotLan', 'SoLanDung', 'DuongDung_Id', 'NgayBatDau', 'NgayKetThuc', 'HanSuDung', 'HangSanXuat_Id', 'NguoiTao_Id', 'NgayTao', 'NguoiCapNhat_Id', 'NgayCapNhat', 'LyDoDungThuoc'];

    List: ThuPhanUngThuocCoHai_ThuocGayNghiNgoADR[] | undefined;
    ListFilter: ThuPhanUngThuocCoHai_ThuocGayNghiNgoADR[] | undefined;
    FormData!: ThuPhanUngThuocCoHai_ThuocGayNghiNgoADR;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ThuPhanUngThuocCoHai_ThuocGayNghiNgoADR";
    }
}

