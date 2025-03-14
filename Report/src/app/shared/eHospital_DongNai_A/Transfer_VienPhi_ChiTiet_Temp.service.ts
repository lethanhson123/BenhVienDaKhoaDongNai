import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Transfer_VienPhi_ChiTiet_Temp } from './Transfer_VienPhi_ChiTiet_Temp.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Transfer_VienPhi_ChiTiet_TempService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'IDSession', 'BenhNhan_Id', 'NgayChungTu', 'IDRef', 'Loai_IDRef', 'LoaiNoiDung', 'NoiDung_Id', 'SoLuong', 'ThanhTien', 'MaYTe', 'TenBenhNhan', 'DiaChi'];

    List: Transfer_VienPhi_ChiTiet_Temp[] | undefined;
    ListFilter: Transfer_VienPhi_ChiTiet_Temp[] | undefined;
    FormData!: Transfer_VienPhi_ChiTiet_Temp;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Transfer_VienPhi_ChiTiet_Temp";
    }
}

