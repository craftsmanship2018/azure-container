## Story

The business has a basic website used for marketing, supplying information about the company, its contact details and so on. This is currently hosted on a pair of servers sitting behind an NLB, with the infrastructure residing in a managed Data centre. The technology used is Windows Server and IIS, with the site built in ASP.NET Core.

As the business has grown, the company has seen an increase in the cost of purchasing and managing their server environment to keep up with spikes in traffic. As such a strategic decision has been made however to retire this data centre in favour of Azure hosting. 


## Technology

The desired strategy for this site in particular is to continue using the web application as is, but move this solution into a containerised image hosted in Azure.

## Getting Started

1. Fork and clone this repository
1. Open `src\azure-container.sln` in Visual Studio 2017
1. Build the solution and press `F5` to debug and validate it works

## Goal

1. Convert the application to run in a containerised image.
1. Deploy instances of this container to the Azure platform in whatever method is deemed most appropriate.
1. Build a CI/CD pipeline that will build and test the container image and subsequently deploy and run instances of this container onto the Azure platform.


## Change Scenario

To test the pipeline, a simple change should be committed to the application's repository. You could, for example, add or amend content on the site.

For additional challenge extend the functionality of the "Contact Us" page to allow users to enter details and a query. These details should be stored in an XML file that is intended to be consumed by a down stream process.