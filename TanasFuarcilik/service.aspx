<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="service.aspx.cs" Inherits="TanasFuarcilik.service" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="single-page-header">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <h2>Servislerimiz</h2>
                    <ol class="breadcrumb header-bradcrumb justify-content-center">
                        <li class="breadcrumb-item"><a href="index.aspx" class="text-white">Anasayfa</a></li>
                        <li class="breadcrumb-item active" aria-current="page">Hizmetlerimiz</li>
                    </ol>
                </div>
            </div>
        </div>
    </section>
    <!-- blog details part start -->
    <section class="blog-details section">
        <div class="container">
            <div class="row">
                <div class="col-lg-4 mt-5 mt-lg-0">
                    <!-- sidebar -->
                    <aside class="sidebar pl-0 pl-lg-4">
                        <div class="widget-categories widget">
                            <h2>Fuar Stantları</h2>
                            <!-- widget categories list -->
                            <ul class="widget-categories-list">
                                <li>
                                    <a href="#design">Tasarım</a>
                                </li>
                                <li>
                                    <a href="#shoppingCentre">Mağaza Tasarımları</a>
                                </li>
                                <li>
                                    <a href="#product">Üretim ve Planlama</a>
                                </li>
                                <li>
                                    <a href="#congress">Kongre & Konferans Tasarımları</a>
                                </li>
                                <li>
                                    <a href="#advert">Reklam Tanıtım Hizmetleri</a>
                                </li>
                                <!-- Yeni eklenen kısım -->
                                <li>
                                    <button onclick="openPdf()">Fuar Malzeme Kiralama</button>
                                </li>
                            </ul>
                        </div>
                    </aside>
                </div>
                <div class="col-lg-8" id="design">
                    <article class="post">
                        <div class="hero-slider">
                            <div class="slider-item th-fullpage hero-area" style="background-image: url(images/service/design-1.jpg); height: 400px !important">
                            </div>
                            <div class="slider-item th-fullpage hero-area" style="background-image: url(images/service/design-2.jpg); height: 400px !important">
                            </div>
                            <div class="slider-item th-fullpage hero-area" style="background-image: url(images/service/design-3.jpg); height: 400px !important">
                            </div>
                        </div>

                        <!-- Post Content -->
                        <div class="post-content">
                            <h1 class="mt-4 text-center">Fuarcılıkta Tasarımın Önemi</h1>
                            <p>Fuarcılık sektöründe müşterilerinizin ilgisini çekmek, markanızı sergilemek ve benzersiz bir deneyim sunmak için etkileyici bir tasarım önemlidir. Web sitemizde yer alan 'tasarım' bölümü, fuarlardaki tasarım hizmetlerimizi tanıtmak ve potansiyel müşterilere yaratıcı çözümlerimizi göstermek amacıyla oluşturulmuştur. Bu yazıda, fuarcılıkta tasarımın önemini ve web sitemizdeki tasarım bölümünü nasıl oluşturduğumuzu anlatacağız.</p>

                            <h2 class="mt-4 text-center">Fuarcılıkta Tasarımın Önemi</h2>
                            <ul>
                                <li style="list-style-type: disc;">Fuarcılık sektöründe, görsel etkileşimler ve yaratıcı tasarımlar, bir fuar stantının veya etkinliğin başarısını belirleyebilir.</li>
                                <li style="list-style-type: disc;">İyi bir tasarım, markanızın öne çıkmasını, hedef kitlenizin dikkatini çekmesini ve unutulmaz bir deneyim sunmasını sağlar.</li>
                                <li style="list-style-type: disc;">Tasarım, fuar alanındaki rekabet ortamında sıyrılmanızı ve rakiplerinizden ayrışmanızı sağlayabilir.</li>
                            </ul>
                        </div>
                    </article>
                </div>
                <div class="col-lg-8" id="shoppingCentre">
                    <article class="post">
                        <div class="hero-slider">
                            <div class="slider-item th-fullpage hero-area" style="background-image: url(images/service/shopping-1.jpg); height: 400px !important">
                            </div>
                            <div class="slider-item th-fullpage hero-area" style="background-image: url(images/service/shopping-2.jpg); height: 400px !important">
                            </div>
                            <div class="slider-item th-fullpage hero-area" style="background-image: url(images/service/shopping-3.jpg); height: 400px !important">
                            </div>
                        </div>

                        <!-- Post Content -->
                        <div class="post-content">
                            <h1 class="mt-4 text-center">Fuarcılıkta Mağaza Tasarımlarının Önemi</h1>
                            <p>Fuarcılık sektöründe müşterilerinizin ilgisini çekmek, markanızı sergilemek ve etkileyici bir deneyim sunmak için mağaza tasarımları büyük bir öneme sahiptir. Web sitemizde yer alan 'Mağaza Tasarımları' bölümü, mağaza ve perakende sektöründe tasarım hizmetlerimizi tanıtmak ve potansiyel müşterilere yaratıcı çözümlerimizi göstermek amacıyla oluşturulmuştur. Bu yazıda, fuarcılıkta mağaza tasarımlarının önemini ve web sitemizdeki 'Mağaza Tasarımları' bölümünü nasıl oluşturduğumuzu anlatacağız.</p>

                            <h2 class="mt-4 text-center">Fuarcılıkta Mağaza Tasarımlarının Önemi</h2>
                            <ul>
                                <li style="list-style-type: disc;">Fuarcılık sektöründe, mağaza tasarımları müşterilerin dikkatini çekmek, satışları artırmak ve markanızın benzersiz bir şekilde sergilenmesini sağlamak için kritik öneme sahiptir.</li>
                                <li style="list-style-type: disc;">İyi bir mağaza tasarımı, müşterilerin alışveriş deneyimini iyileştirir, markaya bağlılık oluşturur ve rekabetçi bir avantaj sağlar.</li>
                                <li style="list-style-type: disc;">Estetik, fonksiyonellik ve marka kimliğini yansıtan bir tasarım, müşterilerin mağazanızda daha uzun süre kalmasını ve tekrar ziyaret etmesini sağlar.</li>
                            </ul>
                        </div>
                    </article>
                </div>
                <div class="col-lg-8" id="product">
                    <article class="post">
                        <div class="hero-slider">
                            <div class="slider-item th-fullpage hero-area" style="background-image: url(images/service/shopping-1.jpg); height: 400px !important">
                            </div>
                            <div class="slider-item th-fullpage hero-area" style="background-image: url(images/service/shopping-2.jpg); height: 400px !important">
                            </div>
                            <div class="slider-item th-fullpage hero-area" style="background-image: url(images/service/shopping-3.jpg); height: 400px !important">
                            </div>
                        </div>

                        <!-- Post Content -->
                        <div class="post-content">
                            <h1 class="mt-4 text-center">Fuarcılıkta Üretim ve Planlamanın Önemi</h1>
                            <p>Fuarcılık sektöründe başarılı bir etkinlik veya stant sunmak için etkili bir üretim ve planlama süreci gereklidir. Web sitemizde yer alan 'Üretim ve Planlama' bölümü, fuar organizasyonu ve stant üretimi konusundaki hizmetlerimizi tanıtmak ve potansiyel müşterilere nasıl yaptığımızı göstermek amacıyla oluşturulmuştur. Bu yazıda, fuarcılıkta üretim ve planlamanın önemini ve web sitemizdeki 'Üretim ve Planlama' bölümünü nasıl oluşturduğumuzu anlatacağız.</p>

                            <h2 class="mt-4 text-center">Fuarcılıkta Üretim ve Planlamanın Önemi</h2>
                            <ul>
                                <li style="list-style-type: disc;">Başarılı bir fuar veya etkinlik için kaliteli üretim ve planlama süreci hayati önem taşır. Bu süreç, stant tasarımı, malzeme seçimi, üretim aşamaları, lojistik planlama ve montaj gibi unsurları içerir.</li>
                                <li style="list-style-type: disc;">Etkili bir üretim ve planlama süreci, stantınızın zamanında ve eksiksiz bir şekilde hazırlanmasını sağlar. Bu da etkinlik başlamadan önce herhangi bir aksaklık yaşamadan profesyonel bir sunum yapmanızı sağlar.</li>
                                <li style="list-style-type: disc;">İyi bir üretim ve planlama süreci, bütçenizi etkin bir şekilde yönetmenize yardımcı olur. Malzeme seçimi, üretim yöntemleri ve lojistik planlama gibi faktörler, maliyetleri optimize etmenize ve kaynakları verimli bir şekilde kullanmanıza olanak tanır.</li>
                            </ul>
                        </div>
                    </article>
                </div>
                <div class="col-lg-8" id="congress">
                    <article class="post">
                        <div class="hero-slider">
                            <div class="slider-item th-fullpage hero-area" style="background-image: url(images/service/congress-1.jpg); height: 400px !important">
                            </div>
                            <div class="slider-item th-fullpage hero-area" style="background-image: url(images/service/congress-2.jpg); height: 400px !important">
                            </div>
                            <div class="slider-item th-fullpage hero-area" style="background-image: url(images/service/congress-3.jpg); height: 400px !important">
                            </div>
                        </div>

                        <!-- Post Content -->
                        <div class="post-content">
                            <h1 class="mt-4 text-center">Kongre & Konferans Tasarımlarında Uzmanlığımız</h1>
                            <p>Fuarcılık sektöründe kongre ve konferanslar, önemli iş etkinlikleri olarak kabul edilir ve etkili bir tasarım gerektirir. Web sitemizde yer alan 'Kongre & Konferans Tasarımları' bölümü, bu tür etkinlikler için profesyonel tasarım hizmetlerimizi sergilemek ve müşterilerimize benzersiz deneyimler sunmak amacıyla oluşturulmuştur. Bu yazıda, kongre ve konferans tasarımlarının önemini ve web sitemizdeki 'Kongre & Konferans Tasarımları' bölümünü nasıl oluşturduğumuzu anlatacağız.</p>

                            <h2 class="mt-4 text-center">Kongre & Konferans Tasarımlarının Önemi</h2>
                            <ul>
                                <li style="list-style-type: disc;">Kongre ve konferanslarda etkili bir tasarım, katılımcıların dikkatini çekmek ve unutulmaz bir deneyim yaşamalarını sağlamak için kritik öneme sahiptir.</li>
                                <li style="list-style-type: disc;">Profesyonel bir tasarım, konferansınızı ve markanızı güçlü bir şekilde temsil eder ve katılımcıların etkinliğe olan ilgisini artırır.</li>
                                <li style="list-style-type: disc;">İyi planlanmış ve özelleştirilmiş bir tasarım, kongre veya konferansınızı diğerlerinden ayırmanıza yardımcı olur ve hedef kitleniz üzerinde kalıcı bir etki bırakır.</li>
                            </ul>

                            <h2 class="mt-4 text-center">Sahne ve Dekor Tasarımı</h2>
                            <p>Firmamız, etkileyici sahne ve dekor tasarımlarıyla kongre ve konferanslarınıza özel bir atmosfer katmaktadır. Profesyonel ekibimiz, etkinliğinizin temasına uygun olarak özgün ve dikkat çekici tasarımlar sunmaktadır.</p>

                            <h2 class="mt-4 text-center">Standart Stant Kurulum Hizmeti</h2>
                            <p>Standart stant kurulum hizmetimizle, katılımcılarınıza şık ve işlevsel stantlar sunuyoruz. Markanızın güçlü bir şekilde temsil edilmesini sağlayarak, etkinliğinizin unutulmaz olmasına katkıda bulunuyoruz.</p>

                            <h2 class="mt-4 text-center">Ses Işık ve Sahne Kurulum Hizmeti</h2>
                            <p>Ses, ışık ve sahne kurulum hizmetimizle etkinliğinizin görsel ve işitsel açıdan etkileyici olmasını sağlıyoruz. Profesyonel ekipmanlarımız ve deneyimli teknik ekibimizle etkinliğinizi en üst düzeye çıkarıyoruz.</p>

                            <h2 class="mt-4 text-center">Kongre Teknik Malzemesi Kiralama</h2>
                            <p>Kongre teknik malzemesi kiralama hizmetimizle, etkinliğiniz için gerekli olan teknik ekipmanları uygun fiyatlarla temin edebilirsiniz. Yüksek kaliteli malzemelerimizle etkinliğinizin sorunsuz bir şekilde gerçekleşmesine yardımcı oluyoruz.</p>
                        </div>
                    </article>
                </div>
                <div class="col-lg-8" id="advert">
                    <article class="post">
                        <div class="hero-slider">
                            <div class="slider-item th-fullpage hero-area" style="background-image: url(images/service/advert-1.jpg); height: 400px !important">
                            </div>
                            <div class="slider-item th-fullpage hero-area" style="background-image: url(images/service/advert-2.jpg); height: 400px !important">
                            </div>
                            <div class="slider-item th-fullpage hero-area" style="background-image: url(images/service/advert-3.jpg); height: 400px !important">
                            </div>
                        </div>

                        <!-- Post Content -->
                        <div class="post-content">
                            <h1 class="mt-4 text-center">Reklam Tanıtım Hizmetleri</h1>

                            <h2>Reklam ve Tanıtımın Önemi</h2>
                            <p>
                                Etkili bir reklam ve tanıtım stratejisi, etkinliğinizin veya fuarınızın hedef kitlesine ulaşmasını sağlar ve katılımcı sayısını artırır. Profesyonel bir reklam ve tanıtım, markanızı ve etkinliğinizi ön plana çıkarır, sektördeki diğer katılımcılardan sıyrılmanızı sağlar. Doğru reklam ve tanıtım yöntemleri, hedef kitlenizin ilgisini çeker ve etkinliğe katılım oranını artırır.
                            </p>

                            <h2>Bilboard-Totem İmalatı</h2>
                            <p>
                                Bilboard ve totemler, etkileyici ve dikkat çekici reklam alanlarıdır. Fuarcılık sektöründe başarılı bir etkinlik düzenlemek için özelleştirilmiş bilboard ve totem imalatı önemli bir reklam ve tanıtım stratejisidir. Firmamız, deneyimli tasarım ekibi ve yüksek kaliteli malzemeler kullanarak, etkileyici ve dayanıklı bilboard ve totemler üretmektedir. Müşterilerimize, etkinliklerini tanıtmak ve hedef kitlelerine ulaşmak için benzersiz ve özelleştirilmiş reklam çözümleri sunmaktayız.
                            </p>

                            <h2>Dijital Baskı ve Reklam Uygulamaları</h2>
                            <p>
                                Dijital baskı ve reklam uygulamaları, etkinliğinizin görünürlüğünü artırmak ve markanızı tanıtmak için etkili bir yöntemdir. Firmamız, son teknoloji dijital baskı ekipmanlarıyla yaratıcı ve etkileyici reklam malzemeleri üretmektedir. Bannerlar, afişler, broşürler, kataloglar ve diğer tanıtım materyalleri gibi çeşitli ürünlerle müşterilerimize hizmet vermekteyiz. Ayrıca, bu materyallerin etkinlik mekanında profesyonelce uygulanması ve yerleştirilmesi konusunda da destek sunmaktayız.
                            </p>

                            <h2>Vinil Karkas Uygulama Hizmetleri</h2>
                            <p>
                                Vinil karkas uygulamaları, fuar alanlarında etkin bir şekilde kullanılan büyük ölçekli reklam çözümleridir. Firmamız, müşterilerimize vinil karkas uygulama hizmetleri sunarak etkinliklerinin görsel etkisini artırmalarına yardımcı olmaktadır. Deneyimli ekip ve yüksek kaliteli malzemelerle, özelleştirilmiş vinil karkaslar üretmekteyiz. Bu uygulamalar, fuar alanlarında büyük bir dikkat çekme potansiyeline sahiptir ve etkinliğinizin hedef kitlesi arasında güçlü bir etki yaratmanızı sağlar.
                            </p>
                        </div>
                    </article>
                </div>
            </div>
        </div>
    </section>
    <!-- blog details part end -->
    <script>
        // Sidebar'ı her zaman görünür hale getir
        var sidebar = document.querySelector('.sidebar');
        if (sidebar) {
            sidebar.style.display = 'block';
        }

        // Özel Tasarım Fuar Stantları bölümünü gizle
        document.getElementById('design').style.display = 'block';

        // Maxima Fuar Stantları bölümünü gizle
        document.getElementById('shoppingCentre').style.display = 'none';

        // Moduler Fuar Stantları bölümünü gizle
        document.getElementById('product').style.display = 'none';

        // Moduler Fuar Stantları bölümünü gizle
        document.getElementById('congress').style.display = 'none';

        // Moduler Fuar Stantları bölümünü gizle
        document.getElementById('advert').style.display = 'none';

        // Linke tıklandığında ilgili bölümü göster
        document.querySelector('a[href="#design"]').addEventListener('click', function () {
            document.getElementById('design').style.display = 'block';
            document.getElementById('shoppingCentre').style.display = 'none';
            document.getElementById('product').style.display = 'none';
            document.getElementById('congress').style.display = 'none';
            document.getElementById('advert').style.display = 'none';
        });

        document.querySelector('a[href="#shoppingCentre"]').addEventListener('click', function () {
            document.getElementById('design').style.display = 'none';
            document.getElementById('shoppingCentre').style.display = 'block';
            document.getElementById('product').style.display = 'none';
            document.getElementById('congress').style.display = 'none';
            document.getElementById('advert').style.display = 'none';
        });

        document.querySelector('a[href="#product"]').addEventListener('click', function () {
            document.getElementById('design').style.display = 'none';
            document.getElementById('shoppingCentre').style.display = 'none';
            document.getElementById('product').style.display = 'block';
            document.getElementById('congress').style.display = 'none';
            document.getElementById('advert').style.display = 'none';
        });


        document.querySelector('a[href="#congress"]').addEventListener('click', function () {
            document.getElementById('design').style.display = 'none';
            document.getElementById('shoppingCentre').style.display = 'none';
            document.getElementById('product').style.display = 'none';
            document.getElementById('congress').style.display = 'block';
            document.getElementById('advert').style.display = 'none';
        });


        document.querySelector('a[href="#advert"]').addEventListener('click', function () {
            document.getElementById('design').style.display = 'none';
            document.getElementById('shoppingCentre').style.display = 'none';
            document.getElementById('product').style.display = 'none';
            document.getElementById('congress').style.display = 'none';
            document.getElementById('advert').style.display = 'block';
        });
        function openPdf() {
            // PDF dosyasının yolu, gerektiğinde güncellenmeli
            var pdfPath = 'data/katalog.pdf';

            // PDF dosyasını yeni pencerede aç
            window.open(pdfPath, '_blank');
        }
    </script>
</asp:Content>
