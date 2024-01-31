<%@ Page Title="" Language="C#" MasterPageFile="~/TopManagementPanel/index.Master" AutoEventWireup="true" CodeBehind="personnel.aspx.cs" Inherits="TanasFuarcilik.TopManagementPanel.personnel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-12 col-lg-12 col-xxl-12 d-flex">
            <div class="card flex-fill">
                <div class="card-header">
                    <h5 class="card-title mb-0">Personeller</h5>
                </div>

                <asp:ListView ID="lv_personnelList" runat="server" OnItemCommand="lv_personnelList_ItemCommand">
                    <LayoutTemplate>
                        <table class="table table-hover my-0">
                            <thead>
                                <tr>
                                    <th>Adı</th>
                                    <th class="d-none d-xl-table-cell">Soyadı</th>
                                    <th class="d-none d-xl-table-cell">Telefon Numarası</th>
                                    <th>Durum</th>
                                    <th class="d-none d-md-table-cell">E Mail</th>
                                    <th class="d-none d-md-table-cell">Adres</th>
                                    <th class="d-none d-md-table-cell">Resim</th>
                                    <th class="d-none d-md-table-cell">Seçenekler</th>
                                </tr>
                            </thead>
                            <tbody>
                                <asp:PlaceHolder ID="ItemPlaceHolder" runat="server"></asp:PlaceHolder>
                            </tbody>
                        </table>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("Name") %></td>
                            <td><%# Eval("Surname") %></td>
                            <td><a href="tel:<%# Eval("PhoneNumber") %>"><%# Eval("PhoneNumber") %></a></td>
                            <td><%# Eval("StatuStr") %></td>
                            <td><a href="mailto:<%# Eval("EMail") %>"><%# Eval("EMail") %></a></td>
                            <td><%# Eval("Address") %></td>
                            <td>
                                <img src="img/personnel/<%# Eval("Image") %>" /></td>
                        </tr>
                    </ItemTemplate>
                </asp:ListView>
            </div>
        </div>
    </div>
</asp:Content>
