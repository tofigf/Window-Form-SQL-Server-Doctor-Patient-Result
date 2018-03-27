SELECT hk.Ad,  sob.Ad,sh.Ad,kl.Ad,it.IsTecrubesi,ix.Haqqinda,si.Haqqinda,th.Haqqinda
 FROM Hekimler hk
 INNER JOIN Sobeler sob ON hk.sobeId=sob.id
 INNER JOIN Seherler sh ON hk.sherlerId=sh.Id
 INNER JOIN klinika kl  ON hk.klinikaId=kl.Id
INNER JOIN IsTecrubesi it ON hk.IsTecrubesi_ID=it.ID
INNER JOIN Ixtisas ix ON hk.Ixtisas_ID=ix.ID
INNER JOIN Sexsi_Info si ON hk.Sexsi_Info_ID=si.ID
INNER JOIN Tehsil th ON hk.Tehsil_ID=th.ID