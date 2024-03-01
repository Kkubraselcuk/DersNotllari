var sepetTutari=0;
var sepet = []
var menu = ["Anasayfa", "Hakkımızda","İletişim"]
function menuListele(){ 
    var menuAlani = document.getElementById("menu"); 
    menuAlani.innerHTML =""; 
    menu.forEach((baslik)=>{ 
        var menuListesi =`<a class="nav-link" href="#">${baslik}</a>`; 
        menuAlani.innerHTML += menuListesi; 
    });
};
var urunler =[
    {
        id: 1,
        imgYol:"img/ayakkabi.png",
        urunBaslik:"Card title 1",
        urunAciklama:"Some quick example text to build on the card title and make up the bulk of the card's content.",
        urunSayfasi:"www.google.com",
        fiyat: 500
    },
    {
        id: 2,
        imgYol:"img/ayakkabi.png",
        urunBaslik:"Card title 2",
        urunAciklama:"Some quick example text to build on the card title and make up the bulk of the card's content.",
        urunSayfasi:"www.google.com",
        fiyat: 300
    },
    {
        id: 3,
        imgYol:"img/ayakkabi.png",
        urunBaslik:"Card title 3",
        urunAciklama:"Some quick example text to build on the card title and make up the bulk of the card's content.",
        urunSayfasi:"www.google.com",
        fiyat: 700
    },
    {
        id: 4,
        imgYol:"img/ayakkabi.png",
        urunBaslik:"Card title 4",
        urunAciklama:"Some quick example text to build on the card title and make up the bulk of the card's content.",
        urunSayfasi:"www.google.com",
        fiyat: 600
    },
    {
        id: 5,
        imgYol:"img/ayakkabi.png",
        urunBaslik:"Card title 5",
        urunAciklama:"Some quick example text to build on the card title and make up the bulk of the card's content.",
        urunSayfasi:"www.google.com",
        fiyat: 800
    },
    {
        id: 6,
        imgYol:"img/ayakkabi.png",
        urunBaslik:"Card title 6",
        urunAciklama:"Some quick example text to build on the card title and make up the bulk of the card's content.",
        urunSayfasi:"www.google.com",
        fiyat: 350
    },
    {
        id: 7,
        imgYol:"img/ayakkabi.png",
        urunBaslik:"Card title 7",
        urunAciklama:"Some quick example text to build on the card title and make up the bulk of the card's content.",
        urunSayfasi:"www.google.com",
        fiyat: 400
    },
    {
        id: 8,
        imgYol:"img/ayakkabi.png",
        urunBaslik:"Card title 8",
        urunAciklama:"Some quick example text to build on the card title and make up the bulk of the card's content.",
        urunSayfasi:"www.google.com",
        fiyat: 500
    },
]
function urunListele(){
    var urunAlani = document.getElementById("urunler");
    urunAlani.innerHTML = "";
    urunler.forEach((urun)=>{
        var urunListesi = `
        <div class="col mt-2">
                <div class="card" style="width: 18rem;">
                    <img src="${urun.imgYol}" class="card-img-top" alt="...">
                    <div class="card-body">
                      <h5 class="card-title">${urun.urunBaslik}</h5>
                      <p class="card-text">${urun.urunAciklama}</p>
                      <button class="btn btn-primary" onclick="sepeteAt(${urun.id})"> ${urun.fiyat}TL -> Satın Al</button>
                    </div>
                  </div>
            </div>
        `;
        urunAlani.innerHTML += urunListesi;
    })
}

function sepeteAt(id){
    // id doğru geliyormu diye console'a yazdırıyoruz
    //console.log(id)
    urunler.forEach((urun)=>{

        // sepete eklenmek istenen ürün id'si listedeki nesnelerden birnin id'si ile eşleşirse çalışacak alan
        if(urun.id  == id){
            // urun bilgileri doğru mu diye kontrol sağlıyoruz
            //console.log(urun)
            //ürünü listeye ekliyoruz
            sepet.push(urun)
            sepetTutari += urun.fiyat
            //console.log("sepet",sepet)
        }
    })
}

function sepetGoruntule(){
    var sepetAlani = document.getElementById("sepetUrunler"); // menu id'sine sahip ul tagına ulaşıldı
    sepetAlani.innerHTML =""; // içerisinde herhangi birşey varsa diye boş olarak değiştirildi
    
    sepet.forEach((urun)=>{ // menu dizisi forEach ile gezildi
        //sepete eklenen ürünlerin card ile modal'a eklenmesi
        var urunListesi =`
        
        <div class="col mt-2">
            <div class="card" style="width: 10rem;">
            <img src="${urun.imgYol}" class="card-img-top" alt="...">
                <div class="card-body">
                <h5 class="card-title">${urun.urunBaslik}</h5>
                <button class="btn btn-outline-danger" onclick="sepettenSil(${urun.id})">Çıkar</button> 
                </div>
            </div>
        </div>
        
        `; 
        // sepettenSil fonksiyonu ile butona basıldığında fonksiyona o butonun bulunduğu ürünün id'si parametre verilerek fonskiyon çağrılarak ürün silme işlemi yapılıd
        sepetAlani.innerHTML += urunListesi; // += ile her gelen html elemanı ul tagının içine html tagı olarak eklendi
        
        urunListesi = ""
    });
    sepetAlani.innerHTML += `<h3 class="text-end">Sepet toplam tutar : ${sepetTutari}</h3>`  // sepetin toplam tutarı alana eklendi
}

function sepettenSil(id){
    console.log("silinmemiş sepet", sepet)
    sepet.forEach((urun)=>{
        if(urun.id == id){
            //sepette neler var bakılıdı
            //console.log(sepet)
            //sepetten silinmek istene id'ye sahip ürünün index değerine ulaşılıyormu diye kontrol edildi
            console.log(sepet.indexOf(urun))
            // gelen index değerinden başlamak üzere 1 eleman yani istene eleman silinmiş oldu
            sepet.splice(sepet.indexOf(urun),1)
            //console.log("silindi", sepet)
            //silinen ürünün tutarı sepet fiyatından silindi
            sepetTutari -= urun.fiyat
        }
    })
    
    sepetGoruntule()
}