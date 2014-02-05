using System;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Rotativa;

namespace PdfRenderingService.WebRole.Controllers
{
    public class PdfGenerationController : Controller
    {
        //
        // GET: /generate-pdf?url={url}&filename={filename?}
        public ActionResult GeneratePdf()
        {
            var url = Request.QueryString["url"];
            if (string.IsNullOrEmpty(url))
                throw new HttpException((int)HttpStatusCode.BadRequest, "Must specify a URL query parameter");

            // Verify that it is a valid URI
            var dummy = new Uri(url);

            var filename = Request.QueryString["filename"];

            var view = new UrlAsPdf(url);
            if (!string.IsNullOrEmpty(filename))
            {
                view.FileName = filename;
            }
            return view;
        }
	}
}