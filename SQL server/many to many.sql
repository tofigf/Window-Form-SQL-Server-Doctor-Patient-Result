--SELECT hk.Ad,kl.Ad
--FROM Hekimler hk
--INNER JOIN Hekim_Klinika hkl ON hkl.Hekim_ID = hk.id
--INNER JOIN klinika kl ON kl.Id=hkl.Klnika_ID




SELECT h.Ad
FROM klinika kl
INNER JOIN Hekim_Klinika hk ON hk.Klnika_ID=kl.Id
INNER JOIN Hekimler h ON h.id =hk.Hekim_ID











--SELECT hk.Adlar,kl.Adlar 
--FROM Klinikalar kl
--INNER JOIN Hekim_Klinika h_k ON h_k.Klinika_ID=kl.ID 
--INNER JOIN Hekimler hk ON hk.ID =h_k.Hekim_ID