

int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };

var birdCount = new BirdCount(birdsPerDay);

birdCount.LastWeek();
System.Console.WriteLine(birdCount.Today());
birdCount.IncrementTodaysCount();
System.Console.WriteLine(birdCount.HasDayWithoutBirds());
birdCount.CountForFirstDays(4);
birdCount.BusyDays();