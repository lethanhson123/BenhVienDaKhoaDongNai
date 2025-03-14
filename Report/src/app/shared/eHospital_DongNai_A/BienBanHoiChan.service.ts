import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BienBanHoiChan } from './BienBanHoiChan.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BienBanHoiChanService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BienBanHoiChan_Id', 'TiepNhan_Id', 'CLSYeuCau', 'BenhNhan_Id', 'LoaiHoiChan', 'ChanDoan', 'TomTat_TienSuBenh', 'TienCan', 'KhamLamSang', 'KPS', 'TinhTrang', 'GPB', 'HinhAnhHoc', 'TumorMarker', 'CachXuTri', 'GiaiDoan', 'ChanDoan_TuyenDuoi', 'TomTat_DienBienBenh', 'BenhSu', 'HuongXuTri', 'ChamSoc', 'KetLuan', 'NgayHoiChan', 'ThoiGianDuTinhPT', 'ThoiGianHenNhapVien', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'SoPhieuHoiChan', 'LoaiHoiChan_Id', 'BenhAn_Id', 'LuuTru_Id', 'PhongBan_Id', 'BacSi_Id', 'LyDoHoiChan_Id', 'HinhThucHoiChan_Id', 'YeuCauHoiChan', 'ThoiGianHoiChan', 'PhatDo_DieuTri_Id'];

    List: BienBanHoiChan[] | undefined;
    ListFilter: BienBanHoiChan[] | undefined;
    FormData!: BienBanHoiChan;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BienBanHoiChan";
    }
}

