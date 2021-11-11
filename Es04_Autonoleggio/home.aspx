<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="Es04_Autonoleggio.home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ctpHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ctpBody" runat="server">
    <!-- Carousel -->
    <div id="demo" class="carousel slide" data-bs-ride="carousel">

        <!-- Indicators/dots -->
        <div class="carousel-indicators">
            <button type="button" data-bs-target="#demo" data-bs-slide-to="0" class="active"></button>
            <button type="button" data-bs-target="#demo" data-bs-slide-to="1"></button>
            <button type="button" data-bs-target="#demo" data-bs-slide-to="2"></button>
        </div>

        <!-- The slideshow/carousel -->
        <div class="carousel-inner">
            <div class="carousel-item active">
                <img src="img/fiat500.jpg" alt="Fiat 500" class="d-block" style="width: 100%">
            </div>
            <div class="carousel-item">
                <img src="img/maggiolone.jpg" alt="Maggiolone" class="d-block" style="width: 100%">
            </div>
            <div class="carousel-item">
                <img src="img/suzukySwift.jpg" alt="Suzuky Swift" class="d-block" style="width: 100%">
            </div>
        </div>

        <!-- Left and right controls/icons -->
        <button class="carousel-control-prev" type="button" data-bs-target="#demo" data-bs-slide="prev">
            <span class="carousel-control-prev-icon"></span>
        </button>
        <button class="carousel-control-next" type="button" data-bs-target="#demo" data-bs-slide="next">
            <span class="carousel-control-next-icon"></span>
        </button>
    </div>
</asp:Content>
