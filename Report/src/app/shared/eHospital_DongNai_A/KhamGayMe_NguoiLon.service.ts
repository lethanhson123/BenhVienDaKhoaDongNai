import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { KhamGayMe_NguoiLon } from './KhamGayMe_NguoiLon.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class KhamGayMe_NguoiLonService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KhamGayMe_NguoiLon_Id', 'SoPhieuGayMe', 'BenhNhan_Id', 'TiepNhan_Id', 'BenhAn_Id', 'CLSYeuCau_Id', 'NgayThucHien', 'ThoiGianThuchien', 'BacSiGayMe_Id', 'ChieuCao', 'CanNang', 'ASA', 'Mallampati', 'KCCamGiap', 'HaMieng', 'TinhTrangRang', 'BuaAnCuoiTruocMo', 'ThoiGianBuaAn', 'CapCuu', 'DaDayDay', 'ChanDoan', 'HuongXuTri', 'TienSuNoiKhoa', 'TiensuNgoaikhoa', 'TienSuGayMeGayTe', 'DiUng', 'ThuocLa', 'Ruou', 'MaTuy', 'BenhLayNhiem', 'ThuocDangDieuTri', 'KhamLamSang', 'TuanHoan', 'M', 'HA', 'HoHap', 'ThanKinh', 'CotSong', 'XetNghiemBatThuong', 'YeuCauBoSung', 'DuKienThuoc_VoCam', 'DuKienGiamDauSauMo', 'YLenhTruocMo_ThuocTienGayMe', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: KhamGayMe_NguoiLon[] | undefined;
    ListFilter: KhamGayMe_NguoiLon[] | undefined;
    FormData!: KhamGayMe_NguoiLon;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "KhamGayMe_NguoiLon";
    }
}

