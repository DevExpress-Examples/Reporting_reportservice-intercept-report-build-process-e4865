<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128604666/13.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4865)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[ReportBuildInterceptor.cs](./CS/S171806_Build.Web/ReportBuildInterceptor.cs) (VB: [ReportBuildInterceptor.vb](./VB/S171806_Build.Web/ReportBuildInterceptor.vb))**
<!-- default file list end -->
# ReportService - Intercept report build process
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4865)**
<!-- run online end -->


<p>Report build process can be intercepted by IReportBuildInterceptor extension. Process can be intercepted before and after invocation.<br />
Create class that implements IReportBuildInterceptor interface and register it to service container; by default, add attribute [Export(typeof(IReportBuildInterceptor))] on your class.</p>

<br/>


