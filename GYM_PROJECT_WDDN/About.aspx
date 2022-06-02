<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" inherits="GYM_PROJECT_WDDN.About" %>
<asp:Content iD="Content1" ContentPlaceHolderiD="head" runat="server">
</asp:Content>
<asp:Content iD="Content2" ContentPlaceHolderiD="ContentPlaceHolder1" runat="server">
    <main>
    <!--? Hero Start -->
    <div class="slider-area2">
        <div class="slider-height2 d-flex align-items-center">
            <div class="container">
                <div class="row">
                    <div class="col-xl-12">
                        <div class="hero-cap hero-cap2 pt-70">
                            <h2>About Us</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Hero End -->
    <!--? Team -->
    <section class="team-area pt-80">
        <div class="container">
            <div class="row">
                <div class="col-lg-4 col-md-6">
                    <div class="single-cat text-center mb-30 wow fadeinUp" data-wow-duration="1s" data-wow-delay=".2s" >
                        <div class="cat-icon">
                            <img src="assets/img/gallery/team1.png" alt="">
                        </div>
                        <div class="cat-cap">
                            <h5><a href="services.html">Body Building</a></h5>
                            <p>You’ll look at graphs and charts in Task One, how to approach the task </p>
                        </div>
                    </div>
                </div>
                <div class="col-lg-4 col-md-6">
                    <div class="single-cat text-center mb-30 wow fadeinUp" data-wow-duration="1s" data-wow-delay=".4s">
                        <div class="cat-icon">
                            <img src="assets/img/gallery/team2.png" alt="">
                        </div>
                        <div class="cat-cap">
                            <h5><a href="services.html">Muscle Gain</a></h5>
                            <p>You’ll look at graphs and charts in Task One, how to approach the task </p>
                        </div>
                    </div>
                </div>
                <div class="col-lg-4 col-md-6">
                    <div class="single-cat text-center mb-30 wow fadeinUp" data-wow-duration="1s" data-wow-delay=".6s">
                        <div class="cat-icon">
                            <img src="assets/img/gallery/team3.png" alt="">
                        </div>
                        <div class="cat-cap">
                            <h5><a href="services.html">iight Loss</a></h5>
                            <p>You’ll look at graphs and charts in Task One, how to approach the task </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Services End -->
    <!--? About Area-2 Start -->
    <section class="about-area2 fix pb-padding pt-50 pb-80">
        <div class="support-wrapper align-items-center">
            <div class="right-content2 wow fadeinUp" data-wow-duration="1s" data-wow-delay=".2s" >
                <!-- img -->
                <div class="right-img">
                    <img src="assets/img/gallery/about.png" alt="">
                </div>
            </div>
            <div class="left-content2">
                <!-- section tittle -->
                <div class="section-tittle2 mb-20 wow fadeinUp" data-wow-duration="1s" data-wow-delay=".3s">
                    <div class="front-text">
                        <h2 class="">About Us</h2>
                        <p>You’ll look at graphs and charts in Task One, how to approach the task and the language needed 
                            for a successful ansir. You’ll examine Task Two questions and learn how to plan, write and 
                        check academic essays.</p>
                        <p class="mb-40">Task One, how to approach the task and the language needed for a successful ansir. You’ll 
                        examine Task Two questions and learn how to plan, write and check academic essays.</p>
                        <a href="courses.aspx" class="border-btn">Our Courses</a>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- About Area End -->

    <!--? video_start -->
    <div class="video-area section-bg2 d-flex align-items-center"  data-background="assets/img/gallery/video-bg.png">
        <div class="container">
            <div class="video-wrap position-relative">
                <div class="video-icon" >
                     <a class="popup-video btn-icon" href="https://www.youtube.com/watch?v=Lr-xF99TRKg"><i class="fas fa-play"></i></a>
                </div>
            </div>
        </div>
    </div>
</main>
</asp:Content>
