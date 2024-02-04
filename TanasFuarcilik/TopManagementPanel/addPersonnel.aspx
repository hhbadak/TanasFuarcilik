<%@ Page Title="" Language="C#" MasterPageFile="~/TopManagementPanel/index.Master" AutoEventWireup="true" CodeBehind="addPersonnel.aspx.cs" Inherits="TanasFuarcilik.addPersonnel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="col-12 col-md-12">
            <div class="container contact-form col-md-4 mb-5">
                <asp:Image ID="img_picture" runat="server" Width="100px" CssClass="mb-3" />
                <asp:FileUpload ID="fu_picture" runat="server" />
            </div>
            <div class="contact-form col-md-8">
                <div class="row">
                    <div class="form-group mb-4 col-md-6">
                        <asp:TextBox placeholder="Ad Soyadınızı Giriniz" runat="server" CssClass="form-control" Font-Names="name" ID="tb_name"></asp:TextBox>
                    </div>

                    <div class="form-group mb-4 col-md-6">
                        <asp:TextBox placeholder="Kullanıcı Adı Giriniz" runat="server" CssClass="form-control" Font-Names="username" ID="tb_username"></asp:TextBox>
                    </div>

                    <div class="form-group mb-4 col-md-6">
                        <asp:TextBox placeholder="Şifrenizi Giriniz" TextMode="Password" runat="server" CssClass="form-control" Font-Names="password" ID="tb_password"></asp:TextBox>
                    </div>

                    <div class="form-group mb-4 col-md-6">
                        <asp:TextBox placeholder="Bölümünüzü Giriniz" runat="server" CssClass="form-control" Font-Names="mission" ID="tb_mission"></asp:TextBox>
                    </div>
                    <div class="form-group mb-4 col-md-6">
                        <asp:TextBox placeholder="Telefon Numaranızı Giriniz" runat="server" CssClass="form-control" Font-Names="phone" ID="tb_phone"></asp:TextBox>
                    </div>
                    <div class="form-group mb-4 col-md-6">
                        <asp:TextBox placeholder="E-Mail Adresinizi Giriniz" runat="server" TextMode="Email" CssClass="form-control" Font-Names="mail" ID="tb_mail"></asp:TextBox>
                    </div>
                    <div class="form-group mb-4 col-md-6">
                        <textarea class="form-control mb-4" rows="2" runat="server" placeholder="Adresinizi Giriniz" name="address" id="tb_address"></textarea>
                    </div>
                    <div class="form-group mb-4 col-md-6">
                        <asp:DropDownList ID="ddl_statu" runat="server" CssClass="form-control" Font-Names="statu" AppendDataBoundItems="true">
                            <asp:ListItem Text="Durum Seçiniz" Value="0"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="form-group mb-4 col-md-12">
                        <asp:Panel ID="pnl_successful" runat="server" CssClass="basarili" Visible="false">
                            Transaction Successful
                        </asp:Panel>
                        <asp:Panel ID="pnl_unsuccessful" runat="server" CssClass="basarisiz" Visible="false">
                            <asp:Label ID="lbl_message" runat="server"></asp:Label>
                        </asp:Panel>
                        <asp:LinkButton ID="lbtn_create" class="btn btn-dark" Width="100%" Text="Personel EKLE" value="Submit" runat="server" OnClick="lbtn_create_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
