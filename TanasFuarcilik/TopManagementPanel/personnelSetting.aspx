<%@ Page Title="" Language="C#" MasterPageFile="~/TopManagementPanel/index.Master" AutoEventWireup="true" CodeBehind="personnelSetting.aspx.cs" Inherits="TanasFuarcilik.TopManagementPanel.personnelSetting" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container contact-form col-md-4 mb-5">
        <asp:Image ID="img_picture" runat="server" Width="100px" CssClass="mb-3" />
        <asp:FileUpload ID="fu_picture" runat="server"></asp:FileUpload>
    </div>
    <div class="contact-form col-md-8 ">
        <div class="form-group mb-4">
            <asp:TextBox placeholder="Adınızı Giriniz" runat="server" CssClass="form-control" Font-Names="name" ID="tb_name"></asp:TextBox>
        </div>

        <div class="form-group mb-4">
            <asp:TextBox placeholder="Soyadınızı Giriniz" runat="server" CssClass="form-control" Font-Names="surname" ID="tb_surname"></asp:TextBox>
        </div>

        <div class="form-group mb-4">
            <asp:TextBox placeholder="Şifrenizi Giriniz" TextMode="Password" runat="server" CssClass="form-control" Font-Names="password" ID="tb_password"></asp:TextBox>
        </div>

        <div class="form-group mb-4">
            <asp:TextBox placeholder="Bölümünüzü Giriniz" runat="server" CssClass="form-control" Font-Names="mission" ID="tb_mission"></asp:TextBox>
        </div>
        <div class="form-group mb-4">
            <asp:TextBox placeholder="Telefon Numaranızı Giriniz" runat="server" CssClass="form-control" Font-Names="phone" ID="tb_phone"></asp:TextBox>
        </div>
        <div class="form-group mb-4">
            <asp:TextBox placeholder="E-Mail Adresinizi Giriniz" runat="server" TextMode="Email" CssClass="form-control" Font-Names="mail" ID="tb_mail"></asp:TextBox>
        </div>
        <div class="form-group mb-4">
            <textarea id="tb_address" class="form-control" runat="server" rows="3"></textarea>
          
        </div>

        <div id="cf-submit">
            <asp:LinkButton ID="lbtn_post" class="btn btn-dark" Width="100%" Text="Güncelle" value="Submit" runat="server" OnClick="lbtn_post_Click" />
        </div>

    </div>

</asp:Content>
