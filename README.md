# Rastgele Kişi Seçici

[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.5-512BD4?logo=.net&logoColor=white)](https://dotnet.microsoft.com/)
[![C%23](https://img.shields.io/badge/C%23-5.0%2B-239120?logo=c-sharp&logoColor=white)](https://learn.microsoft.com/dotnet/csharp/)
[![Windows Forms](https://img.shields.io/badge/UI-Windows%20Forms-0078D6)](https://learn.microsoft.com/dotnet/desktop/winforms/)
[![Lisans: MIT](https://img.shields.io/badge/Lisans-MIT-green.svg)](./LICENSE)

## Neden Bu Proje?

Rastgele Kişi Seçici; çekiliş, görev dağıtımı, sınıf içi seçim veya ekip içi adil atama gibi senaryolarda, bir kişi listesinden hızlı ve görsel olarak anlaşılır şekilde rastgele seçim yapma ihtiyacını çözer. Tekrarlı seçimleri engelleyebilmesi, sonuçları ayrı pencerede belirgin biçimde gösterebilmesi ve basit arayüzü sayesinde teknik olmayan kullanıcılar tarafından da rahatça kullanılabildiği için pratik ve değerli bir masaüstü aracıdır.

## Mimari / Özellikler

- MetroFramework tabanlı **Windows Forms** arayüzü ile sade kullanım deneyimi.
- Listeyi `kisiler.txt` dosyasından okuyarak başlangıç verisini otomatik yükleme.
- "Seçilenleri listede tut" seçeneği ile **tekrarsız seçim** desteği.
- Seçilen kişiyi ana formda ve ikinci formda büyük puntoyla gösterme.
- Rastgele renk ataması ile seçilen sonucu görsel olarak vurgulama.
- Gömülü kaynak (`Properties.Resources.kisiler`) ile eksik dosya durumunda güvenli geri yükleme.

## Kod Denetimi ve Güvenlik Notları

- Kod tabanı hardcoded şifre, API anahtarı ve sabit kullanıcı dizini (ör. `C:\Users\...`) açısından tarandı.
- Mevcut sürümde kritik gizli bilgi sızıntısı tespit edilmedi.
- Dosya yolu oluşturma satırı güvenli ve platform uyumlu yöntemle `Path.Combine(...)` kullanacak şekilde güncellendi.
- İleride harici servis entegrasyonu eklenirse gizli bilgiler için `App.config` + çevresel değişken yaklaşımı tercih edilmelidir.

## Refactoring (Yeniden Düzenleme) – Kritik 3 Adım

1. **İş kurallarını form katmanından ayırma:** Rastgele seçim, dosya okuma ve sayaç güncelleme mantığını `SelectionService` benzeri ayrı sınıflara taşıyarak test edilebilirliği artırın.
2. **Asenkron/iş parçacığı güvenliği iyileştirmesi:** `CheckForIllegalCrossThreadCalls = false` yaklaşımı yerine UI güncellemelerini `Invoke/BeginInvoke` ile güvenli hale getirin.
3. **Hata yönetimini merkezileştirme:** `ArgumentOutOfRangeException` ile akış kontrolü yerine seçim öncesi öğe sayısı doğrulaması yaparak daha okunabilir ve sürdürülebilir kod elde edin.

## Hızlı Başlangıç (2 Dakika)

> Bu proje `net45` tabanlı klasik Windows Forms uygulamasıdır. En sorunsuz kurulum için **Windows + Visual Studio** önerilir.

```bash
git clone https://github.com/furkanisikay/rastgele-kisi-secici.git
cd rastgele-kisi-secici
nuget restore "Rastgele Üretici.sln"
msbuild "Rastgele Üretici.sln" /p:Configuration=Release
```

Derleme sonrası uygulamayı çalıştırın:

```bash
"bin/Release/Rastgele Üretici.exe"
```

## Ortam Kurulumu

1. **Gereksinimler**
   - Windows 10/11
   - Visual Studio 2019+ (Desktop development with .NET)
   - .NET Framework 4.5 Developer Pack
2. **Kişi listesi yapılandırması**
   - Uygulama ilk açılışta çalışma dizininde `kisiler.txt` arar.
   - Dosya yoksa gömülü varsayılan liste otomatik oluşturulur.
   - Her satıra bir kişi gelecek şekilde `kisiler.txt` düzenleyebilirsiniz.
3. **Paket bağımlılığı**
   - `packages.config` üzerinden `MetroModernUI (1.3.5.0)` kullanılır.

## Katkı

Katkı sürecinin tamamı için [CONTRIBUTING.md](./CONTRIBUTING.md) dosyasına bakın.

## Lisans

Bu proje [MIT Lisansı](./LICENSE) ile lisanslanmıştır.
