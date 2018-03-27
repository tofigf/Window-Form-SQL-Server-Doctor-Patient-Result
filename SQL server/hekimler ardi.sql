SELECT el.Id FROM Elaveler el
INNER JOIN Klinikalar kl ON el.Klinika_Id=kl.Ad

SELECT  kl.Ad  FROM Klinikalar kl 
 INNER JOIN Hekimler hk ON kl.HekimId = hk.Id 
                                
