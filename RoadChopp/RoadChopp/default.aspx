﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="RoadChopp._default" %>

<!DOCTYPE html>
<html class="no-js">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>RoadChopp</title>
    <!-- Facebook and Twitter integration -->
    <meta property="og:title" content="" />
    <meta property="og:image" content="" />
    <meta property="og:url" content="" />
    <meta property="og:site_name" content="" />
    <meta property="og:description" content="" />
    <meta name="twitter:title" content="" />
    <meta name="twitter:image" content="" />
    <meta name="twitter:url" content="" />
    <meta name="twitter:card" content="" />

    <!-- Place favicon.ico and apple-touch-icon.png in the root directory -->
    <link rel="shortcut icon" href="favicon.ico">

    <link href='https://fonts.googleapis.com/css?family=Playfair+Display:400,700,400italic,700italic|Merriweather:300,400italic,300italic,400,700italic' rel='stylesheet' type='text/css'>

    <!-- Animate.css -->
    <link rel="stylesheet" href="css/animate.css">
    <!-- Icomoon Icon Fonts-->
    <link rel="stylesheet" href="css/icomoon.css">
    <!-- Simple Line Icons -->
    <link rel="stylesheet" href="css/simple-line-icons.css">
    <!-- Datetimepicker -->
    <link rel="stylesheet" href="css/bootstrap-datetimepicker.min.css">
    <!-- Flexslider -->
    <link rel="stylesheet" href="css/flexslider.css">
    <!-- Bootstrap  -->
    <link rel="stylesheet" href="css/bootstrap.css">
    <link rel="stylesheet" href="css/style.css">
    <!-- Modernizr JS -->
    <script src="js/modernizr-2.6.2.min.js"></script>

</head>
<body>

    <div id="fh5co-container">
        <div id="fh5co-home" class="js-fullheight" data-section="home">
            <div class="flexslider">
                <div class="fh5co-overlay"></div>
                <div class="fh5co-text">
                    <div class="container">
                        <div class="row">
                            <img class="logo" src="images/LogoSite.png" />
                            <h2 class="to-animate">Slogan <span>da</span> <a href="#" target="_blank">empresa</a></h2>
                        </div>
                    </div>
                </div>
                <ul class="slides">
                    <li style="background-image: url(images/capa.jpg);" data-stellar-background-ratio="0.5"></li>
                    <li style="background-image: url(images/capa2.jpg);" data-stellar-background-ratio="0.5"></li>
                </ul>
            </div>
        </div>

        <div class="js-sticky">
            <div class="fh5co-main-nav">
                <div class="container-fluid">
                    <div class="fh5co-menu-1">
                        <a href="#" data-nav-section="home">Inicio</a>
                        <a href="#" data-nav-section="about">Sobre Nós</a>
                        <a href="#" data-nav-section="features">Cardápio</a>
                    </div>
                    <div class="fh5co-logo">
                        <a href="default.aspx">Road Chopp</a>
                    </div>
                    <div class="fh5co-menu-2">
                        <a href="#" data-nav-section="events">Eventos</a>
                        <a href="#" data-nav-section="partners">Parcerias</a>
                        <a href="#" data-nav-section="contact">Contato</a>
                    </div>
                </div>
            </div>
        </div>

        <div id="fh5co-about" data-section="about">
            <div class="fh5co-2col fh5co-bg to-animate-2" style="background-image: url(images/copo.jpg)"></div>
            <div class="fh5co-2col fh5co-text">
                <h2 class="heading to-animate">Sobre a Road Chopp</h2>
                <p class="to-animate"><span class="firstcharacter">F</span>ar far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts. Separated they live in Bookmarksgrove right at the coast of the Semantics, a large language ocean. Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts. A small river named Duden flows by their place and supplies it with the necessary regelialia. It is a paradisematic country, in which roasted parts of sentences fly into your mouth. Even the all-powerful Pointing has no control about the blind texts it is an almost unorthographic life.</p>
                <p class="text-center to-animate"><a href="#" class="btn btn-primary btn-outline">Get in touch</a></p>
            </div>
        </div>

        <div id="fh5co-featured" data-section="features">
            <div class="container">
                <div class="row text-center fh5co-heading row-padded">
                    <div class="col-md-8 col-md-offset-2">
                        <h2 class="heading to-animate">Cardápio</h2>
                        <p class="sub-heading to-animate">breve descrição da marca</p>
                    </div>
                </div>
                <div class="row">
                    <div class="fh5co-grid">
                        <div class="fh5co-v-half to-animate-2">
                            <div class="fh5co-v-col-2 fh5co-bg-img" style="background-image: url(images/cerveja.jpg)"></div>
                            <div class="fh5co-v-col-2 fh5co-text fh5co-special-1 arrow-left">
                                <h2>Tipo do Choop 1</h2>
                                <span class="pricing">$7.50</span>
                                <p>descrição sobre o tipo do chopp</p>
                            </div>
                        </div>
                        <div class="fh5co-v-half">
                            <div class="fh5co-h-row-2 to-animate-2">
                                <div class="fh5co-v-col-2 fh5co-bg-img" style="background-image: url(images/cerveja.jpg)"></div>
                                <div class="fh5co-v-col-2 fh5co-text arrow-left">
                                    <h2>Tipo do Choop 2</h2>
                                <span class="pricing">$7.50</span>
                                <p>descrição sobre o tipo do chopp</p>
                                </div>
                            </div>
                            <div class="fh5co-h-row-2 fh5co-reversed to-animate-2">
                                <div class="fh5co-v-col-2 fh5co-bg-img" style="background-image: url(images/cerveja.jpg)"></div>
                                <div class="fh5co-v-col-2 fh5co-text arrow-right">
                                     <h2>Tipo do Choop 3</h2>
                                <span class="pricing">$7.50</span>
                                <p>descrição sobre o tipo do chopp</p>
                                </div>
                            </div>
                        </div>

                        <div class="fh5co-v-half">
                            <div class="fh5co-h-row-2 fh5co-reversed to-animate-2">
                                <div class="fh5co-v-col-2 fh5co-bg-img" style="background-image: url(images/cerveja.jpg)"></div>
                                <div class="fh5co-v-col-2 fh5co-text arrow-right">
                                    <h2>Tipo do Choop 4</h2>
                                <span class="pricing">$7.50</span>
                                <p>descrição sobre o tipo do chopp</p>
                                </div>
                            </div>
                            <div class="fh5co-h-row-2 to-animate-2">
                                <div class="fh5co-v-col-2 fh5co-bg-img" style="background-image: url(images/cerveja.jpg)"></div>
                                <div class="fh5co-v-col-2 fh5co-text arrow-left">
                                   <h2>Tipo do Choop 5</h2>
                                <span class="pricing">$7.50</span>
                                <p>descrição sobre o tipo do chopp</p>
                                </div>
                            </div>
                        </div>
                        <div class="fh5co-v-half to-animate-2">
                            <div class="fh5co-v-col-2 fh5co-bg-img" style="background-image: url(images/cerveja.jpg)"></div>
                            <div class="fh5co-v-col-2 fh5co-text fh5co-special-1 arrow-left">
                                 <h2>Tipo do Choop 6</h2>
                                <span class="pricing">$7.50</span>
                                <p>descrição sobre o tipo do chopp</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div id="fh5co-events" data-section="events" style="background-image: url(images/wood_1.png);" data-stellar-background-ratio="0.5">
            <div class="fh5co-overlay"></div>
            <div class="container">
                <div class="row text-center fh5co-heading row-padded">
                    <div class="col-md-8 col-md-offset-2 to-animate">
                        <h2 class="heading">Próximos Eventos</h2>
                        <p class="sub-heading">Breve descrição sobre a agenda</p>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-4">
                        <div class="fh5co-event to-animate-2">
                            <h3>Kitchen Workshops</h3>
                            <span class="fh5co-event-meta">March 19th, 2016</span>
                            <p>Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.</p>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="fh5co-event to-animate-2">
                            <h3>Music Concerts</h3>
                            <span class="fh5co-event-meta">March 19th, 2016</span>
                            <p>Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.</p>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="fh5co-event to-animate-2">
                            <h3>Free to Eat Party</h3>
                            <span class="fh5co-event-meta">March 19th, 2016</span>
                            <p>Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div id="fh5co-sayings" data-section="partners">
            <div class="container">
                <div class="row text-center fh5co-heading row-padded">
                    <div class="col-md-8 col-md-offset-2">
                        <h2 class="heading to-animate">Parceiros</h2>
                        <p class="sub-heading to-animate">Breve descrição sobre as parcerias</p>
                    </div>
                </div>
                <img class="logoParceiros" src="images/logoparceiro1.jpg" />
            </div>
        </div>
        
         <div id="fh5co-contact" data-section="contact">
            <div class="container">
                <div class="row">
                    <div class="col-md-6 to-animate-2">
                        <h3>Contact Info</h3>
                        <ul class="fh5co-contact-info">
                            <li class="fh5co-contact-address ">
                                <i class="icon-home"></i>
                               Endereço caso haja um
                                <br>
                                cidade / estado
							</li>
                            <li><i class="icon-phone"></i>(19) 99999-9999</li>
                            <li><i class="icon-envelope"></i>email@roadchop.com.br</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div id="fh5co-footer">
        <div class="container">
            <div class="row row-padded">
                <div class="col-md-12 text-center">
                    <p class="to-animate">
                        &copy; 2016 Developed by Natal. All Rights Reserved.
                    </p>
                    <p class="text-center to-animate"><a href="#" class="js-gotop">Ir ao Topo</a></p>
                </div>
            </div>
            <div class="row">
                <div class="col-md-12 text-center">
                    <ul class="fh5co-social">
                        <li class="to-animate-2"><a href="#"><i class="icon-facebook"></i></a></li>
                        <li class="to-animate-2"><a href="#"><i class="icon-twitter"></i></a></li>
                        <li class="to-animate-2"><a href="#"><i class="icon-instagram"></i></a></li>
                    </ul>
                </div>
            </div>
        </div>
    </div>

    <!-- jQuery -->
    <script src="js/jquery.min.js"></script>
    <!-- jQuery Easing -->
    <script src="js/jquery.easing.1.3.js"></script>
    <!-- Bootstrap -->
    <script src="js/bootstrap.min.js"></script>
    <!-- Bootstrap DateTimePicker -->
    <script src="js/moment.js"></script>
    <script src="js/bootstrap-datetimepicker.min.js"></script>
    <!-- Waypoints -->
    <script src="js/jquery.waypoints.min.js"></script>
    <!-- Stellar Parallax -->
    <script src="js/jquery.stellar.min.js"></script>

    <!-- Flexslider -->
    <script src="js/jquery.flexslider-min.js"></script>
    <script>
        $(function () {
            $('#date').datetimepicker();
        });
	</script>
    <!-- Main JS -->
    <script src="js/main.js"></script>

</body>
</html>
