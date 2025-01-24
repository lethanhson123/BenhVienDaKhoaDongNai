import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { TiepNhan_DoiTuongThayDoi } from './TiepNhan_DoiTuongThayDoi.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class TiepNhan_DoiTuongThayDoiService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'TiepNhan_DoiTuongThayDoi_Id', 'BenhNhan_Id', 'TiepNhan_Id', 'BenhAn_Id', 'DoiTuong_Id', 'DoiTuong_ChiTiet_Id', 'SoBHYT', 'BHYTTuNgay', 'BHYTDenNgay', 'BenhVien_KCB_Id', 'TuyenKhamBenh_Id', 'NgayThayDoi', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'Attribute1', 'Attribute2', 'Attribute3', 'Attribute4', 'H_KhongCungChiTra', 'IsSuDung', 'HieuLucTuNgay', 'HieuLucDenNgay', 'NgayHuong5Nam'];

    List: TiepNhan_DoiTuongThayDoi[] | undefined;
    ListFilter: TiepNhan_DoiTuongThayDoi[] | undefined;
    FormData!: TiepNhan_DoiTuongThayDoi;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "TiepNhan_DoiTuongThayDoi";
    }
}

