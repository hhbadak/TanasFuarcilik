<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="portfolio.aspx.cs" Inherits="TanasFuarcilik.portfolio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section class="single-page-header">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <h2>Yaptığımız İşler</h2>
                    <ol class="breadcrumb header-bradcrumb justify-content-center">
                        <li class="breadcrumb-item"><a href="index.aspx" class="text-white">Anasayfa</a></li>
                        <li class="breadcrumb-item active" aria-current="page">Referanslarımız</li>
                    </ol>
                </div>
            </div>
        </div>
    </section>

    <!-- Start Portfolio Section
		=========================================== -->

    <section class="portfolio section-sm" id="portfolio">
        <div class="container-fluid">
            <div class="row justify-content-center">
                <div class="col-xl-6 col-lg-8">
                    <!-- section title -->
                    <div class="title text-center">
                        <h2>Çalışmalarımız</h2>
                        <p>
                            Çalışmalarımız, fuarcılık sektöründeki deneyimimiz ve uzmanlığımızla, müşterilerimize etkileyici etkinlikler ve başarılı fuarlar sunma misyonuyla gerçekleştirilmektedir. Yaratıcı tasarımlarımız ve özelleştirilmiş çözümlerimizle, unutulmaz ve etkileyici deneyimler sağlamak için çalışıyoruz.
                        </p>
                        <div class="border"></div>
                    </div>
                    <!-- /section title -->
                </div>
            </div>

            <div class="row">
                <div class="col-lg-12">

                    <div class="portfolio-filter">
                        <button type="button" data-filter="all">Hepsi</button>
                        <button type="button" data-filter="special">Özel Tasarım Fuar Stantları</button>
                        <button type="button" data-filter="maxima">Maksima Fuar Stantları</button>
                        <button type="button" data-filter="moduler">Moduler Fuar Stantları</button>
                    </div>

                    <div class="row">
                        <div class="col-12">
                            <div class="filtr-container">
                                <div class="col-md-3 col-sm-6 col-xs-6 filtr-item " data-category="mix, design">
                                    <div class="portfolio-block">
                                        <img class="img-fluid" src="images/portfolio/portfolio-1.jpg" alt="">
                                        <div class="caption">
                                            <a class="search-icon" href="images/portfolio/portfolio-1.jpg" data-lightbox="image-1">
                                                <i class="tf-ion-ios-search-strong"></i>
                                            </a>
                                            <h4><a href="portfolio.html">AirBnB Postcard</a></h4>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-3 col-sm-6 col-xs-6 filtr-item " data-category="mix, design, ios">
                                    <div class="portfolio-block">
                                        <img class="img-fluid" src="images/portfolio/portfolio-2.jpg" alt="">
                                        <div class="caption">
                                            <a class="search-icon" href="images/portfolio/portfolio-2.jpg" data-lightbox="image-1">
                                                <i class="tf-ion-ios-search-strong"></i>
                                            </a>
                                            <h4><a href="portfolio.html">AirBnB Postcard</a></h4>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-3 col-sm-6 col-xs-6 filtr-item " data-category="mix, photography, development">
                                    <div class="portfolio-block">
                                        <img class="img-fluid" src="images/portfolio/portfolio-3.jpg" alt="">
                                        <div class="caption">
                                            <a class="search-icon" href="images/portfolio/portfolio-3.jpg" data-lightbox="image-1">
                                                <i class="tf-ion-ios-search-strong"></i>
                                            </a>
                                            <h4><a href="portfolio.html">AirBnB Postcard</a></h4>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-3 col-sm-6 col-xs-6 filtr-item " data-category="mix, photography, ios">
                                    <div class="portfolio-block">
                                        <img class="img-fluid" src="images/portfolio/portfolio-4.jpg" alt="">
                                        <div class="caption">
                                            <a class="search-icon" href="images/portfolio/portfolio-4.jpg" data-lightbox="image-1">
                                                <i class="tf-ion-ios-search-strong"></i>
                                            </a>
                                            <h4><a href="portfolio.html">AirBnB Postcard</a></h4>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-3 col-sm-6 col-xs-6 filtr-item " data-category="mix, design">
                                    <div class="portfolio-block">
                                        <img class="img-fluid" src="images/portfolio/portfolio-5.jpg" alt="">
                                        <div class="caption">
                                            <a class="search-icon" href="images/portfolio/portfolio-5.jpg" data-lightbox="image-1">
                                                <i class="tf-ion-ios-search-strong"></i>
                                            </a>
                                            <h4><a href="portfolio.html">AirBnB Postcard</a></h4>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-3 col-sm-6 col-xs-6 filtr-item " data-category="mix, design, development">
                                    <div class="portfolio-block">
                                        <img class="img-fluid" src="images/portfolio/portfolio-6.jpg" alt="">
                                        <div class="caption">
                                            <a class="search-icon" href="images/portfolio/portfolio-6.jpg" data-lightbox="image-1">
                                                <i class="tf-ion-ios-search-strong"></i>
                                            </a>
                                            <h4><a href="portfolio.html">AirBnB Postcard</a></h4>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-3 col-sm-6 col-xs-6 filtr-item " data-category="mix, photography">
                                    <div class="portfolio-block">
                                        <img class="img-fluid" src="images/portfolio/portfolio-7.jpg" alt="">
                                        <div class="caption">
                                            <a class="search-icon" href="images/portfolio/portfolio-7.jpg" data-lightbox="image-1">
                                                <i class="tf-ion-ios-search-strong"></i>
                                            </a>
                                            <h4><a href="portfolio.html">AirBnB Postcard</a></h4>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-3 col-sm-6 col-xs-6 filtr-item " data-category="mix, design, development">
                                    <div class="portfolio-block">
                                        <img class="img-fluid" src="images/portfolio/portfolio-1.jpg" alt="">
                                        <div class="caption">
                                            <a class="search-icon" href="images/portfolio/portfolio-1.jpg" data-lightbox="image-1">
                                                <i class="tf-ion-ios-search-strong"></i>
                                            </a>
                                            <h4><a href="portfolio.html">AirBnB Postcard</a></h4>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- /end col-lg-12 -->
            </div>
            <!-- end row -->
        </div>
        <!-- end container -->
    </section>
    <!-- End section -->

</asp:Content>
