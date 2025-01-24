import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { LichHen_His } from './LichHen_His.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class LichHen_HisService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'LichHen_His_Id', 'LichHen_Id', 'MaLichHen', 'KhamBenh_Id', 'BenhAn_Id', 'BenhNhan_Id', 'NgayHen_BatDau', 'ThoiGianHen_BatDau', 'NgayHen_KetThuc', 'ThoiGianHen_KetThuc', 'PhongBan_Id', 'BacSi_Id', 'DichVu_Id', 'TrangThai_Id', 'LoaiCuocHen_Id', 'NguonHen_Id', 'ThucHien_id', 'NhanVienHen_Id', 'NhanVienThayDoi_Id', 'NgayThayDoi', 'GhiChu', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'TiepNhan_Id', 'LichHen_Old', 'LichHen_Prev', 'NgayTaoCuocHen', 'LyDoDoi', 'TiepNhanThucHien_Id', 'GuiSMS', 'SoNgayGuiTruoc', 'LichMo_id', 'xeplichmo_ekipmo_id', 'KhuHen_Id', 'GoiDichVu_id', 'HopDong_Id', 'CongTy_id', 'NhanVienThucHien_Id', 'ThoiGianThucHien', 'LichHenDichDanhBacSi', 'TGnhapvien', 'NoiNhapVien', 'ChanDoan', 'MucDichHen', 'LyDoThayDoi', 'GhiChuThayDoi'];

    List: LichHen_His[] | undefined;
    ListFilter: LichHen_His[] | undefined;
    FormData!: LichHen_His;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "LichHen_His";
    }
}

