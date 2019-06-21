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


