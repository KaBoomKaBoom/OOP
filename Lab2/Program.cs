using System.Threading;
using Lab2;

var consoleMenu = new ConsoleMenu();
var menuThread = new Thread(new ThreadStart(consoleMenu.ConsoleOperations));
menuThread.Start();

var changeDetection = new FileChangeDetection();
Thread t = new Thread(new ThreadStart(changeDetection.StartDetection));
t.Start();
t.Join(); 

menuThread.Join();
