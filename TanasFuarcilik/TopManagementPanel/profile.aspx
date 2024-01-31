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
                                    <img src="img/avatars/avatar-4.jpg" alt="Christina Mason" class="img-fluid rounded-circle mb-2" width="128" height="128" />
                                    <h5 class="card-title mb-0">Christina Mason</h5>
                                    <div class="text-muted mb-2">Lead Developer</div>

                                    <div>
                                        <a class="btn btn-primary btn-sm" href="#">Follow</a>
                                        <a class="btn btn-primary btn-sm" href="#"><span data-feather="message-square"></span>Message</a>
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
