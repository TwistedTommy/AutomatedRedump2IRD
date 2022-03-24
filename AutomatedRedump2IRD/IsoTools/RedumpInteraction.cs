using IsoTools;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedRedump2IRD {
    internal class RedumpInteraction : EmptyInteraction {
        private readonly Timer progress_timer_ = null;
        private readonly ProgressBar progress_bar_ = null;
        private readonly RichTextBox output_ = null;
        private int progress_ = 0;
        public string pathIRDFileName_ = String.Empty;
        public string pathISOFileName_ = String.Empty;

        public RedumpInteraction(ProgressBar progress_bar, RichTextBox output, string pathIRDFileName, string pathISOFileName) {
            progress_bar_ = progress_bar;
            output_ = output;
            pathIRDFileName_ = pathIRDFileName;
            pathISOFileName_ = pathISOFileName;
            progress_timer_ = new Timer();
            progress_timer_.Interval = 200;
            progress_timer_.Tick += new EventHandler(ProgressTimerTick);
            progress_timer_.Start();
        }

        private string ird_output_inital_dir_ = String.Empty;
        public override Task<string> GetIrdOutputFile(string inputFile)
        {
            ird_output_inital_dir_ = Path.GetDirectoryName(pathIRDFileName_);
            return TaskEx.FromResult<string>(pathIRDFileName_);
        }

        private string iso_file_inital_dir_ = String.Empty;
        public override Task<string[]> GetIsoFile(bool verify = false, bool multiple = true)
        {
            iso_file_inital_dir_ = Path.GetDirectoryName(pathISOFileName_);
            return TaskEx.FromResult<string[]>(new string[] { pathISOFileName_ });
        }

        public override void ReportMessage(string message, ReportType reportType) {
            if (output_ != null)
                output_.Invoke((Action)(() => { output_.AppendText("Info: " + message + Environment.NewLine); }));
        }

        public override void ReportProgress(int progress) {
            if (progress != -1)
                progress_ = progress;
            if (progress_bar_ != null)
                progress_bar_.Invoke((Action)(() => { progress_bar_.Value = progress_; }));
        }

        public override void SetProgressMaximum(int max) {
            if (progress_bar_ != null)
                progress_bar_.Invoke((Action)(() => { progress_bar_.Maximum = max; }));
        }

		public override void TaskBegin(TaskType taskType) {
            progress_ = 0;
            if (progress_timer_ != null)
                progress_timer_.Start();
            if (progress_bar_ != null)
                progress_bar_.Invoke((Action)(() => { progress_bar_.Value = progress_; }));
        }

        public override void TaskComplete() {
            if (progress_timer_ != null)
                progress_timer_.Stop();
        }

        private void ProgressTimerTick(object sender, EventArgs e) {
            if (progress_bar_ != null)
                progress_bar_.Value = progress_;
        }
    }
}