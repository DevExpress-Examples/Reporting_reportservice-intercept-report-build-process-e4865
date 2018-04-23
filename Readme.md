# ReportService - Intercept report build process


<p>Report build process can be intercepted by IReportBuildInterceptor extension. Process can be intercepted before and after invocation.<br />
Create class that implements IReportBuildInterceptor interface and register it to service container; by default, add attribute [Export(typeof(IReportBuildInterceptor))] on your class.</p>

<br/>


