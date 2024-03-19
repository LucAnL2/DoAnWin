CREATE TABLE [dbo].[DangViec] (
    [ID] NVARCHAR (50) NOT NULL,
    [NgheNghiep] NVARCHAR (MAX) NULL,
    [NgayLamViec] NVARCHAR (MAX) NULL,
    [GioLam] NVARCHAR (MAX) NULL,
    [GiaThue] NVARCHAR (MAX) NULL,
    NamKinhNghiem NVARCHAR (MAX) NULL,
    [MoTa] NVARCHAR (MAX) NULL
    );
INSERT INTO [DangViec] (ID, NgheNghiep, NgayLamViec, GioLam, GiaThue, NamKinhNghiem, MoTa)
VALUES
    ('1', N'Kỹ sư', 'ca tuan', '8', '2000000', '5', N'5 năm kinh nghiệm làm việc trong ngành'),
    ('2', N'Kế toán', 'ca tuan', '7', '1500000', '3', N'3 năm kinh nghiệm làm kế toán');
select * from DangViec;