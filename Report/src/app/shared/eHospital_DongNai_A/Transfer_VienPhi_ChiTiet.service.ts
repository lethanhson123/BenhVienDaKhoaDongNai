import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Transfer_VienPhi_ChiTiet } from './Transfer_VienPhi_ChiTiet.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Transfer_VienPhi_ChiTietService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Transfer_VienPhi_Id', 'BenhNhan_Id', 'NgayChungTu', 'IDRef', 'Loai_IDRef', 'LoaiNoiDung', 'NoiDung_Id', 'SoLuong', 'ThanhTien', 'MaDoiTuong', 'VAT'];

    List: Transfer_VienPhi_ChiTiet[] | undefined;
    ListFilter: Transfer_VienPhi_ChiTiet[] | undefined;
    FormData!: Transfer_VienPhi_ChiTiet;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Transfer_VienPhi_ChiTiet";
    }
}

