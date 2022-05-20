try {
    var uploadedCount = SimulateUpload();
    Console.WriteLine($"已成功上傳{uploadedCount}筆");
    Thread.Sleep(2000);
}
catch (Exception ex) {
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(ex.Message);
    Console.ReadLine();
}

int SimulateUpload() {
    //模擬上傳作業
    var rnd = new Random();
    if (rnd.Next() % 3 == 1) 
        throw new ApplicationException("隨機模擬上傳失敗");
    Thread.Sleep(1500 + rnd.Next(3000));
    return rnd.Next(5) + 1;
}

