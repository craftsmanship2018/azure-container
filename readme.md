A business has a basic website used for marketing, supplying basic information about the company, its contact details and so on. This is currently hosted on a pair of traditional servers sitting behind an NLB. Technology used is Windows Server and IIS.

This has been identified as an area of improvement and the desire is to move this site into a containerised image hosted in Azure.

Tasks for Participants:

- Take the existing site and convert it into a containerised image
- Deploy this image to Azure using whatever technologies deemed appropriate

- make changes to the content of the website and deploy the new version

Stretch Goals
- store container images on a private hub hosted in Azure
- extend the functionality of the "Contact Us" page to allow users to enter details and a query. These details should be stored in an XML file to be consumed by a down stream process.