SELECT DISTINCT DangViec.ID, Ten, SDT, NgheNghiep FROM DangViec INNER
JOIN Worker ON Worker.ID = DangViec.ID WHERE NgheNghiep = N'Thợ máy'
AND CONVERT(FLOAT, DangViec.GiaThue) *8*30 between 10000 and 12000
 *8*30 between 10000 and 12000


 SELECT DISTINCT DangViec.ID, Ten, SDT, NgheNghiep FROM DangViec INNER
JOIN Worker ON Worker.ID = DangViec.ID WHERE NgheNghiep = N'Thợ máy'
AND (CONVERT(FLOAT, DangViec.GiaThue) *8*30 between 8000 and 10000 OR
CONVERT(FLOAT, DangViec.GiaThue) *8*30 between 10000 and 20000)