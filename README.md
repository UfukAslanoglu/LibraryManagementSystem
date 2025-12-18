# 📚 Akıllı Kütüphane Otomasyon Sistemi (Smart Library System)

![Language](https://img.shields.io/badge/Language-C%23-green) ![Platform](https://img.shields.io/badge/Platform-Windows%20Forms-blue) ![Database](https://img.shields.io/badge/Database-SQL%20Server-red) ![Status](https://img.shields.io/badge/Status-Completed-success)

> **Kırklareli Üniversitesi - Görsel Programlama Dersi Dönem Projesi**

Bu proje, üniversite kütüphanesindeki kitap alışverişini dijitalleştirmek, manuel kayıtların zorluklarını aşmak ve ödünç alma süreçlerini güvenli bir şekilde yönetmek amacıyla geliştirilmiş **C# Windows Form** uygulamasıdır.

---

## 🚀 Proje Hakkında

**Akıllı Kütüphane**, sadece bir kitap listesi değildir; **Öğrenci, Personel ve Yönetici** olmak üzere 3 farklı yetki seviyesine sahip kapsamlı bir otomasyon sistemidir. Proje geliştirilirken **Nielsen'in Kullanılabilirlik İlkeleri** (Hata Önleme, Sistem Durumu Görünürlüğü vb.) temel alınmıştır.

### 🎯 Temel Özellikler

| Rol | Yetkiler ve İşlevler |
| :--- | :--- |
| **👨‍🎓 Öğrenci** | • **Gelişmiş Arama:** Yazar, Kitap Adı veya Kategoriye göre anlık filtreleme.<br>• **Stok Takibi:** Kitabın raf bilgisini (Örn: A-1) ve stok durumunu görme.<br>• **Ödünç İsteme:** Stokta olan kitaplar için tek tıkla talep oluşturma.<br>• **Süreç Takibi:** Talebin onaylanıp onaylanmadığını canlı izleme. |
| **💼 Personel** | • **Talep Yönetimi:** Öğrencilerden gelen talepleri görüntüleme.<br>• **Teslim & İade:** Kitabı fiziksel olarak teslim etme ve geri alma (Stok otomatik güncellenir).<br>• **Gecikme Kontrolü:** Zamanında gelmeyen kitapların takibi. |
| **🛠️ Yönetici** | • **Envanter Yönetimi:** Yeni kitap ekleme, silme, güncelleme (Resimli ve Özetli).<br>• **Kullanıcı Yönetimi:** Üyeleri listeleme ve Rol atama (Öğrenciyi Personel yapma).<br>• **Raporlama:** "En Çok Okunan Kitaplar" gibi SQL tabanlı istatistikler. |

---

## 🛠️ Kurulum ve Çalıştırma (Nasıl Çalışır?)

Projeyi bilgisayarınızda hatasız çalıştırmak için lütfen aşağıdaki adımları izleyin:

### 1. Projeyi İndirin
Bu sayfadaki **Code** butonuna basıp **Download ZIP** diyerek veya Git komutuyla indirin:
```bash
git clone [https://github.com/UfukAslanoglu/AkilliKutuphane-CSharp.git](https://github.com/UfukAslanoglu/AkilliKutuphane-CSharp.git)
