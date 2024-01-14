<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="TanasFuarcilik.contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="single-page-header">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <h2>Contact Us</h2>
                    <ol class="breadcrumb header-bradcrumb justify-content-center">
                        <li class="breadcrumb-item"><a href="index.html" class="text-white">Home</a></li>
                        <li class="breadcrumb-item active" aria-current="page">Contact Us</li>
                    </ol>
                </div>
            </div>
        </div>
    </section>

    <!--Start Contact Us
	=========================================== -->
    <section class="contact-us" id="contact">
        <div class="container">
            <div class="row justify-content-center">
                <!-- section title -->
                <div class="col-xl-6 col-lg-8">
                    <div class="title text-center">
                        <h2>Get In Touch</h2>
                        <p>
                            Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptate facilis eveniet maiores ab maxime nam
						ut numquam molestiae quaerat incidunt?
                        </p>
                        <div class="border"></div>
                    </div>
                </div>
                <!-- /section title -->
            </div>
            <div class="row">
                <!-- Contact Details -->
                <div class="contact-details col-md-6 ">
                    <h3 class="mb-3">Bize Ulaşın!</h3>
                    <p>
                        Merhaba! Size daha iyi hizmet verebilmek ve sorularınıza yanıt verebilmek için iletişime geçmek istiyoruz. Bize ulaşmanın birkaç farklı yolu bulunmaktadır. Telefon, e-posta veya iletişim formu aracılığıyla bizimle iletişime geçebilirsiniz.
                    </p>
                    <ul class="contact-short-info mt-4">
                        <li class="mb-3">
                            <i class="tf-ion-ios-home"></i>
                            <span>E-5 yanyol cad. no:61 / 166 Pendik/İSTANBUL</span>
                        </li>
                        <li class="mb-3">
                            <i class="tf-ion-android-phone-portrait"></i>
                            <span><a href="tel:+902169993872" style="color: #212529;">+90 216 999 38 72</a></span>
                        </li>
                        <li>
                            <i class="tf-ion-android-mail"></i>
                            <span><a href="mailto:info@tanasfuar.com" style="color: #212529;">info@tanasfuar.com</a></span>
                        </li>
                    </ul>
                    <!-- Footer Social Links -->
                    <div class="social-icon">
                        <ul>
                            <li><a href="https://themefisher.com/"><i class="tf-ion-social-facebook"></i></a></li>
                            <li><a href="https://themefisher.com/"><i class="tf-ion-social-twitter"></i></a></li>
                            <li><a href="https://themefisher.com/"><i class="tf-ion-social-dribbble-outline"></i></a></li>
                            <li><a href="https://themefisher.com/"><i class="tf-ion-social-linkedin-outline"></i></a></li>
                        </ul>
                    </div>
                    <!--/. End Footer Social Links -->
                </div>
                <!-- / End Contact Details -->

                <!-- Contact Form -->
                <div class="contact-form col-md-6 ">
                    <form id="contact-form" runat="server" method="post" role="form">
                        <div class="form-group mb-4">
                            <input type="text" placeholder="Your Name" class="form-control" name="name" id="name" required>
                        </div>

                        <div class="form-group mb-4">
                            <input type="email" placeholder="Your Email" class="form-control" name="email" id="email" required>
                        </div>

                        <div class="form-group mb-4">
                            <input type="text" placeholder="Subject" class="form-control" name="subject" id="subject" required>
                        </div>

                        <div class="form-group mb-4">
                            <textarea rows="6" placeholder="Message" class="form-control" name="message" id="message" required></textarea>
                        </div>
                        <div id="cf-submit">
                            <input>
                            <asp:LinkButton type="submit" ID="contact-submit" class="btn btn-transparent" value="Submit" runat="server" OnClick="contact-submit_Click" />
                        </div>

                    </form>
                </div>
                <!-- ./End Contact Form -->

            </div>
            <!-- end row -->
        </div>
        <!-- end container -->
    </section>
    <!-- end section -->

    <!--================================
=            Google Map            =
=================================-->
    <div class="google-map">
        <div id="map_canvas" class="map_canvas" data-latitude="40.712776" data-longitude="-74.005974" data-marker="images/marker.png" data-marker-name="Bingo"></div>
    </div>
    <!--====  End of Google Map  ====-->

</asp:Content>
