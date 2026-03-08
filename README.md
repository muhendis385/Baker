# 🥖 Fırın Otomasyon & Portföy Yönetim Sistemi

Bu proje, bir fırın işletmesinin dijital dünyadaki yüzü olması için tasarlanmış, modern web teknolojileriyle geliştirilmiş bir **Full-Stack** çalışmasıdır. Hem kullanıcıların ürünleri inceleyebileceği bir arayüzü hem de işletme sahibinin tüm verileri yönetebileceği kapsamlı bir **Admin Paneli** içerir.

## 🎯 Projenin Amacı
Geleneksel bir fırın işletmesinin ürün kataloğunu dijital ortama taşımak, ürün güncellemelerini (fiyat, stok, açıklama) teknik bilgi gerektirmeden bir panel üzerinden yönetilmesini sağlamak ve temiz bir mimari ile sürdürülebilir bir yazılım yapısı oluşturmaktır.

## 🛠 Kullanılan Teknolojiler

### **Backend (Arka Plan)**
* **Framework:** .NET Core 8.0
* **Mimari:** N-Tier Architecture (Katmanlı Mimari - DataAccess, Business, Entity, Web)
* **Veritabanı:** MSSQL Server
* **ORM:** Entity Framework Core (Code First Yaklaşımı)

### **Frontend (Arayüz)**
* **Template Engine:** ASP.NET Core Razor Views
* **Tasarım:** Bootstrap 5, HTML5, CSS3
* **Dinamik Yapı:** JavaScript & jQuery

## 🚀 Öne Çıkan Özellikler

* **Gelişmiş Admin Paneli:** Ürünlerin, kategorilerin ve iletişim mesajlarının tam kontrolü.
* **CRUD İşlemleri:** Ürün ekleme, listeleme, güncelleme ve silme fonksiyonları.
* **Responsive Tasarım:** Mobil, tablet ve masaüstü cihazlarla %100 uyumlu arayüz.
* **Katmanlı Mimari:** İş mantığı (Business), veri erişimi (Data) ve varlıkların (Entity) birbirinden ayrıldığı profesyonel kod yapısı.
* **İletişim Yönetimi:** Kullanıcılardan gelen mesajların admin panelinde görüntülenmesi.

## 📸 Projeden Kareler (Web Sitesi)
<img width="2822" height="1532" alt="1" src="https://github.com/user-attachments/assets/56452488-7ef3-4e5e-998c-9af3a82745ab" />
<img width="2824" height="1532" alt="2" src="https://github.com/user-attachments/assets/4916341a-b0e1-419c-9bf6-7b703534ea55" />
<img width="2822" height="1530" alt="3" src="https://github.com/user-attachments/assets/ae5abcb9-54ee-43eb-8af4-74e0a656f92f" />
<img width="2820" height="1532" alt="4" src="https://github.com/user-attachments/assets/fa2f0e80-3fa5-4621-a123-a5a91a8b758e" />
<img width="2820" height="1528" alt="5" src="https://github.com/user-attachments/assets/f54aa6e2-e3f5-4a1b-b690-767065dd260e" />
<img width="2822" height="1536" alt="6" src="https://github.com/user-attachments/assets/597f7167-6371-458e-af3e-6d8ea3119d2e" />
<img width="2824" height="1534" alt="7" src="https://github.com/user-attachments/assets/01d41dff-905e-4ced-ae4b-0b49280e7ae9" />
<img width="2852" height="1530" alt="8" src="https://github.com/user-attachments/assets/e2ca560c-9697-4298-a786-d368e027a0a0" />
<img width="2824" height="1530" alt="9" src="https://github.com/user-attachments/assets/13095e87-e884-42e3-ab71-873444642973" />


🔑 Yönetim Paneli (PurpleAdmin)
<img width="2822" height="1532" alt="1" src="https://github.com/user-attachments/assets/5345c9e2-c1a3-4f72-b616-98e0055ddb17" />
<img width="2824" height="1532" alt="3" src="https://github.com/user-attachments/assets/38d1ea07-3975-4fa7-9910-f3ddac9a1ede" />
<img width="2824" height="1530" alt="5" src="https://github.com/user-attachments/assets/95833d3a-df99-4f06-936d-888270d702e6" />
<img width="2838" height="1522" alt="1" src="https://github.com/user-attachments/assets/97d198ca-5f94-4511-b671-91230332d349" />
<img width="2818" height="1524" alt="2" src="https://github.com/user-attachments/assets/a1359cca-6ec7-4fe9-92a5-e98a26e6e5ab" />
<img width="2844" height="1530" alt="2" src="https://github.com/user-attachments/assets/99a58bff-b401-4ea1-9295-8a3f0554efe5" />
<img width="2854" height="1530" alt="3" src="https://github.com/user-attachments/assets/98b2b2e6-8c73-4847-b026-88313529de97" />

## ⚙️ Kurulum

1. Projeyi bilgisayarınıza indirin: `git clone https://github.com/muhendis385/Baker.git`
2. `appsettings.json` dosyasındaki `ConnectionStrings` bölümünü kendi SQL Server adresinize göre güncelleyin.
3. **Package Manager Console** üzerinden şu komutu çalıştırarak veritabanını oluşturun:
   `Update-Database`
4. Projeyi Visual Studio üzerinden **Run** (F5)
