<div id="top"></div>
<div align="center">
  
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
</div>


<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="http://www.duett.no">
    <img src="https://duett.no/wp-content/uploads/2017/09/Logo214x90.png" alt="Logo">
  </a>

  <h3 align="center">Duett Economy Open API</h3>

  <p align="center">
    An awesome API to jumpstart your integration with Duett Economy!
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
      <a href="#features-that-are-being-worked-on">Features that are being worked on</a>
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

Become less dependent on systems and streamline everyday life. We help you get the systems to play well together so that everyone can spend their time on value-creating tasks.

If you want to develop an integration, just contact us, and we will provide you with information about the process of becoming an integration partner.

In this repo you will find ready-made codes that allows you to quickly reach your goal with your integration project. You can suggest changes and suggest new functionality in the discussion forum, or send an e-mail to us at api@duett.no

<p align="right">(<a href="#top">back to top</a>)</p>

<!-- CURRENT STATUS -->
## Current status

**Article:**
This datagroup got all you need to mangage articles eg. for hour registation, orders and travel expenses etc.
<p align="right">(<a href="#top">back to top</a>)</p>

**Carriers:**
This data group has everything you need to manage operators, e.g. employee, wage types, departments, free carriers etc.
<p align="right">(<a href="#top">back to top</a>)</p>

**Carrier Types:**
This data group has everything you need to manage carruier types, and create free carrier types.
<p align="right">(<a href="#top">back to top</a>)</p>

**Customer:**
This datagroup got all you need to mangage customers.
<p align="right">(<a href="#top">back to top</a>)</p>

**Hour registation:**
The time registration endpoints provide opportunities to submit hours for invoicing and for payroll. Articles, carriers, carrier types, customers and projects can be administered.
<p align="right">(<a href="#top">back to top</a>)</p>

**Order:**
The order endpoints allow you to submit orders for invoicing and orders as offers. Attachments to the order such as receipts are sent together with the order and are included in order processing in Duett Economy.
<p align="right">(<a href="#top">back to top</a>)</p>

**Prodject:**
This datagroup got all you need to mangage projects. Note that project is a carrier with extended set of properties 
<p align="right">(<a href="#top">back to top</a>)</p>

**Register:**
The most important basic registers like ZipCodes, UnitCodes, AccountIntervals, VoucherTypes (bilagsarter), AccountCharts (kontoplan). 
<p align="right">(<a href="#top">back to top</a>)</p>

**Report:**
This datagroup got Norwegian field names for reporting purposes in eg. Excel, Access. This is a replacement for those who have had access to database views.
<p align="right">(<a href="#top">back to top</a>)</p>

**Supplier:**
This datagroup got all you need to mangage suppliers.
<p align="right">(<a href="#top">back to top</a>)</p>

**System:**
This datagroup got a ping metode and an metode to get information about you integration.
<p align="right">(<a href="#top">back to top</a>)</p>

**Voucher:**
Register a company's voucher in the accounts. You can also use the term bookkeeping. This is the main replacement of the old fileimport. This is a big task for the API team, and therefore we can not promise when it is in place.
<p align="right">(<a href="#top">back to top</a>)</p>

<!-- FEATURES THAT ARE BEING WORKED ON -->
## Features that are being worked on

We are now in a maintenance sprint. The plan is to improve documentation and increase the throughput of data. Faster response and streaming of json data.

<!-- GETTING STARTED -->
## Getting Started

In this repo you will find a client made in C # code that you can download and use as is, or make changes to it. There are also examples of codes in other languages that you can either use as an idea, or to use parts of the code. These examples are not maintained and are here for guidance only. <a href="https://github.com/Duett-AS/DuettAPI/tree/main/.NET%20ApiClient">The code is here</a>. NB: All code is autogenerated.
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
[contributors-shield]: https://img.shields.io/github/contributors/Duett-AS/DuettAPI.svg?style=for-the-badge
[contributors-url]: https://github.com/Duett-AS/DuettAPI/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/Duett-AS/DuettAPI.svg?style=for-the-badge
[forks-url]: https://github.com/Duett-AS/DuettAPI/network/members
[stars-shield]: https://img.shields.io/github/stars/Duett-AS/DuettAPI.svg?style=for-the-badge
[stars-url]: https://github.com/Duett-AS/DuettAPI/stargazers
[issues-shield]: https://img.shields.io/github/issues/Duett-AS/DuettAPI.svg?style=for-the-badge
[issues-url]: https://github.com/Duett-AS/DuettAPI/issues
[license-shield]: https://img.shields.io/github/license/Duett-AS/DuettAPI.svg?style=for-the-badge&logo=data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAR4SURBVFhHtZdraBRXFMdn7szu5r2JQSyC4pMireKH0o9+KIKQloLBBwgxnxRMUESCj1qKooVoqNa2SduPBm1RfBsSBD+JRRQ/iK1BodEgWhBJYmJeuzuP/s+ds8PM7B03m9ofLPfcc2fuPffcc86d1bUibHL3LELTkH1r1zk5t7lsjrncG1EzPWwNarrWXVZnvkK397x+YtAbUfNOA2jxzKh9PJU2NrKqJGBMHwzugRhriNIAWtiacja4rnYoUSEqWT1rMNevZrloVxlRYIDc9Zh9LFVjbGJViKkhq18X2gV2sQ/eqccRNZbXm6tZFYK90RI1ImQALY4HO/FgA6t8EAPdyWrjLsRYd+bjhYwRhrYvUWmEvJcdtw9cqT7Vzl2Jb0DczmHQbRj0O8SiARVEtRnM/83V9Kkj3JX4BjRO7m7DOXVwV4Jd/4ZdHyxl4SC8qaap11ajSOiPahYmv1YeAT2Ym7AfwmXVUgv+6+IzRVe5nt3eFFycnpt8ldtpZ91aVnnomgPPvUbwvUCvpGMiyIAWtJ1e16cVE3WxLFn3tLUnvTj1OXeVwGujaDrgubNxhnw5vGtZ5o39vZHSn1fNTx4XuUmnisck5Ho0vV4vgKstYykWLJzG7ygVL/IYq0NkRuxrtBEsvgMpvV2gSDTxmAQT/DETN2bH7KHRp5n+3Lj9llU+VDmxMWUdQQ3xU1MYerPA2X3MfW16xPobTeHuI8Dyv5I1xic3lnZ+lKgyVkHVmnljXfRGPRzL3RvjhfvcaqlaY75gWeJk3Wsz2v2o/U/+OWrx60rVmm3YANV9CYK6Hk1BQauYl7jDoiRkQPlcs6QIDkKGoDz3cVeCbPqARR9kzCSLkpAButBtFt8LuQlnAYuxhAz4H3C4jSVkgOu4BovvhWTaKHqkIQNQs5W5OxMo4pEd27grQSAOsegTrTtUCV2WKWgGUILXqjJh3UDr4/SS1IckUxoifX+WA4A8Nz1ibw+l9LD1DHN9FpyLjTyH5z5llSag+JNlDS8sRVOQOlF4ISrf8ofg/SG4OIEcP6nYSENwcaTtS4FPrm7uS3AxrYkpIEUDKo817XTBqOvc9UGZr2NR4jpat4jmJc5tM5oCLwhTv8diLPDmAxzHLrNMdER3T5vSdW0fdyXwxgt5HcOyb3EHbGE9TXQPg5uj54em2PEor2N6F+7+EYXqC1ZRjNzEkW/zP0hgxAO6zeQowFGcgzf2qyYsBZobBemrRKUIZQiQV75MQ1oE9/NhqWboKMgzvPNZEbc4faajkZeeXweMpLhMu+auhI4FrjqLiVpKNYSeh9t/iS6O+fqC/xEKP8sjZ5UHn9RnklUG3WRFP8sxxzwEIn3kVngjHoitW4it5uD7IQMImgSeaOdsKAA7eIJ/TJcoglkloUWRVuuhX8mqEHivF0FH5x4yvsAAgoyQf80c91D0z8VssDPOT0ZKfKfynNKAPOyN2L9pxYBXevgbIfbY3mkAkT9XxECNnXG3wsUrvBE1cPWAbuqnYTRdREU+0zXtXyYSQsWZfDg1AAAAAElFTkSuQmCC
[license-url]: https://github.com/Duett-AS/DuettAPI/blob/main/LICENSE
[product-screenshot]: images/screenshot.png
