<%@ Page Title="" Language="C#" MasterPageFile="~/TopManagementPanel/index.Master" AutoEventWireup="true" CodeBehind="portfolioCreate.aspx.cs" Inherits="TanasFuarcilik.TopManagementPanel.portfolioCreate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="col-12 col-md-12">

            <div class="contact-form col-md-8">
                <div class="row">

                    <div class="form-group mb-4 col-md-6">
                        <asp:TextBox placeholder="İşin Adını Giriniz" runat="server" CssClass="form-control" Font-Names="name" ID="tb_name"></asp:TextBox>
                    </div>

                    <div class="form-group mb-4 col-md-6">
                        <asp:DropDownList ID="ddl_categories" runat="server" CssClass="form-control" Font-Names="category" AppendDataBoundItems="true">
                            <asp:ListItem Text="Kategori Seçiniz" Value="0"></asp:ListItem>
                        </asp:DropDownList>
                    </div>

                    <div class="form-group mb-4 col-md-6">
                        <span><mark>Resim 1</mark></span>
                        <asp:Image ID="img_picture" runat="server" Width="100px" CssClass="mb-3" />
                        <asp:FileUpload ID="fu_picture" runat="server"></asp:FileUpload>
                    </div>

                    <div class="form-group mb-4 col-md-6">
                        <span><mark>Resim 2</mark></span>
                        <asp:Image ID="img_picture2" runat="server" Width="100px" CssClass="mb-3" />
                        <asp:FileUpload ID="fu_picture2" runat="server"></asp:FileUpload>
                    </div>

                    <div class="form-group mb-4 col-md-6">
                        <span><mark>Resim 3</mark></span>
                        <asp:Image ID="img_picture3" runat="server" Width="100px" CssClass="mb-3" />
                        <asp:FileUpload ID="fu_picture3" runat="server"></asp:FileUpload>
                    </div>

                    <div class="form-group mb-4 col-md-6">
                        <span><mark>Resim 4</mark></span>
                        <asp:Image ID="img_picture4" runat="server" Width="100px" CssClass="mb-3" />
                        <asp:FileUpload ID="fu_picture4" runat="server"></asp:FileUpload>
                    </div>

                    <div class="form-group mb-4 col-md-6">
                        <span><mark>Resim 5</mark></span>
                        <asp:Image ID="img_picture5" runat="server" Width="100px" CssClass="mb-3" />
                        <asp:FileUpload ID="fu_picture5" runat="server"></asp:FileUpload>
                    </div>

                    <div class="form-group mb-4 col-md-12">
                        <asp:Panel ID="pnl_successful" runat="server" CssClass="basarili" Visible="false">
                            Transaction Successful
                        </asp:Panel>
                        <asp:Panel ID="pnl_unsuccessful" runat="server" CssClass="basarisiz" Visible="false">
                            <asp:Label ID="lbl_message" runat="server"></asp:Label>
                        </asp:Panel>
                        <asp:LinkButton ID="lbtn_create" class="btn btn-dark" Width="100%" Text="Portfolyo EKLE" value="Submit" runat="server" OnClick="lbtn_create_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
