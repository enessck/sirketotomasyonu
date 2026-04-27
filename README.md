# Şirket Otomasyonu (Company Management System)

C# WinForms ve MS SQL Server kullanılarak geliştirilmiş, modern ve karanlık (dark) arayüze sahip kapsamlı bir şirket yönetim ve otomasyon masaüstü uygulamasıdır. Bu proje, bir şirketin günlük ticari operasyonlarını (stok takibi, müşteri ilişkileri, muhasebe işlemleri vb.) tek bir merkezden kolayca yönetebilmesi için tasarlanmıştır.

## 🚀 Özellikler (Modüller)

*   **Genel Bakış (Anasayfa):** Şirketin tüm güncel özet verilerini (kasa durumu, toplam personel, stok vb.) anlık olarak gösteren dinamik pano.
*   **📦 Ürün & Stok Yönetimi:** Sisteme yeni ürün ekleme, çıkarma, güncelleme ve anlık stok takibi yapabilme.
*   **👥 Müşteriler & Şirketler:** Bireysel müşterilerin ve kurumsal firmaların iletişim, adres ve işlem bilgilerini kayıt altında tutma.
*   **👨‍💼 Personel Yönetimi:** Çalışanların kişisel bilgileri, pozisyonları ve iletişim detaylarının organizasyonu.
*   **💸 Gider & Fatura Takibi:** Şirketin rutin giderlerini kaydetme, gelen/giden faturaların detaylı takibi ve raporlaması.
*   **🏦 Kasa & Bankalar:** Nakit akışını kontrol etme, banka hesap özetleri ve şirket kasasındaki güncel durumu izleme.

## 🛠 Kullanılan Teknolojiler

*   **Programlama Dili:** C# (.NET 10.0)
*   **Kullanıcı Arayüzü:** Windows Forms (WinForms)
*   **Veritabanı:** Microsoft SQL Server
*   **Mimari & Veri Erişimi:** ADO.NET (Merkezi `SqlBaglanti` sınıfı ile optimize edilmiş Singleton mimarisi)
*   **İkonlar:** İnternet üzerinden asenkron olarak indirilen ve önbelleğe alınan dinamik ikon mimarisi (Icons8).

## ⚙️ Kurulum ve Çalıştırma

1.  **Veritabanını Hazırlama:**
    *   Proje dizininde bulunan `sirketotomasyon.sql` dosyasını SQL Server Management Studio (SSMS) üzerinden açın ve çalıştırın (Execute).
    *   Bu işlem `DBOSIRKETOTOMASYON` adında bir veritabanı ve gerekli tüm tabloları otomatik olarak oluşturacaktır.
2.  **Projeyi Açma:**
    *   `şirketotomasyonu.slnx` veya `Şirketotomasyonu.csproj` dosyasını Visual Studio ile açın.
3.  **Çalıştırma:**
    *   Visual Studio üzerinde üst menüden **Build -> Rebuild Solution** (Çözümü Yeniden Derle) işlemini gerçekleştirin.
    *   **F5** tuşuna basarak veya "Başlat" butonuna tıklayarak uygulamayı çalıştırın.

## 🎨 Tasarım Notları

Uygulama arayüzü (UI), modern web ve mobil tasarımlarından ilham alınarak baştan aşağı yenilenmiştir.
*   Sol tarafta bulunan Sidebar (Yan Menü), `45, 52, 54` renk koduyla göz yormayan profesyonel bir karanlık (Dark Mode) temaya sahiptir.
*   Açılışta ikonların senkronize yüklenmesi sağlanmış, bu sayede ekran geçişlerindeki "titreme" (flickering) sorunu tamamen çözülerek pürüzsüz bir deneyim elde edilmiştir.

## 📸 Ekran Görüntüleri

*(Projenize ait 1-2 adet ekran görüntüsünü projenin ana klasörüne ekleyip buraya bağlayabilirsiniz. Örnek kullanım: `![Arayüz Görseli](arayuz_gorseli.png)`)*

---
*Bu proje geliştirilmeye açıktır.*
