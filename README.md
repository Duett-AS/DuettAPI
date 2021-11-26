<div id="top"></div>
<!--
*** Thanks for checking out the Best-README-Template. If you have a suggestion
*** that would make this better, please fork the repo and create a pull request
*** or simply open an issue with the tag "enhancement".
*** Don't forget to give the project a star!
*** Thanks again! Now go create something AMAZING! :D
-->



<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]



<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/othneildrew/Best-README-Template">
    <img src="https://duett.no/wp-content/uploads/2017/09/Logo214x90.png" alt="Logo">
  </a>

  <h3 align="center">Duett Economy Open API</h3>

  <p align="center">
    An awesome API to jumpstart your integration with Duett Economy !
    <br />
    <br />
    <a href="https://api.duett.no/swagger/index.html">View the swagger</a>
    ·
    <a href="https://duett.no/integrasjoner/">The integration information</a>
    ·
    <a href="https://github.com/Duett-AS/DuettAPI/issues">Request Feature</a>
    ·
    <a href="https://github.com/Duett-AS/DuettAPI/wikis">Wiki</a>
    ·
    <a href="https://github.com/Duett-AS/DuettAPI/discussions">Discussions</a>
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
    </li>
    <li>
      <a href="#current-status">Current status</a>
    </li>
    <li>
      <a href="#features-that-are-being-worked on">Features that are being worked on</a>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

Today, there are many systems that are poorly or not integrated. This creates a lot of duplication and inefficiency by having to register the same data in several systems. Many companies have invested heavily in integrations that create data flow between systems, but changes are often expensive to implement due to high complexity, which leads to change refusal and low flexibility.

Duett offers an API for creating effective and future-oriented integrations with Duett Economy. We have created an API that enables integration partners to deliver integration services faster and more cost-effectively than is possible with traditional integration development.

Become less dependent on systems and streamline everyday life. We help you get the systems to play together so that everyone can spend their time on value-creating tasks.

In this repo you will find ready-made codes that allow you to quickly reach your goal with your integration project. You can suggest changes and suggest new functionality in the discussion forum, or send us an e-mail to api@duett.no .

<p align="right">(<a href="#top">back to top</a>)</p>

## Current status
**Hour registation:**
The time registration endpoints provide opportunities to submit hours for invoicing and for payroll. Articels, carriers, carrier types, customers and projects can be administered.
<p align="right">(<a href="#top">back to top</a>)</p>

### Features that are being worked on
**Order:**
The order endpoints allow you to submit orders for invoicing and orders as offers.
<p align="right">(<a href="#top">back to top</a>)</p>
<!-- GETTING STARTED -->
## Getting Started

In this repo you will find a client made in C # code that you can download and use as is, or make changes to. There are also examples of codes in other languages that you can either use as an idea, or to use parts of the code. These examples are not maintained and are here for guidance only. <a href="https://github.com/Duett-AS/DuettAPI/tree/main/.NET%20ApiClient">The code is here</a>
<p align="right">(<a href="#top">back to top</a>)</p>

<!-- USAGE EXAMPLES -->
## Usage

Usage
```CSHARP
var httpClient = new HttpClient();
httpClient.BaseAddress = new Uri("https://api.duett.no");
var apiClient = new DuettApiClient(httpClient, "integrationKey", "clientKey");
```


<p align="right">(<a href="#top">back to top</a>)</p>

<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE` for more information.

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- CONTACT -->
## Contact

Duett API Team - api@duett.no

Project Link: [https://github.com/Duett-AS/DuettAPI](https://github.com/Duett-AS/DuettAPI)

<p align="right">(<a href="#top">back to top</a>)</p>


<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/othneildrew/Best-README-Template.svg?style=for-the-badge
[contributors-url]: https://github.com/othneildrew/Best-README-Template/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/othneildrew/Best-README-Template.svg?style=for-the-badge
[forks-url]: https://github.com/othneildrew/Best-README-Template/network/members
[stars-shield]: https://img.shields.io/github/stars/othneildrew/Best-README-Template.svg?style=for-the-badge
[stars-url]: Duett-AS/DuettAPI/stargazers
[issues-shield]: https://img.shields.io/github/issues/othneildrew/Best-README-Template.svg?style=for-the-badge
[issues-url]: https://github.com/Duett-AS/DuettAPI/issues
[license-shield]: https://img.shields.io/github/license/othneildrew/Best-README-Template.svg?style=for-the-badge
[license-url]: https://github.com/othneildrew/Best-README-Template/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/othneildrew
[product-screenshot]: images/screenshot.png
