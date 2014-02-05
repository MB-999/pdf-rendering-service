# PDF Rendering Service

A simple web service that can render HTML to PDF. Uses [Rotativa](https://github.com/webgio/Rotativa) and [wkhtmltopdf](https://github.com/wkhtmltopdf/wkhtmltopdf). Is deployed as a Azure Cloud Service.

This service is used by [valtech_profiles](https://github.com/valtech/valtech_profiles), which cannot use Rotativa / wkhtmltopdf by itself (it isn't allowed as it is deployed as a Web Site).

# Local setup

## Dependencies

 * Visual Studio 2013.
 * Azure SDK: http://www.windowsazure.com/en-us/downloads/

## Run locally

 * Just build the solution and run it.

# Deploy

## Manual deploy

 * Right-click *PdfRenderingService* Azure stuff in the solution, and click *Package...*
 * Use:
    * Service configuration: Cloud
    * Build configuration: Release
    * Leave all checkboxes unselected.
 * Click Package.
 * Wait a while. Visual Studio will open `PdfRenderingService\bin\Release\app.publish` when it is done, where the two artifacts we want to deploy are located.
 * Go to the Azure Management Portal for the `pdf-rendering-service` Cloud Service: https://manage.windowsazure.com/valtech.de#Workspaces/CloudServicesExtension/CloudService/pdf-rendering-service/dashboard
 * Click upload in the "drawer" at the bottom of the screen.
 * Use:
   * Deployment Label: Some descriptive text string, e.g. a git tag or commit sha, or "fixes bug #123"
   * Package: `PdfRenderer.cspkg`
   * Configuration: `ServiceConfiguration.Cloud.cscfg`
   * Make sure "Deploy even if one or more roles contain a single instance" is **checked**.
 * Click the OK button.
 * Wait a loooooong time.
 * The release is live when the instance status has changed to *Running*.

You can see progress in the drawer-at-the-bottom-of-the-screen, and the *Instances* and *Dashboard* tabs.

## Automated deploy

**TODO: Implement this through the internal Jenkins instance.**

# Azure Management Portal

 * URL: https://manage.windowsazure.com
 * Account: Your Office 365 account (select "Organizational Account" if asked).