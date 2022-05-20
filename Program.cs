try {
    var uploadedCount = SimulateUpload();
    ShowMessage($"已成功上傳{uploadedCount}筆");
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

