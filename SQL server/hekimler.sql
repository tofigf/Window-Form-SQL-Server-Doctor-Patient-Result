SELECT hkm.Ad,klk.Ad,seh.Ad,sob.Ad
FROM Elaveler elv
INNER JOIN Klinikalar klk ON elv.Klinika_Id=klk.Id
INNER JOIN Hekimler hkm ON klk.HekimId = hkm.Id
INNER JOIN	Seherler seh ON elv.Seher_Id=seh.Id
INNER JOIN Sobeler sob ON elv.Sobe_Id=sob.Id
