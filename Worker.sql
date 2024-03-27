CREATE TABLE [dbo].[Worker] (
    [ID] NVARCHAR (50) NOT NULL,
    [Ten] NVARCHAR (MAX) NULL,
    [GioiTinh] NVARCHAR (MAX) NULL,
    [SDT] NVARCHAR (MAX) NULL,
    [DiaChi] NVARCHAR (MAX) NULL,
    [CCCD] NVARCHAR (MAX) NULL,
    [NgaySinh] NVARCHAR (MAX) NULL,
    [Email] NVARCHAR (MAX) NULL,
    [STK] NVARCHAR (MAX) NULL,
    [SoDU] NVARCHAR (MAX) NULL,
    [LuotThue] NVARCHAR (MAX) NULL,
    [TenTaiKhoan] NVARCHAR(MAX) NOT NULL, 
    [MatKhau] NVARCHAR(MAX) NOT NULL,
    VaiTro NVARCHAR(MAX) NOT NULL,
	DanhGiaTrungBinh NVARCHAR(MAX) NOT NULL,
    TrangThai NVARCHAR(MAX) NOT NULL,
    CONSTRAINT [PK_worker] PRIMARY KEY ([ID])
);
INSERT INTO Worker (ID, Ten, GioiTinh, SDT, DiaChi, CCCD, NgaySinh, Email, STK, SoDU, LuotThue, TenTaiKhoan, MatKhau, VaiTro, DanhGiaTrungBinh, TrangThai)
VALUES
    ('200001', N'Nguyễn Văn A', N'Nam', '0123456789', N'Hà Nội', '123456789', '1990-01-01', 'nguyenvana@example.com', '1234567890', '5000000', '2', N'A', N'@123', N'Người Dùng', N'5', N'Hoạt động'),
    ('200002', N'Nguyễn Thị B', N'Nữ', '0987654321', N'Hồ Chí Minh', '987654321', '1995-05-05', 'nguyenthib@example.com', '0987654321', '3000000', '3', N'B', N'@123', N'Người Dùng', N'4', N'Tạm nghỉ'),
    ('200003', N'Phạm Văn C', N'Nam', '0123456789', N'Hải Phòng', '123456789', '1985-03-15', 'phamvanc@example.com', '1234567890', '4000000', '4', N'C', N'@123', N'Người Dùng', N'4.5', N'Hoạt động'),
    ('200004', N'Trần Thị D', N'Nữ', '0123456789', N'Đà Nẵng', '123456789', '1993-10-20', 'trand@example.com', '1234567890', '6000000', '5', N'D', N'@123', N'Người Dùng', N'4', N'Hoạt động'),
    ('200005', N'Lê Văn E', N'Nam', '0123456789', N'Cần Thơ', '123456789', '1991-08-18', 'levane@example.com', '1234567890', '4500000', '3', N'E', N'@123', N'Người Dùng', N'3.5', N'Tạm nghỉ');

INSERT INTO Worker (ID, Ten, GioiTinh, SDT, DiaChi, CCCD, NgaySinh, Email, STK, SoDU, LuotThue, TenTaiKhoan, MatKhau, VaiTro, DanhGiaTrungBinh, TrangThai)
VALUES
    ('200006', N'Nguyễn Thị F', N'Nữ', '0987654321', N'Hải Dương', '987654321', '1994-09-25', 'nguyenthif@example.com', '0987654321', '3500000', '3', N'F', N'@123', N'Người Dùng', N'4.2', N'Hoạt động'),
    ('200007', N'Trần Văn G', N'Nam', '0123456789', N'Vũng Tàu', '123456789', '1992-06-30', 'tranvg@example.com', '1234567890', '5500000', '4', N'G', N'@123', N'Người Dùng', N'4.6', N'Hoạt động'),
    ('200008', N'Hoàng Thị H', N'Nữ', '0123456789', N'Quảng Ninh', '123456789', '1988-12-10', 'hoangthih@example.com', '1234567890', '4500000', '5', N'H', N'@123', N'Người Dùng', N'3.8', N'Tạm nghỉ'),
    ('200009', N'Lê Văn I', N'Nam', '0123456789', N'Bình Dương', '123456789', '1996-03-20', 'levani@example.com', '1234567890', '4800000', '3', N'I', N'@123', N'Người Dùng', N'4.1', N'Hoạt động'),
    ('200010', N'Phạm Thị K', N'Nữ', '0123456789', N'Long An', '123456789', '1997-07-15', 'phamthik@example.com', '1234567890', '3200000', '4', N'K', N'@123', N'Người Dùng', N'3.9', N'Tạm nghỉ');

select * from Worker