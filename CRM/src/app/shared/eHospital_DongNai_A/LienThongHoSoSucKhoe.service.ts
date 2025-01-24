import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { LienThongHoSoSucKhoe } from './LienThongHoSoSucKhoe.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class LienThongHoSoSucKhoeService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'LienThongHoSoSucKhoe_Id', 'KhamBenh_Id', 'KhamSucKhoe_Id', 'HoSo_Id', 'SoHoSo', 'LoaiHoSo', 'UUID', 'HoSoContent', 'HoSoContentXML', 'KetQuaContent', 'DaGui', 'NguoiGui_Id', 'NgayGui', 'ThoiGianGui', 'ThuHoi', 'NguoiThuHoi_Id', 'NgayThuHoi', 'ThoiGianThuHoi', 'NguoiCapNhat_ID', 'NgayCapNhat', 'ThoiGianCapNhat'];

    List: LienThongHoSoSucKhoe[] | undefined;
    ListFilter: LienThongHoSoSucKhoe[] | undefined;
    FormData!: LienThongHoSoSucKhoe;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "LienThongHoSoSucKhoe";
    }
}

