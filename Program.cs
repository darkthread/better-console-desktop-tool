var form = new Form() {
    FormBorderStyle = FormBorderStyle.None, StartPosition = FormStartPosition.CenterScreen,
    TopMost = true, ControlBox = false, ShowInTaskbar = false, Opacity = 0.8, Width = 0, Height = 0
};
var lbl = new Label() {
    Padding = new Padding(8), AutoSize = true, Font = new Font("微軟正黑體", 12, FontStyle.Bold),
    BackColor = Color.Coral
};
form.Controls.Add(lbl);
form.Show();
var startX = form.Left;
void ShowInfo(string message) {
    lbl.Text = message;
    form.Width = lbl.Width;
    form.Height = lbl.Height;
    form.Left = startX - form.Width / 2;
    form.Refresh();
}
try {
    ShowInfo("上傳中...");
    var uploadedCount = SimulateUpload();
    ShowInfo($"已成功上傳{uploadedCount}筆");
    Thread.Sleep(2000);
    form.Close();
}
catch (Exception ex) {
    ShowMessage(ex.Message);
}
void ShowMessage(string msg) {
    System.Windows.Forms.MessageBox.Show(msg, "上傳作業");
}

int SimulateUpload() {
    //模擬上傳作業
    var rnd = new Random();
    if (rnd.Next() % 3 == 1) 
        throw new ApplicationException("隨機模擬上傳失敗");
    Thread.Sleep(1500 + rnd.Next(3000));
    return rnd.Next(5) + 1;
}