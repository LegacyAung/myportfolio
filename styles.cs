/* Define variables for colors */
/* Import Google Fonts */
@import url("https://fonts.googleapis.com/css2?family=Poppins:wght@400;600;700&display=swap");
@import url("https://fonts.googleapis.com/css2?family=Nunito:ital,wght@0,300;0,400;0,600;0,700;1,300;1,400&display=swap");
/* Global styles */
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
  text-decoration: none;
  outline: none;
  border: none;
  text-transform: none;
  transition: all 0.2s linear;
}

html {
  font-size: 80.5%;
  overflow-x: hidden;
  scroll-behavior: smooth;
}

body {
  background: #f7f7f7;
  font-family: "Poppins", sans-serif;
  position: relative; /* Ensure body stretches to full height */
}

*::selection {
  background: #2b3dda;
  color: #fff;
}

/* Navbar Styles */
.navbar {
  padding-left: 5rem;
  padding-right: 5rem;
  font-size: 1.5rem;
  box-shadow: rgba(0, 0, 0, 0.16) 0px 1px 4px;
  /* Navbar brand */
  /* Navbar navigation */
}
.navbar-brand {
  font-size: 2rem;
  font-weight: 700;
  position: relative;
  display: inline-block;
  background: linear-gradient(to right, black 50%, rgb(30, 144, 255) 50%);
  background-size: 200% 100%;
  background-position: -100%;
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
  transition: background-position 0.5s ease;
}
.navbar-brand:hover {
  background-position: 0;
}
.navbar-nav {
  display: flex;
  justify-content: flex-end;
  width: 100%;
  padding: 0;
  margin: 0;
}
.navbar-nav .nav-item {
  margin: 0 10px; /* Adjust as needed */
}
.navbar-nav .nav-link {
  display: block;
  position: relative;
  padding: 1rem;
  text-decoration: none;
  color: #000;
  transition: color 0.3s ease, transform 0.3s ease;
}
.navbar-nav .nav-link::after {
  content: "";
  display: block;
  width: 0;
  height: 2px;
  background: rgb(30, 144, 255);
  position: absolute;
  left: 0;
  bottom: 0;
  transition: width 0.3s ease;
}
.navbar-nav .nav-link:hover {
  color: rgb(30, 144, 255);
  transform: translateY(-2px);
}
.navbar-nav .nav-link:hover::after {
  width: 100%;
}

/* Hero Section */
#hero {
  padding: 100px 0;
  text-align: center;
  position: relative; /* Ensure hero section is positioned correctly */
  z-index: 2; /* Higher z-index to be on top */
}
#hero .hero-content {
  font-size: 3rem;
  font-weight: bold;
}
#hero .hero-content .hero-description {
  font-size: 2rem;
}
#hero .hero-content span {
  color: rgb(30, 144, 255);
}
#hero .hero-content .btn {
  margin-top: 20px;
  font-size: 1.5rem;
  border-radius: 50px;
  padding: 12px 30px;
  background-color: rgb(30, 144, 255);
  position: relative;
}
#hero .hero-content .btn .fa-solid {
  margin-left: 10px;
  transition: margin-left 0.3s ease;
}
#hero .hero-content .btn:hover {
  background-color: rgb(20, 139, 199);
}
#hero .hero-content .btn:hover .fa-solid {
  margin-left: 15px; /* Adjust as needed */
}
#hero .hero-content .socials-hero {
  margin-top: 20px;
}
#hero .hero-content .socials-hero a {
  color: inherit; /* Default icon color */
  font-size: 2rem; /* Icon size */
  margin: 0 10px; /* Spacing between icons */
  transition: color 0.3s ease-in-out, transform 0.3s ease-in-out;
}
#hero .hero-content .socials-hero a:hover {
  color: rgb(30, 144, 255);
  transform: scale(1.2);
}
@media (min-width: 576px) {
  #hero .hero-content {
    font-size: 3.5rem; /* Font size for small devices and up */
    font-weight: bold;
  }
}
@media (min-width: 768px) {
  #hero .hero-content {
    font-size: 3.5rem; /* Font size for medium devices and up */
    font-weight: bold;
  }
}
@media (min-width: 992px) {
  #hero .hero-content {
    font-size: 4rem; /* Font size for large devices and up */
    font-weight: bold;
  }
}

/* About Me Section */
#aboutme {
  background-color: #deeafc;
}
#aboutme .container h2 {
  font-weight: bold;
}
#aboutme .container h2 i {
  padding-right: 1rem;
}
#aboutme .container span {
  color: rgb(30, 144, 255);
}
#aboutme .container .text-center {
  margin-bottom: 2rem;
}
#aboutme .container .row-div {
  margin-top: 5rem;
  padding: 1.5rem;
}
@media (max-width: 767px) {
  #aboutme .container .row-div {
    flex-direction: column;
    align-items: center;
  }
}
#aboutme .container .aboutme-image-div {
  margin: 1.5rem;
}
#aboutme .container .aboutme-image-div img {
  margin-left: 25px;
  border-radius: 15px;
  width: 100%;
  max-width: 250px;
  height: auto;
  box-shadow: rgba(60, 64, 67, 0.3) 0px 1px 2px 0px, rgba(60, 64, 67, 0.15) 0px 2px 6px 2px;
}
@media (max-width: 767px) {
  #aboutme .container .aboutme-image-div {
    margin-bottom: 2rem;
  }
}
#aboutme .container .aboutme-description-div {
  margin: 1.5rem;
  font-size: 16px;
}
#aboutme .container .aboutme-description-div h2,
#aboutme .container .aboutme-description-div p {
  opacity: 0;
  transform: translateY(-50px);
  transition: opacity 0.5s ease-in-out, transform 0.5s ease-in-out;
}
#aboutme .container .aboutme-email {
  text-transform: lowercase;
}
#aboutme .container .aboutme-resume-btn {
  width: 10rem;
}
#aboutme .container .aboutme-resume-btnhover {
  background-color: rgb(20, 139, 199);
}

/* Skills Section Style*/
#skills .container h2 {
  font-weight: bold;
}
#skills .container h2 i {
  padding-right: 1rem;
}
#skills .container .text-center {
  margin-bottom: 2rem;
}
#skills .container .row {
  display: flex;
  flex-wrap: wrap;
  justify-content: center;
}
#skills .container .skill-card {
  box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
  border: none;
  border-radius: 8px;
  padding: 0.5rem;
  margin: 1rem;
  transition: transform 0.3s;
}
#skills .container .skill-card:hover {
  transform: translateY(-5px);
}
#skills .container .skill-card .card-body {
  text-align: center;
}
#skills .container .skill-card .card-body .card-title {
  font-size: 1.5rem;
  margin-bottom: 1rem;
  font-weight: bold;
}
#skills .container .skill-card .card-body .card-title i {
  margin-right: 1rem;
}
#skills .container .skill-card .card-body .progress {
  height: 20px;
  background-color: #f1f1f1;
  border-radius: 10px;
}
#skills .container .skill-card .card-body .progress .progress-bar {
  background-color: #007bff;
  font-size: 14px;
  border-radius: 10px;
  transition: width 0.5s;
}

/* experiences section */
#experiences {
  background-color: #296b87;
}
#experiences .container h2 {
  font-weight: bold;
  color: #f1f1f1;
}
#experiences .container h2 i {
  margin-right: 1rem;
}
#experiences .container .text-center {
  margin-bottom: 2rem;
}
#experiences .container .timeline {
  position: relative;
  margin: 0 auto;
  padding: 40px 0;
  width: 95%;
}
#experiences .container .timeline::before {
  content: "";
  position: absolute;
  left: 50%;
  top: 0;
  bottom: 0;
  width: 2px;
  background: #e9ecef;
  transform: translateX(-50%);
}
#experiences .container .timeline-item {
  position: relative;
  margin-bottom: 20px;
}
#experiences .container .timeline-item:nth-child(odd) .timeline-content {
  left: 0;
  text-align: left;
}
#experiences .container .timeline-item:nth-child(even) .timeline-content {
  left: calc(50% + 90px);
  text-align: left;
}
#experiences .container .timeline-item:nth-child(odd) .timeline-icon, #experiences .container .timeline-item:nth-child(even) .timeline-icon {
  left: 48.5%;
}
#experiences .container .timeline-icon {
  position: absolute;
  top: 20px;
  transform: translateY(-50%);
  background: #fff;
  border: 2px solid #e9ecef;
  border-radius: 50%;
  height: 40px;
  width: 40px;
  padding: 10px;
  font-size: 20px;
  display: flex;
  align-items: center;
  justify-content: center;
}
#experiences .container .timeline-content {
  position: relative;
  width: 45%;
  padding: 20px;
  background: #fff;
  border-radius: 5px;
  box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
}
#experiences .container .timeline-content h3 {
  margin-top: 0;
}
#experiences .container .card {
  margin-top: 10px;
}
#experiences .container .card .card-body {
  padding: 15px;
}

/*Contact section*/
#contact {
  background-color: #f9f9f9;
  padding: 5rem 0;
}

#contact h2 {
  font-weight: bold;
}
#contact h2 i {
  padding-right: 1rem;
}

#contact span {
  color: #296b87; /* Primary color */
}

#contact .container .form-control {
  border-radius: 0.25rem;
}
#contact .container .btn {
  width: 10rem;
  background-color: #296b87; /* Primary color */
  border: none;
}
#contact .container .btn:hover {
  background-color: #1f4e5f;
}

/* Section Styles */
section {
  padding: 60px 0;
}

h2 {
  margin-bottom: 20px;
}

ul.list-unstyled {
  padding: 0;
  list-style: none;
}

/* Footer Styles */
footer {
  background: #f8f9fa;
  padding: 20px 0;
}

/*# sourceMappingURL=styles.cs.map */
