<%@ Page Title="" Language="C#" MasterPageFile="~/TopManagementPanel/index.Master" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="TanasFuarcilik.TopManagementPanel.profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapper">

        <div class="main">
            <main class="content">
                <div class="container-fluid p-0">

                    <div class="row">
                        <div class="col-md-12 col-xl-12">
                            <div class="card mb-3">
                                <div class="card-header">
                                </div>
                                <div class="card-body text-center">
                                    <asp:Image ID="imgAvatar" runat="server" CssClass="avatar img-fluid rounded me-1" />
                                    <h5 class="card-title mb-0">
                                        <br />
                                        <asp:Label ID="lbl_name" runat="server" class="text-dark"></asp:Label></h5>
                                    <asp:Label ID="lbl_mission" runat="server" class="text-muted mb-2"></asp:Label>
                                    
                                    <div>
                                        <br />
                                        <a class="btn btn-primary btn-sm" href="#">Düzenle</a>
                                    </div>
                                </div>
                                <hr class="my-0" />
                            </div>
                        </div>

                    </div>

                </div>
            </main>
        </div>
    </div>

    <script src="../TopManagementPanel/js/app.js"></script>

</asp:Content>
