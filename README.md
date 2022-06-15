# Basket

Net ödenecek olan tutarın hesaplandığı alan. Sınıf yaratılırken bir adet ProductManager listesi ve CustomerManeger almak zorunda.
-InvoicePrice methodu çağırıldığında ilk etapta kullanıcının kart tipine bakar, eğer gold veya silver kart ise indirimi belirler.
Eğer standard kart ise ilk olarak müşterinin mağazaya bağlı olup olmadığına bakılır ve bağlı değilse son olarak mağazaya kayıt olduğu zamandan iki yıl geçmiş mi diye kontrol sağlanıyor.

-PercentageDiscount methodu yukarıda belirlenen indirimi değişken olarak alıyor ve methodun içinde bütün ürünlere bakılıyor. Her ürüne bakılırken ürün tipi telefon mu    kontrolü sağlanıyor. Eğer ürün telefon ise kullanıcı bu indirimden yararlanamıyor. Telefon olmayan ürünlere indirim sağlanıp hesaplanan bakiye toplam fiyat değişkenine ekleniyor. Geriye toplam fiyat değişkenini döndürüyor.

-LastPrice methodu yukarıda hesaplanan toplam fiyat değişkenini alıyor. Bu method toplam fiyatın içinde kaç adet 200 dolar mevcut olduğuna bakıyor.
Adet sayı * 5 yaparak toplam fiyattan çıkartıyor. Geriye fiyat değişkenini döndürüyor.

# CustomerManager

Müşteri bilgilerinin tutulduğu alan, sınıfı yaratırken iki farklı seçenek var.

# ProductManager

Ürün bilgilerinin tutulduğu alan, sınıfı yaratırken iki farklı seçenek var.

# enum Cards

Müşterilerin alabileceği kart tipleri

# enum Products

Ürün tipleri
