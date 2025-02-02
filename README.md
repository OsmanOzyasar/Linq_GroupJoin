# LINQ GroupJoin Kullanımı Örnek Projesi

## Açıklama

Bu proje, **C# LINQ** kullanarak **GroupJoin** işlemini göstermektedir.

Projede **Classes (Sınıflar)** ve **Students (Öğrenciler)** olmak üzere iki liste bulunmaktadır.
Bu listeler **ClassId** ve **Id** alanları üzerinden ilişkilendirilerek, her sınıfa ait öğrenciler listelenmektedir.

## Kullanılan Teknolojiler

- **C# (C-Sharp)**
- **.NET**
- **LINQ (Language Integrated Query)**

## Kod Açıklaması

Kod içerisinde **Classes** ve **Students** listeleri oluşturulmuştur:

```csharp
List<Classes> classes = new List<Classes>()
{
    new Classes {ClassName = "Matematik", ClassId = 1},
    new Classes {ClassName = "Türkçe", ClassId = 2},
    new Classes {ClassName = "Kimya", ClassId = 3}
};

List<Students> students = new List<Students>()
{
    new Students {StudentName = "Ayşe", StudentId = 1, Id = 2 },
    new Students {StudentName = "Furkan", StudentId = 2, Id = 2 },
    new Students {StudentName = "İrem", StudentId = 3, Id = 1 },
    new Students {StudentName = "Emir", StudentId = 4, Id = 3 },
    new Students {StudentName = "Uğur", StudentId = 5, Id = 3 },
};
```

Yukarıdaki listeler **GroupJoin** ile birleştirilmiştir:

```csharp
var gJoinedClass = classes.GroupJoin(students,
                                     classess => classess.ClassId,
                                     student => student.Id,
                                     (studentClass, student) => new
                                     {
                                         Student = student.ToList(),
                                         StudentClass = studentClass
                                     });
```

Sonuçlar şu formatta ekrana yazdırılmaktadır:

```csharp
foreach (var item in gJoinedClass)
{
    Console.WriteLine($"Sınıf: {item.StudentClass.ClassName}");

    foreach (var x in item.Student)
    {
        Console.WriteLine($"Öğrenci: {x.StudentName}");
    }
}
```

## Örnek Çıktı

Kod çalıştırıldığında ekrana şu formatta sonuçlar yazdırılır:

```
Sınıf: Matematik
Öğrenci: İrem
Sınıf: Türkçe
Öğrenci: Ayşe
Öğrenci: Furkan
Sınıf: Kimya
Öğrenci: Emir
Öğrenci: Uğur
```

## Çalıştırma Talimatları

1. **Proje dosyasını açın** (Visual Studio veya uygun bir C# geliştirme ortamında)
2. **Program.cs** dosyasını çalıştırın
3. **Ekrana sınıfların ve öğrencilerin ilişkilendirildiğini gözlemleyin**

## Katkıda Bulunma

Bu projeye katkıda bulunmak için lütfen **pull request** gönderin veya hataları bildiriniz. 😊

