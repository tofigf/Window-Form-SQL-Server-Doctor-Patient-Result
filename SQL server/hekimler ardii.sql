SELECT qb.Ad,qb.Email,qb.Nomre,qb.Sigorta,qb.Tarix,my.Adi
 FROM Qebul qb
 INNER JOIN Muayine my ON qb.Muayine_Id=my.Id 