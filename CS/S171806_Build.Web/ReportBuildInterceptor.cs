using System.ComponentModel.Composition;
using DevExpress.XtraReports.Service.Extensions;
using DevExpress.XtraReports.UI;

namespace S171806_Build.Web {
    [Export(typeof(IReportBuildInterceptor))]
    public class ReportBuildInterceptor : IReportBuildInterceptor {
        #region IReportBuildInterceptor Members
        void IReportBuildInterceptor.InvokeBefore(XtraReport report, object customArgs) {
            report.Watermark.Text = "Immutable Text";
            report.Watermark.ShowBehind = false;
            report.Watermark.TextTransparency = 0;
        }

        void IReportBuildInterceptor.InvokeAfter(XtraReport report, object customArgs) {
        }
        #endregion
    }
}