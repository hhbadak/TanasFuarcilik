<%@ Page Title="" Language="C#" MasterPageFile="~/TopManagementPanel/index.Master" AutoEventWireup="true" CodeBehind="portfolio.aspx.cs" Inherits="TanasFuarcilik.TopManagementPanel.portfolio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-12 col-md-12">
        <a href="../TopManagementPanel/portfolioCreate.aspx" class="btn btn-primary" style="width: 100%; margin-bottom: 3%;">Portfolyö Ekle</a>
    </div>

    <div class="col-lg-12">
        <section class="portfolio section-sm" id="portfolio">
            <div class="container-fluid">
                <div class="portfolio-filter">
                    <button type="button" data-filter="all">Hepsi</button>
                    <button type="button" data-filter="special">Özel Tasarım Fuar Stantları</button>
                    <button type="button" data-filter="maxima">Maksima Fuar Stantları</button>
                    <button type="button" data-filter="moduler">Moduler Fuar Stantları</button>
                </div>
                <div class="row">
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <div class="col-md-3 col-sm-6 col-xs-6 filtr-item " data-category="<%# Eval("Data") %>">
                                <div class="card">
                                    <div class="portfolio-block">
                                        <img class="card-img-top" src='<%# "img/portfolio/" + Eval("IMG1") %>' alt='<%# Eval("Name") %>'>
                                        <div class="card-header">
                                            <h5 class="card-title"><%# Eval("Name") %></h5>
                                        </div>
                                        <div class="card-body">
                                            <p class="card-text">Kategori: <%# Eval("Category") %></p>
                                            <a href="../TopManagementPanel/portfolioSetting.aspx?mid=<%# Eval("ID") %>" alt="Güncelle" class="btn btn-primary w-100">Güncelle</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </section>
    </div>
    <script>
        document.addEventListener("DOMContentLoaded", function () {
            var buttons = document.querySelectorAll(".portfolio-filter button");
            var cards = document.querySelectorAll(".filtr-item");

            buttons.forEach(function (button) {
                button.addEventListener("click", function () {
                    var filter = button.getAttribute("data-filter");

                    cards.forEach(function (card) {
                        var categories = card.getAttribute("data-category").split(", ");

                        if (filter === "all" || categories.includes(filter)) {
                            card.style.display = "block";
                        } else {
                            card.style.display = "none";
                        }
                    });
                });
            });
        });


        /* ========================================================================= */
        /*	Portfolio Filtering Hook
        /* =========================================================================  */
        // filter
        setTimeout(function () {
            var containerEl = document.querySelector('.filtr-container');
            var filterizd;
            if (containerEl) {
                filterizd = $('.filtr-container').filterizr({});
            }
        }, 500);
  </script>
</asp:Content>
