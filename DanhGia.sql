CREATE TABLE [dbo].DanhGia (
    [IDNguoiThue] NVARCHAR (50) NOT NULL,
    [TenNguoiThue] NVARCHAR (MAX) NULL,
    IDNguoiDuocThue NVARCHAR (MAX) NULL,
    TenNguoiDuocThue NVARCHAR (MAX) NULL,
    DanhGiaNguoiLam NVARCHAR (MAX) NULL,
    BinhLuan NVARCHAR (MAX) NULL,
	NgayDanhGia NVARCHAR (MAX) NULL,
	HinhAnh varbinary(MAX) NULL,
);
ALTER TABLE DanhGia
ADD HinhAnh2 varbinary(MAX) NULL,
    HinhAnh3 varbinary(MAX) NULL;
