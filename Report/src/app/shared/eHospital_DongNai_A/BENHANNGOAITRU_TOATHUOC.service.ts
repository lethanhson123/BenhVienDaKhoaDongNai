import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BENHANNGOAITRU_TOATHUOC } from './BENHANNGOAITRU_TOATHUOC.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BENHANNGOAITRU_TOATHUOCService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'TOATHUOC_ID', 'SOTHUTUTOA', 'KHAMBENH_ID', 'DUOC_ID', 'SOLUONG', 'SONGAY', 'SOLANTRENNGAY', 'SOLUONGTRENLAN', 'SOLUONG_BUOISANG', 'SOLUONG_BUOITRUA', 'SOLUONG_BUOICHIEU', 'SOLUONG_BUOITOI', 'DUONGDUNG_ID', 'DONGIADOANHTHU', 'DONGIAHOTRO', 'DONGIAHOTROCHITRA', 'DONGIATHANHTOAN', 'TIENTE_ID', 'TYGIA', 'HUYTOATHUOC', 'GHICHU', 'TRANGTHAI', 'NGAYTAO', 'NGUOITAO_ID', 'NGAYCAPNHAT', 'NGUOICAPNHAT_ID', 'IDX', 'LOAIGIA_ID', 'NGUONHANG_ID', 'GIATRIMIENGIAM', 'GIATRITHATTHU', 'GIATRITHANHTOAN', 'GIATRIDATHANHTOAN', 'DATHANHTOAN_MOTPHAN', 'DATHANHTOAN_HOANTAT', 'PHATSINHHOADON', 'MIENPHI', 'TINHTIEN', 'ATTRIBUTE_1', 'ATTRIBUTE_2', 'ATTRIBUTE_3', 'ATTRIBUTE_4', 'ATTRIBUTE_5', 'ATTRIBUTE_6', 'DonGiaChenhLech', 'DonGiaHoTroChenhLech', 'GiaTriDaThanhToan_ChenhLech', 'GiaTriDaThanhToan_HoTroChenhLech', 'BangGia_Id', 'TyLeVAT', 'GiaTriVAT', 'NguonDuoc_Id', 'PhieuLinh_Id', 'ChungTu_Id', 'SoTienThucTe', 'NguonLayThuoc', 'MuaNgoai', 'PhatThuocTaiQuay', 'KhoPhat_Id'];

    List: BENHANNGOAITRU_TOATHUOC[] | undefined;
    ListFilter: BENHANNGOAITRU_TOATHUOC[] | undefined;
    FormData!: BENHANNGOAITRU_TOATHUOC;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BENHANNGOAITRU_TOATHUOC";
    }
}

