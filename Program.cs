using lab2;

Alarm alarm = new Alarm(12, 30, 12, 30);
Alarm alarm1 = new Alarm("9:10", "11:30");

Console.WriteLine($"{alarm.CheckTimeLeft()} minutes left");

Console.WriteLine($"{alarm1.CheckTimeLeft()} minutes left");

