# Shelter API — Hayvan Barınağı Yönetim Sistemi

ASP.NET Core 8 ile geliştirilmiş REST API projesi. OOP prensiplerini, Design Pattern'leri ve katmanlı mimari standartlarını göstermek amacıyla yapılmıştır.

##  OOP Prensipleri (Nesne Yönelimli Programlama)

- **Encapsulation (Kapsülleme):** `Animal` sınıfında `Name`, `Age` gibi kritik alanlar `private set` ile korunmakta ve kapsüllenmektedir.
- **Abstraction (Soyutlama):** Genel hayvan şablonu için `Animal` soyut (abstract) sınıfı, sahiplenme davranışları için ise `IAdoptable` arayüzü (interface) kullanılmıştır.
- **Inheritance (Kalıtım):** `Dog`, `Cat` ve `Bird` sınıfları ortak özellikleri tek bir merkezden yönetmek adına `Animal` sınıfından türetilmiştir.
- **Polymorphism (Çok Biçimlilik):** `MakeSound()` metodu `Animal` sınıfında tanımlanıp, her hayvan türünde (Köpek, Kedi vb.) kendi sesini çıkaracak şekilde `override` edilerek çok biçimlilik sağlanmıştır.

##  Design Patterns (Tasarım Kalıpları)

- **Singleton Pattern:** Uygulama genelinde anlık istatistikleri (toplam hayvan, sahiplendirilen hayvan sayısı vb.) tutarlı bir şekilde tek bir nesne üzerinden yönetmek için `ShelterStats` sınıfında uygulanmıştır.
- **Repository Pattern:** Veritabanı işlemlerini iş mantığından (Controller) soyutlamak ve kodun test edilebilirliğini artırmak amacıyla `IRepository<T>` ve `DogRepository` yapıları kurulmuştur.

##  Teknolojiler

- ASP.NET Core 8 Web API
- Entity Framework Core (Code-First) + SQLite
- Swagger / OpenAPI
- DTO (Data Transfer Object) Kullanımı

##  Çalıştırma

Projeyi yerel bilgisayarınızda ayağa kaldırmak için terminalde aşağıdaki komutları sırasıyla çalıştırabilirsiniz:

```bash
dotnet restore
dotnet ef database update
dotnet run
