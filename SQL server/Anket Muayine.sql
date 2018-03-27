
SELECT Anket.ID,Anket.Ad_Soyad,Anket.Email,Anket.Nomre,mua.Novu,Anket.DateTimePicker,gun.Hisse
FROM Anket
INNER JOIN Muayine mua ON Anket.Muayine_ID=mua.ID
INNER JOIN Gunun_Hissesi gun ON Anket.Gun_Hisse_ID=gun.ID








