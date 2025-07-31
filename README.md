# InnerJoinForeginKey
UygulamaProjem

InnerJoin-ForeginKey
InnerJoin ve ForeginKey Alıştırma Projem

-1)DataBase oluşturma Sorgusu

--CREATE DATABASE Join_Alistirma;

--GO

--USE Join_Alistirma;

--GO

--2)musteri Tablosu oluşturma

--CREATE TABLE musteri (

-- musteri_ID INT IDENTITY(1,1) PRIMARY KEY,

-- adi_soyadi NVARCHAR(100) NOT NULL,

-- telefon NVARCHAR(20) NOT NULL

--);

---3)araclar Tablosunu Oluştur (FOREIGN KEY ile)

--CREATE TABLE araclar (

-- id INT IDENTITY(1,1) PRIMARY KEY,

-- musteri_ID INT NOT NULL,

-- plaka NVARCHAR(20) NOT NULL,

-- marka NVARCHAR(50),

-- model NVARCHAR(50),

-- yil INT,

-- FOREIGN KEY (musteri_ID) REFERENCES musteri(musteri_ID)

--);

----NOT

--musteri_ID → musteri tablosuyla bağlantılı olacak.

--plaka, marka, model, yil alanları araç bilgilerini tutacak.

---4)Tablolara musteri ve araclar Tablosuna Veri ekleme

--INSERT INTO musteri (adi_soyadi, telefon)

--VALUES ('Savaş Adıgüzel', '07553334444');

--INSERT INTO araclar (musteri_ID, plaka, marka, model, yil)

--VALUES (1, '34ABC123', 'Toyota', 'Corolla', 2020);

--5) INNER JOIN a.musteri_ID = m.musteri_ID ile Verileri Birleştirdik

--SELECT

-- a.plaka, a.marka, a.model, a.yil,

-- m.adi_soyadi, m.telefon

--FROM araclar a

--INNER JOIN musteri m ON a.musteri_ID = m.musteri_ID;

--Not*** Her tablonun kendi Id si ni otomatik artan yapılmalı sonucta elle Id girilemez

--id INT IDENTITY(1,1) PRIMARY KEY, şeklinde 1,1 artan olarak tabloların ID leri otomatik hale geldi.

ÇIKTI :

<img width="798" height="543" alt="image" src="https://github.com/user-attachments/assets/aafc93ac-0156-461a-81fb-e98ed5e5baad" />


Uygulama Görseli :


<img width="834" height="539" alt="image" src="https://github.com/user-attachments/assets/a69787a0-f897-45eb-8996-706482058991" />


image
