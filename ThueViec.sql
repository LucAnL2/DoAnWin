CREATE TABLE [dbo].[ThueViec] (
    [IDNguoiThue] NVARCHAR (50) NOT NULL,
    [TenNguoiThue] NVARCHAR (MAX) NULL,
    [IDNguoiDuocThue] NVARCHAR (MAX) NULL,
    [TenNguoiDuocThue] NVARCHAR (MAX) NULL,
    [NgayThue] NVARCHAR (MAX) NULL,
    [ThangThue] NVARCHAR (MAX) NULL,
    [NamThue] NVARCHAR (MAX) NULL,
    [TrangThaiThue] NVARCHAR (MAX) NULL,
    [DiaChi] NVARCHAR (MAX) NULL,
    [SDT] NVARCHAR (MAX) NULL,
    [CongViecMuonThue] NVARCHAR (MAX) NULL
);
select * from ThueViec where IDNguoiDuocThue = N'200001'