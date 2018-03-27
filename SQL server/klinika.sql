SELECT sh.Ad  FROM Seherler sh
INNER JOIN	Klinikalar kl ON sh.hekimId.Id


SELECT  kl.Ad  FROM Klinikalar kl 
 INNER JOIN Hekimler hk ON kl.HekimId = hk.Id 