var menu = ["Anasayfa", "Hakkımızda","İletişim"]
function menuListele(){ // sayfa ilk açıldığında çalışacak fonksiyon oluşturuldu
    var menuAlani = document.getElementById("menu"); // menu id'sine sahip ul tagına ulaşıldı
    menuAlani.innerHTML =""; // içerisinde herhangi birşey varsa diye boş olarak değiştirildi
    menu.forEach((baslik)=>{ // menu dizisi forEach ile gezildi
        var menuListesi =`<a class="nav-link" href="#">${baslik}</a>`; // diziden gelen her elemen bir html tagında kullanılarak bu html elemanı bir değişeken atıldı
        menuAlani.innerHTML += menuListesi; // += ile her gelen html elemanı ul tagının içine html tagı olarak eklendi
    });
};

var urunler =[
    {
        imgYol:"img/ayakkabi.png",
        urunBaslik:"Card title 1",
        urunAciklama:"Some quick example text to build on the card title and make up the bulk of the card's content.",
        urunSayfasi:"www.google.com"
    },
    {
        imgYol:"img/ayakkabi.png",
        urunBaslik:"Card title 2",
        urunAciklama:"Some quick example text to build on the card title and make up the bulk of the card's content.",
        urunSayfasi:"www.google.com"
    },
    {
        imgYol:"img/ayakkabi.png",
        urunBaslik:"Card title 3",
        urunAciklama:"Some quick example text to build on the card title and make up the bulk of the card's content.",
        urunSayfasi:"www.google.com"
    },
    {
        imgYol:"img/ayakkabi.png",
        urunBaslik:"Card title 4",
        urunAciklama:"Some quick example text to build on the card title and make up the bulk of the card's content.",
        urunSayfasi:"www.google.com"
    },
    {
        imgYol:"img/ayakkabi.png",
        urunBaslik:"Card title 5",
        urunAciklama:"Some quick example text to build on the card title and make up the bulk of the card's content.",
        urunSayfasi:"www.google.com"
    },
    {
        imgYol:"img/ayakkabi.png",
        urunBaslik:"Card title 6",
        urunAciklama:"Some quick example text to build on the card title and make up the bulk of the card's content.",
        urunSayfasi:"www.google.com"
    },
    {
        imgYol:"img/ayakkabi.png",
        urunBaslik:"Card title 7",
        urunAciklama:"Some quick example text to build on the card title and make up the bulk of the card's content.",
        urunSayfasi:"www.google.com"
    },
    {
        imgYol:"img/ayakkabi.png",
        urunBaslik:"Card title 8",
        urunAciklama:"Some quick example text to build on the card title and make up the bulk of the card's content.",
        urunSayfasi:"www.google.com"
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
                      <a href="${urun.urunSayfasi}" class="btn btn-primary">Go somewhere</a>
                    </div>
                  </div>
            </div>
        `;
        urunAlani.innerHTML += urunListesi;
    })
}