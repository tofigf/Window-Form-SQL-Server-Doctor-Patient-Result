SELECT hk.Ad,  sob.Ad,sh.Ad,kl.Ad
 FROM Hekimler hk
 INNER JOIN Sobeler sob ON hk.sobeId=sob.id
 INNER JOIN Seherler sh ON hk.sherlerId=sh.Id
 INNER JOIN klinika kl  ON hk.klinikaId=kl.Id
