var siniflar =[]
var sehirler = ["İzmir", "İstanbul", "Ankara", "Bursa", "Ordu"]; //tanımlanırken
siniflar = ["9A", "10A", "11A", "12A"]; //tanımlandıktan sonra

sehirler[0]="İzmir"; //eleman atama işlemi
sehirler[1]="İstanbul";

//alert("Web sayfasına "+ siniflar[2] +" sınıfından bağlanıyorsunuz");
console.log(sehirler)
console.log(siniflar)



//diziye eleman ekleme
sehirler.push("Sakarya")
console.log("sehirler dizisine yeni hali : " , sehirler)

//dizi boyutu
console.log("sehirler dizisinin uzunluğu : " , sehirler.length)

//dizi elemanlarını sıralama
console.log("sehirler dizisi sıralandı : " , sehirler.sort())

//dizi elemanlarını ters çevirme
console.log("sehirler dizisi ters çevrildi : " ,sehirler.reverse())

//dizinin sonundaki elemanı çıkarır
sehirler.pop();
console.log("sehirler dizisinden son eleman çıkarıldı" , sehirler)

//verilen elemanın index değerini bulma
console.log("11A'nın index değeri",siniflar.indexOf("11A"))


// menu alanının oluşturulması
var menu = ["Anasayfa", "Hakkımızda","İletişim"]
function menuListele(){ // sayfa ilk açıldığında çalışacak fonksiyon oluşturuldu
    var menuAlani = document.getElementById("menu"); // menu id'sine sahip ul tagına ulaşıldı
    menuAlani.innerHTML =""; // içerisinde herhangi birşey varsa diye boş olarak değiştirildi
    menu.forEach((baslik)=>{ // menu dizisi forEach ile gezildi
        var menuListesi =`<li><a href="#"> ${baslik} </a></li>`; // diziden gelen her elemen bir html tagında kullanılarak bu html elemanı bir değişeken atıldı
        menuAlani.innerHTML += menuListesi; // += ile her gelen html elemanı ul tagının içine html tagı olarak eklendi
    });
};