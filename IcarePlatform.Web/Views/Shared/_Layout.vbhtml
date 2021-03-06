﻿<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>İcarə</title>
    <link rel="stylesheet" href="~/PublicFront/Vendors/Css/style.css">
    <link rel="stylesheet" href="~/PublicFront/Vendors/bootstrap/css/bootstrap.css">
    <link rel="stylesheet" href="~/PublicFront/Vendors/font-awesome/css/all.css">
</head>

<body>
    <!-- ============
    NabBar
    ============ -->
    <nav id="NavBar">
        <div class="container">
            <div class="row">
                <div class="col-md-8">
                    <div class="MenuList">
                        <ul>
                            <li><a href="https://localhost:44398/Home/Index">Əsas səhifə</a></li>
                            <li><a href="#">Xidmətlər</a></li>
                            <li><a href="https://localhost:44398/Home/About">Haqqımızda</a></li>
                            <li><a href="#">FAQ</a></li>
                            <li><a href="#">Əlaqə</a></li>
                        </ul>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="MenuEnter">
                        <ul>
                            <li><a href="https://localhost:44398/Account/Login">Giriş</a></li>
                            <li><a href="https://localhost:44398/Account/Register">Qeydiyyat</a></li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </nav>

    @RenderBody()

    <!-- ============
    Footer Start
    ============ -->
    <div class="FooterSec">
        <!-- =============      AppİnfoSection start   ============= -->
        <section class="AppStore">
            <div class=" container">
                <div class="row">
                    <div class="AppStoreInfo">
                        <h6>
                            "İlk online icarə ödəmə portalı mobil tətbiqini təqdim edirik. Mobil tətbiqdən istifadə
                            edərək<br>
                            vaxtınıza qənaət edib,
                            kira ödənişlərinizi güvənlə həll edin.”
                        </h6>
                        <a href="#"><img style="width:10%" src="~/PublicFront/Vendors/image/app-store.png" alt="Apple-store"></a>
                        <a href="#"><img style="width:10%" src="~/PublicFront/Vendors/image/google.png" alt="Google-store"></a>
                    </div>
                </div>
            </div>
            <img class="PhoneImg" src="~/PublicFront/Vendors/image/phone.png" alt="">
        </section>


        <div id="layoutAuthentication_footer">
            <footer class="py-5 bg-light">
                <div class="container-fluid">
                    <div class="d-flex align-items-center justify-content-between small">

                        @RenderSection("Logo", required:    false)

                        <div class="text-muted">Müəllif hüquqları &copy; İcarə MMC-yə məxsusdur</div>
                        <div>
                            <a href="#">Məxfilik Siyasəti </a>
                            &middot;
                            <a href="#">Qaydalar &amp; Şərtlər</a>
                        </div>
                    </div>
                </div>
            </footer>
        </div>
    </div>

    <!-- ============
    Footer End
    ============ -->

    <script src="~/PublicFront/Vendors/Js/app.js"></script>
    <script src="~/PublicFront/Vendors/bootstrap/js/bootstrap.js"></script>
</body>

</html>