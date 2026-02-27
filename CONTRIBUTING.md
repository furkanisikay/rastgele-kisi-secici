# Katkı Rehberi

Bu projeye katkı sağlamak istediğiniz için teşekkürler!

## Geliştirme Akışı

1. Repoyu forklayın ve yeni bir branch oluşturun.
2. Değişikliği mümkün olduğunca küçük ve odaklı tutun.
3. Kod stilini mevcut proje yapısı ile uyumlu koruyun.
4. Derleme adımlarını yerelde doğrulayın.
5. Açıklayıcı bir Pull Request açın.

## Yerel Derleme

```bash
nuget restore "Rastgele Üretici.sln"
msbuild "Rastgele Üretici.sln" /p:Configuration=Debug
```

## Pull Request Kontrol Listesi

- [ ] Değişiklik tek bir amaca odaklı
- [ ] Mevcut davranışı bozan gereksiz değişiklik yok
- [ ] Gerekliyse dokümantasyon güncellendi
- [ ] Derleme adımları yerelde çalıştırıldı

## İletişim

Geliştirme önerileri ve hata raporları için issue açabilirsiniz.
