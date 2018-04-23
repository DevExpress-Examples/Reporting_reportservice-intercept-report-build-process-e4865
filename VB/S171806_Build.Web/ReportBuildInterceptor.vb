Imports Microsoft.VisualBasic
Imports System.ComponentModel.Composition
Imports DevExpress.XtraReports.Service.Extensions
Imports DevExpress.XtraReports.UI

Namespace S171806_Build.Web
	<Export(GetType(IReportBuildInterceptor))> _
	Public Class ReportBuildInterceptor
		Implements IReportBuildInterceptor
		#Region "IReportBuildInterceptor Members"
		Private Sub InvokeBefore(ByVal report As XtraReport, ByVal customArgs As Object) Implements IReportBuildInterceptor.InvokeBefore
			report.Watermark.Text = "Immutable Text"
			report.Watermark.ShowBehind = False
			report.Watermark.TextTransparency = 0
		End Sub

		Private Sub InvokeAfter(ByVal report As XtraReport, ByVal customArgs As Object) Implements IReportBuildInterceptor.InvokeAfter
		End Sub
		#End Region
	End Class
End Namespace