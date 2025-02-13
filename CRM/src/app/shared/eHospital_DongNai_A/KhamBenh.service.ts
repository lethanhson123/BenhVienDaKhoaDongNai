import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { KhamBenh } from './KhamBenh.model';
import { BaseService } from './Base.service';

import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';

import { Sys_Users } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Users.model';
import { Sys_UsersService } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Users.service';

import { Lst_Dictionary } from 'src/app/shared/eHospital_DongNai_A_Dictionary/Lst_Dictionary.model';
import { Lst_DictionaryService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/Lst_Dictionary.service';

import { DM_BenhNhan } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_BenhNhan.model';
import { DM_BenhNhanService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_BenhNhan.service';

import { DM_DoiTuong } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_DoiTuong.model';
import { DM_DoiTuongService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_DoiTuong.service';

import { DM_ICD } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_ICD.model';
import { DM_ICDService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_ICD.service';

import { DM_PhongBan } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_PhongBan.model';
import { DM_PhongBanService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_PhongBan.service';

import { DM_DichVu } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_DichVu.model';
import { DM_DichVuService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_DichVu.service';

import { NS_NHANVIEN } from 'src/app/shared/eHospital_DongNai_A_NSTL/NS_NHANVIEN.model';
import { NS_NHANVIENService } from 'src/app/shared/eHospital_DongNai_A_NSTL/NS_NHANVIEN.service';

@Injectable({
    providedIn: 'root'
})
export class KhamBenhService extends BaseService {
    DisplayColumns001: string[] = ['Save', 'STT', 'KhamBenh_Id', 'BenhNhan_Id', 'TiepNhan_Id', 'DichVu_Id', 'PhongBan_Id', 'NgayKham', 'ThoiGianKham', 'BacSiKham_Id', 'ChanDoanKhoaKham', 'ChanDoanICD_Id', 'ChanDoanPhuICD_Id', 'HuongGiaiQuyet_Id', 'GhiChu', 'SoNgayHenTaiKham', 'NhapKhoa_Id', 'ChuyenDenBenhVien_Id', 'CheDoAnUong_Id', 'CheDoChamSoc_Id', 'KhamCapCuu', 'KhamBenhLanDau_Id', 'LyDoNhapVien_Id', 'Mach', 'HuyetApThap', 'HuyetApCao', 'NhipTho', 'NhietDo', 'ChieuCao', 'CanNang', 'TrieuChungLamSang', 'DichVu_KhamBenh_Id', 'ChanDoanSoBo', 'YeuCauChiTiet_Id', 'KhamBenh_ChuyenKhoa_Id', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'ToaThuocMuaNgoai', 'ChanDoanICD', 'GiaiDoanBenh', 'TacDungPhu', 'TuanThuCuaBN', 'HuongDieuTri_Id', 'SoNgayDieuTri', 'GhiChu2', 'SoBenhAnNgoaiTru_Id', 'DieuTriDuPhong', 'DoiTuong_Id', 'BMI', 'KhoaDuDieu', 'NguoiKhoa_Id', 'NgayKhoa', 'ThoiGianKhoa', 'ChuyenKhoa_Id', 'ThoiGianNhapVienDuKien', 'TyLeMo', 'VongBung', 'TLDG_MP', 'TLDG_MT', 'TKLT_MP', 'TKLT_MT', 'SieuHienVi', 'SoiDayMat', 'TKLT_MP_Text', 'TKLT_MT_Text', 'NhanAp_MT', 'NhanAp_MP', 'NghiOm_TuNgay', 'NghiOm_DenNgay', 'TLDG_MT_Text', 'TLDG_MP_Text', 'BenhAn_ID', 'BenhManTinh_ID'];
    DisplayColumns002: string[] = ['STT', 'KhamBenh_Id', 'TiepNhan_Id', 'BenhNhan_Id', 'DoiTuong_Id', 'PhongBan_Id', 'DichVu_Id', 'KhamCapCuu', 'ThoiGianKham', 'BacSiKham_Id', 'ChanDoanICD_Id', 'ChanDoanPhuICD_Id', 'BMI', 'NhapKhoa_Id', 'LyDoNhapVien_Id', 'ChanDoanSoBo', 'ChanDoanKhoaKham', 'GhiChu', 'SoNgayHenTaiKham', 'TrieuChungLamSang', 'Mach', 'HuyetApThap', 'HuyetApCao', 'NhipTho', 'NhietDo', 'ChieuCao', 'CanNang', 'NhanAp_MT', 'NhanAp_MP', 'NghiOm_TuNgay', 'NghiOm_DenNgay', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];
    List: KhamBenh[] | undefined;
    ListFilter: KhamBenh[] | undefined;
    FormData!: KhamBenh;
    constructor(
        public httpClient: HttpClient,

        public Sys_UsersService: Sys_UsersService,
        public Lst_DictionaryService: Lst_DictionaryService,
        public DM_BenhNhanService: DM_BenhNhanService,
        public DM_DoiTuongService: DM_DoiTuongService,
        public DM_ICDService: DM_ICDService,
        public DM_PhongBanService: DM_PhongBanService,
        public DM_DichVuService: DM_DichVuService,
        public NS_NHANVIENService: NS_NHANVIENService,
    ) {
        super(httpClient);
        this.Controller = "KhamBenh";

        this.Sys_UsersSearch();
        this.Lst_DictionarySearch();
        this.DM_DoiTuongSearch();
        this.DM_ICDSearch();
        this.DM_PhongBanSearch();
        this.DM_DichVuSearch();
        this.NS_NHANVIENSearch();
    }
    Sys_UsersSearch() {
        this.Sys_UsersService.ComponentGetAllToListAsync(this.Sys_UsersService);
    }
    Lst_DictionarySearch() {
        this.Lst_DictionaryService.BaseParameter.Dictionary_Type_Id = environment.Lst_Dictionary_TypeIDGiaiQuyetKhamBenh;
        this.Lst_DictionaryService.GetByDictionary_Type_IdToListAsync().subscribe(
            res => {
                this.Lst_DictionaryService.ListGiaiQuyetKhamBenh = (res as Lst_Dictionary[]);
            },
            err => {
            },
            () => {
            }
        );
        this.Lst_DictionaryService.BaseParameter.Dictionary_Type_Id = environment.Lst_Dictionary_TypeIDLyDoNhapVien;
        this.Lst_DictionaryService.GetByDictionary_Type_IdToListAsync().subscribe(
            res => {
                this.Lst_DictionaryService.ListLyDoNhapVien = (res as Lst_Dictionary[]);
            },
            err => {
            },
            () => {
            }
        );
    }
    DM_BenhNhanSearch() {
        this.DM_BenhNhanService.ComponentGetAllToListAsync(this.DM_BenhNhanService);
    }
    DM_DoiTuongSearch() {
        this.DM_DoiTuongService.ComponentGetAllToListAsync(this.DM_DoiTuongService);
    }
    DM_ICDSearch() {
        this.DM_ICDService.ComponentGetAllToListAsync(this.DM_ICDService);
    }
    DM_PhongBanSearch() {
        this.DM_PhongBanService.ComponentGetAllToListAsync(this.DM_PhongBanService);
    }
    DM_DichVuSearch() {
        this.DM_DichVuService.ComponentGetAllToListAsync(this.DM_DichVuService);
    }
    NS_NHANVIENSearch() {
        this.NS_NHANVIENService.ComponentGetAllToListAsync(this.NS_NHANVIENService);
    }
    RenderToListTransfer(Sort: MatSort, Paginator: MatPaginator) {

        var List = [...new Map(this.List.map(item => [item.PhongBan_Id, item])).values()];
        var ListID = List.map(function (a) { return a.PhongBan_Id; });
        this.BaseParameter.Note = environment.InitializationString;
        for (let i = 0; i < ListID.length; i++) {
            let ListSub = this.List.filter(item => item.PhongBan_Id == ListID[i]);
            if (ListSub) {
                let Model = this.DM_PhongBanService.List.filter(item => item.PhongBan_Id == ListID[i]);
                if (Model) {
                    if (Model.length) {
                        this.BaseParameter.Note = this.BaseParameter.Note + ", " + Model[0].TenPhongBan + " (" + ListSub.length + ")";
                    }
                }
            }
        }

        var ListBenhNhan = [...new Map(this.List.map(item => [item.BenhNhan_Id, item])).values()];
        var ListBenhNhanID = ListBenhNhan.map(function (a) { return a.BenhNhan_Id; });
        ListBenhNhanID = ListBenhNhanID.filter(item => item > 0);
        if (ListBenhNhanID) {
            this.IsShowLoading = true;
            this.DM_BenhNhanService.BaseParameter.ListID = ListBenhNhanID;
            this.DM_BenhNhanService.GetByListIDToListAsync().subscribe(
                res => {
                    this.DM_BenhNhanService.List = (res as DM_BenhNhan[]);

                    for (let i = 0; i < this.List.length; i++) {
                        let Sys_Users = this.Sys_UsersService.List.filter(item => item.User_Id == this.List[i].NguoiTao_Id);
                        if (Sys_Users) {
                            if (Sys_Users.length) {
                                this.List[i].NguoiTaoName = Sys_Users[0].User_Name
                            }
                        }
                        Sys_Users = this.Sys_UsersService.List.filter(item => item.User_Id == this.List[i].NguoiCapNhat_Id);
                        if (Sys_Users) {
                            if (Sys_Users.length) {
                                this.List[i].NguoiCapNhatName = Sys_Users[0].User_Name
                            }
                        }
                        let NS_NHANVIEN = this.NS_NHANVIENService.List.filter(item => item.NhanVien_Id == this.List[i].BacSiKham_Id);
                        if (NS_NHANVIEN) {
                            if (NS_NHANVIEN.length) {
                                this.List[i].BacSiKhamName = NS_NHANVIEN[0].Ho + " " + NS_NHANVIEN[0].Ten + " - " + NS_NHANVIEN[0].MaNhanVien;
                            }
                        }
                        let Lst_Dictionary = this.Lst_DictionaryService.ListGiaiQuyetKhamBenh.filter(item => item.Dictionary_Id == this.List[i].HuongGiaiQuyet_Id);
                        if (Lst_Dictionary) {
                            if (Lst_Dictionary.length) {
                                this.List[i].HuongGiaiQuyetName = Lst_Dictionary[0].Dictionary_Name;
                            }
                        }
                        Lst_Dictionary = this.Lst_DictionaryService.ListLyDoNhapVien.filter(item => item.Dictionary_Id == this.List[i].LyDoNhapVien_Id);
                        if (Lst_Dictionary) {
                            if (Lst_Dictionary.length) {
                                this.List[i].LyDoNhapVienName = Lst_Dictionary[0].Dictionary_Name;
                            }
                        }
                        let DM_BenhNhan = this.DM_BenhNhanService.List.filter(item => item.BenhNhan_Id == this.List[i].BenhNhan_Id);
                        if (DM_BenhNhan) {
                            if (DM_BenhNhan.length) {
                                this.List[i].BenhNhanName = DM_BenhNhan[0].TenBenhNhan + " - " + DM_BenhNhan[0].MaYTe;
                            }
                        }
                        let DM_DoiTuong = this.DM_DoiTuongService.List.filter(item => item.DoiTuong_Id == this.List[i].DoiTuong_Id);
                        if (DM_DoiTuong) {
                            if (DM_DoiTuong.length) {
                                this.List[i].DoiTuongName = DM_DoiTuong[0].TenDoiTuong;
                            }
                        }
                        let DM_ICD = this.DM_ICDService.List.filter(item => item.ICD_Id == this.List[i].ChanDoanICD_Id);
                        if (DM_ICD) {
                            if (DM_ICD.length) {
                                this.List[i].ChanDoanICDName = DM_ICD[0].MaICD;
                            }
                        }
                        DM_ICD = this.DM_ICDService.List.filter(item => item.ICD_Id == this.List[i].ChanDoanPhuICD_Id);
                        if (DM_ICD) {
                            if (DM_ICD.length) {
                                this.List[i].ChanDoanPhuICDName = DM_ICD[0].MaICD;
                            }
                        }
                        let DM_PhongBan = this.DM_PhongBanService.List.filter(item => item.PhongBan_Id == this.List[i].PhongBan_Id);
                        if (DM_PhongBan) {
                            if (DM_PhongBan.length) {
                                this.List[i].PhongBanName = DM_PhongBan[0].TenPhongBan;
                            }
                        }
                        DM_PhongBan = this.DM_PhongBanService.List.filter(item => item.PhongBan_Id == this.List[i].NhapKhoa_Id);
                        if (DM_PhongBan) {
                            if (DM_PhongBan.length) {
                                this.List[i].NhapKhoaName = DM_PhongBan[0].TenPhongBan;
                            }
                        }
                        let DM_DichVu = this.DM_DichVuService.List.filter(item => item.DichVu_Id == this.List[i].DichVu_Id);
                        if (DM_DichVu) {
                            if (DM_DichVu.length) {
                                this.List[i].DichVuName = DM_DichVu[0].TenDichVu;
                            }
                        }
                    }
                    this.DataSource = new MatTableDataSource(this.List);
                    this.DataSource.sort = Sort;
                    this.DataSource.paginator = Paginator;
                    this.IsShowLoading = false;
                },
                err => {
                },
                () => {
                }
            );
        }
    }
    GetByKhamBenh_IdAsync() {
        let url = this.APIURL + this.Controller + '/GetByKhamBenh_IdAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetByNgayKham_SearchStringToListAsync() {
        let url = this.APIURL + this.Controller + '/GetByNgayKham_SearchStringToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

